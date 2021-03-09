using CocktailApp.Data;
using CocktailApp.Properties;
using CocktailApp.Tools;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public partial class CocktailsForm : BaseForm
    {
        private bool Favourite;

        private string ScreenCapturePath;
        public CocktailsForm()
        {
            InitializeComponent();

            DataAccess.GetIngredients();

            DataAccess.GetCocktails();

            RefreshListContent();
        }

        private void FilterCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * This method is called when either AvailableCheckBox or FavouriteCheckBox is (un-)checked.
             */

            var select = CocktailsListBox.SelectedItem;

            RefreshListContent();

            CocktailsListBox.SelectedItem = select;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess.SearchCocktails(SearchBar.Text, SearchByNameRadioButton.Checked ? "Name" : "Ingredients");

            RefreshListContent();

            if (CocktailsListBox.Items.Count > 0)
            {
                CocktailsListBox.SelectedIndex = 0;
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void CocktailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CocktailsListBox.SelectedItems.Count > 0)
            {
                Cocktail selectedCocktail = CocktailsListBox.SelectedItem as Cocktail;

                if (selectedCocktail.Name.Length > 25)
                {
                    CocktailNameLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
                }
                else if (selectedCocktail.Name.Length > 20)
                {
                    CocktailNameLabel.Font = new Font("Arial", 19F, FontStyle.Bold);
                }
                else
                {
                    CocktailNameLabel.Font = new Font("Arial", 20F, FontStyle.Bold);
                }

                CocktailNameLabel.Text = selectedCocktail.Name.ToUpper();
                IngredientsTextBox.Text = selectedCocktail.FullIngredientInfo;
                RecipeTextBox.Text = selectedCocktail.Recipe;

                CocktailImageBox.Image = selectedCocktail.Image == null ?
                    CocktailImageBox.InitialImage : Format.GetImage(selectedCocktail.Image);

                Favourite = selectedCocktail.Favourite;

                SwitchFavouriteImage();
            }
        }

        private void FavouritePictureBox_Click(object sender, EventArgs e)
        {
            if (CocktailsListBox.SelectedItems.Count > 0)
            {
                Favourite = !Favourite;

                var select = CocktailsListBox.SelectedValue;

                DataAccess.FavouriteCocktail(select.ToString(), Favourite);

                SearchButton.PerformClick();

                if (FavouriteCheckBox.Checked)
                {
                    ClearTextBoxes();
                }
                else
                {
                    CocktailsListBox.SelectedValue = select;
                }

                SwitchFavouriteImage();
            }
        }

        private void PrintCocktailButton_Click(object sender, EventArgs e)
        {
            /*
             * Screenshots InfoPanel and exports it as .png image.
             */

            if (CocktailsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No cocktail selected.", "Print cocktail");
            }
            else
            {
                var dialog = new FolderBrowserDialog() { SelectedPath = ScreenCapturePath };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ScreenCapturePath = dialog.SelectedPath;

                    var filename = Format.SanitizeName(CocktailNameLabel.Text) + ".png";

                    FavouritePictureBox.Visible = false;

                    try
                    {
                        CaptureInfoPanel().Save(Path.Combine(dialog.SelectedPath, filename), ImageFormat.Png);

                        MsgBox.ShowAsync("Success!\r\n\r\nFile location: " + dialog.SelectedPath +
                                    "\r\nFile name: " + filename, "Print cocktail");
                    }
                    catch (Exception exc)
                    {
                        MsgBox.ShowAsync("Error occured\r\n\r\n" + exc.Message, "Print cocktail");
                    }

                    FavouritePictureBox.Visible = true;
                }
            }
        }

        private void PrintMenuButton_Click(object sender, EventArgs e)
        {
            /*
             * Selects each favourited cocktail, screenshots the InfoPanel and combines them it into .pdf file.
             */

            var dialog = new FolderBrowserDialog() { SelectedPath = ScreenCapturePath };

            var n = DataAccess.Cocktails.Where(c => c.Favourite).Count();

            if (n == 0)
            {
                MessageBox.Show("No cocktails favourited.", "Print cocktail");
            }
            else if (dialog.ShowDialog() == DialogResult.OK)
            {
                ScreenCapturePath = dialog.SelectedPath;

                var select = CocktailsListBox.SelectedValue;
                var search = SearchBar.Text;
                var avaCheck = AvailableCheckBox.Checked;
                var favCheck = FavouriteCheckBox.Checked;

                FilterListBox("", false, true);

                var filename = "Cocktail_menu_" + DateTime.Now.ToString("d") + ".pdf";

                FavouritePictureBox.Visible = false;

                try
                {
                    using (PdfDocument doc = new PdfDocument())
                    {
                        for (int i = 0; i < n; i++)
                        {
                            CocktailsListBox.SelectedIndex = i;

                            using (MemoryStream ms = new MemoryStream())
                            {
                                CaptureInfoPanel().Save(ms, ImageFormat.Png);

                                var page = doc.Pages.Add(new PdfPage());

                                XImage ximg = XImage.FromStream(ms);
                                page.Width = ximg.PointWidth;
                                page.Height = ximg.PointHeight;

                                XGraphics xgr = XGraphics.FromPdfPage(page);
                                xgr.DrawImage(ximg, 0, 0);
                            }
                        }
                        doc.Save(Path.Combine(dialog.SelectedPath, filename));
                    }

                    MsgBox.ShowAsync("Success!\r\n\r\nFile location: " + dialog.SelectedPath +
                                    "\r\nFile name: " + filename, "Print cocktail");
                }
                catch (Exception exc)
                {
                    MsgBox.ShowAsync("Error occured\r\n\r\n" + exc.Message, "Print menu");
                }

                FavouritePictureBox.Visible = true;

                FilterListBox(search, avaCheck, favCheck);

                if (CocktailsListBox.Items.Count > 0)
                {
                    CocktailsListBox.SelectedValue = select;
                }
            }
        }

        private void RefreshListContent()
        {
            var cocktails = AvailableCheckBox.Checked ? DataAccess.AvailableCocktails : DataAccess.Cocktails;

            CocktailsListBox.DataSource = FavouriteCheckBox.Checked ?
                cocktails.Where(c => c.Favourite).ToList() : cocktails;
        }

        private void SwitchFavouriteImage()
        {
            FavouritePictureBox.Image = Favourite ? Resources.filled_star : Resources.empty_star;
        }

        private void ClearTextBoxes()
        {
            CocktailsListBox.ClearSelected();

            CocktailNameLabel.Text = "";
            IngredientsTextBox.Text = "";
            RecipeTextBox.Text = "";
            CocktailImageBox.Image = CocktailImageBox.InitialImage;
        }

        private Bitmap CaptureInfoPanel()
        {
            int width = InfoPanel.Width;
            int height = InfoPanel.Height;

            var bmp = new Bitmap(width, height);
            InfoPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

            return bmp;
        }

        private void FilterListBox(string search, bool avaCheck, bool favCheck)
        {
            SearchBar.Text = search;
            AvailableCheckBox.Checked = avaCheck;
            FavouriteCheckBox.Checked = favCheck;

            SearchButton.PerformClick();
        }
    }
}
