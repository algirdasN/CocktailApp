using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public partial class EditCocktailsForm : BaseForm
    {
        private BindingList<string> TagList = new BindingList<string>();

        private byte[] CocktailImage;

        public EditCocktailsForm()
        {
            InitializeComponent();

            DataAccess.GetIngredients();

            RefreshListContent();

            IngredientTagsComboBox.Items.AddRange(DataAccess.Ingredients.Select(i => i.Type).Distinct().ToArray());

            IngredientTagListBox.DataSource = TagList;
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchButton.PerformClick();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess.SearchCocktails(SearchBar.Text, SearchByNameRadioButton.Checked ? "Name" : "Ingredients");

            CocktailsListBox.DataSource = DataAccess.Cocktails;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files | *.csv*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataTransfer.ImportCocktails(dialog.FileName);

                RefreshListContent();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataTransfer.ExportCocktails(dialog.SelectedPath);
            }
        }

        private void CocktailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CocktailsListBox.SelectedItems.Count > 0)
            {
                if (CocktailsListBox.SelectedItem is Cocktail selectedCocktail)
                {
                    NameTextBox.Text = selectedCocktail.Name;
                    TagList = new BindingList<string>(selectedCocktail.Ingredients.Split('|').ToList());
                    IngredientTagListBox.DataSource = TagList;
                    FullIngredientInfoTextBox.Text = selectedCocktail.FullIngredients.Replace("|", "\r\n");
                    RecipeTextBox.Text = selectedCocktail.Recipe;

                    CocktailImage = selectedCocktail.Image;

                    UploadedImagePictureBox.Image = CocktailImage == null ?
                        UploadedImagePictureBox.InitialImage : Format.GetImage(CocktailImage);

                    UploadedFileLabel.Text = CocktailImage == null ?
                        "No image uploaded" : "Image stored on database";
                }
            }
        }

        private void IngredientTagsComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddIngredientButton.PerformClick();
            }
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string str = Format.CapitalizeFirst(IngredientTagsComboBox.Text.Trim());

            if (str.Any() && !IngredientTagListBox.Items.Contains(str))
            {
                TagList.Add(str);
            }

            IngredientTagsComboBox.Text = "";
        }

        private void RemoveIngredientButton_Click(object sender, EventArgs e)
        {
            TagList.Remove(IngredientTagListBox.SelectedItem.ToString());
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files | *.bmp; *.gif; *.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi; *.png; *.tiff; *.tif | All files | *.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UploadedImagePictureBox.Image = Format.ResizeImage(Image.FromFile(dialog.FileName));

                CocktailImage = Format.GetByteArray(UploadedImagePictureBox.Image);

                UploadedFileLabel.Text = dialog.SafeFileName;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearImage();
        }

        private void AddCocktailButton_Click(object sender, EventArgs e)
        {
            string name = Format.CapitalizeEvery(NameTextBox.Text);

            if (DataAccess.Cocktails.Select(c => c.Name).Contains(name))
            {
                SuccessLabelNotUnique();
            }
            else if (TextBoxValidation())
            {
                DataAccess.AddEditCocktail(
                    name: name,
                    ingredients: string.Join("|", TagList),
                    fullIngredients: string.Join("|", FullIngredientInfoTextBox.Text
                                                        .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(s => s.Trim())),
                    recipe: RecipeTextBox.Text.Trim(),
                    image: CocktailImage);

                RefreshListContent();

                SuccessLabelSuccess();
            }
            else
            {
                SuccessLabelError();
            }
        }

        private void EditCocktailButton_Click(object sender, EventArgs e)
        {
            string name = Format.CapitalizeEvery(NameTextBox.Text);
            string id = CocktailsListBox.SelectedValue.ToString();

            if (CocktailsListBox.SelectedItems.Count == 0)
            {
                SuccessLabelNoSelection();
            }
            else if (DataAccess.Cocktails.Where(c => c.Id.ToString() != id).Select(c => c.Name).Contains(name) && DialogResult.No == 
                MessageBox.Show("This will overwrite an existing cocktail with that name.\r\n\r\nDo you want to continue?",
                                "Edit cocktail", MessageBoxButtons.YesNo))
            {
                // Checks if another cocktail with that name exists and asks the user if they want to overwrite it.
                return;
            }
            else if (TextBoxValidation())
            {
                DataAccess.AddEditCocktail(
                    id: id,
                    name: name,
                    ingredients: string.Join("|", TagList),
                    fullIngredients: string.Join("|", FullIngredientInfoTextBox.Text
                                                        .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(s => s.Trim())),
                    recipe: RecipeTextBox.Text.Trim(),
                    image: CocktailImage);

                RefreshListContent();

                SuccessLabelSuccess();
            }
            else
            {
                SuccessLabelError();
            }
        }

        private void RemoveCocktailButton_Click(object sender, EventArgs e)
        {
            if (CocktailsListBox.SelectedItems.Count > 0)
            {
                DataAccess.RemoveCocktail(CocktailsListBox.SelectedValue.ToString());

                RefreshListContent();

                SuccessLabelSuccess();
            }
            else
            {
                SuccessLabelNoSelection();
            }
        }

        private void InputFieldsChanged(object sender, EventArgs e)
        {
            /*
             * This method is called whenever any of the input fields are changed.
             * (NameTextBox, IngredientTagsComboBox, FullIngredientInfoTextBox or RecipeTextBox)
             */

            SuccessLabelClear();
        }

        private void RefreshListContent()
        {
            DataAccess.GetCocktails();

            CocktailsListBox.DataSource = DataAccess.Cocktails;

            CocktailsListBox.ClearSelected();
            NameTextBox.Text = "";
            IngredientTagsComboBox.Text = "";
            TagList.Clear();
            FullIngredientInfoTextBox.Text = "";
            RecipeTextBox.Text = "";

            ClearImage();
        }

        private bool TextBoxValidation()
        {
            return NameTextBox.Text.Trim() != ""
                && IngredientTagListBox.Text.Trim() != ""
                && FullIngredientInfoTextBox.Text.Trim() != "";
        }

        private void ClearImage()
        {
            CocktailImage = null;

            UploadedImagePictureBox.Image = UploadedImagePictureBox.InitialImage;

            UploadedFileLabel.Text = "No image uploaded";
        }

        private void SuccessLabelClear()
        {
            SuccessLabel.Text = "";
        }

        private void SuccessLabelSuccess()
        {
            SuccessLabel.Text = "Success!";
        }

        private void SuccessLabelError()
        {
            SuccessLabel.Text = "All required fields must be filled!";
        }

        private void SuccessLabelNoSelection()
        {
            SuccessLabel.Text = "Select a cocktail";
        }

        private void SuccessLabelNotUnique()
        {
            SuccessLabel.Text = "Cocktail already exists";
        }
    }
}
