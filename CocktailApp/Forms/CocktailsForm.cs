﻿using CocktailApp.Properties;
using System;
using System.Drawing;
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

            Data.GetIngredients();

            Data.GetCocktails();

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
            Data.SearchCocktails(SearchBar.Text, SearchByNameRadioButton.Checked ? "Name" : "Ingredients");

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
                Cocktail selectedCocktail = Data.Cocktails.First(c => c.Id == CocktailsListBox.SelectedValue.ToString());

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

                Data.FavouriteCocktail(select.ToString(), Favourite);

                SearchButton_Click(sender, e);

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
            var dialog = new FolderBrowserDialog() { SelectedPath = ScreenCapturePath };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ScreenCapturePath = dialog.SelectedPath;

                var filename = dialog.SelectedPath + "\\" + Format.SanitizeName(CocktailNameLabel.Text) + ".png";

                CaptureInfoPanel().Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void RefreshListContent()
        {
            var cocktails = AvailableCheckBox.Checked ? Data.AvailableCocktails : Data.Cocktails;

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
    }
}
