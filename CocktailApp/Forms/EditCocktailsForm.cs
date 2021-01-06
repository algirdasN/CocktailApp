﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CocktailApp
{
    public partial class EditCocktailsForm : Form
    {
        private BindingList<string> TagList = new BindingList<string>();

        private byte[] CocktailImage;

        public EditCocktailsForm()
        {
            InitializeComponent();

            Data.GetIngredients();

            RefreshListContent();

            IngredientTagsComboBox.Items.AddRange(Data.Ingredients.Select(i => i.Type).Distinct().ToArray());

            IngredientTagListBox.DataSource = TagList;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            mainMenu.Location = Location;
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditCocktails_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Closes the application if secondary form is closed by any means other than pressing the buttons on form.
             * Otherwise the application process would continue to run.
             */

            if (!((sender as Form).ActiveControl is Button))
            {
                Application.Exit();
            }
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
            Data.SearchCocktails(SearchBar.Text, SearchByNameRadioButton.Checked ? "Name" : "Ingredients");

            CocktailsListBox.DataSource = Data.Cocktails;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "CSV files | *.csv*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.ImportCocktails(dialog.FileName);

                RefreshListContent();
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Data.ExportCocktails(dialog.SelectedPath);
            }
        }

        private void CocktailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CocktailsListBox.SelectedItems.Count > 0)
            {
                Cocktail selectedCocktail = Data.Cocktails.FirstOrDefault(c => c.Id == CocktailsListBox.SelectedValue.ToString());

                if (selectedCocktail != null)
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

            if (Data.Cocktails.Select(c => c.Name).Contains(name))
            {
                SuccessLabelNotUnique();
            }
            else if (TextBoxValidation())
            {
                Data.AddEditCocktail(
                    mode: "Add",
                    id: "0",
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
            if (CocktailsListBox.SelectedItems.Count == 0)
            {
                SuccessLabelNoSelection();
            }
            else if (TextBoxValidation())
            {
                Data.AddEditCocktail(
                    mode: "Edit",
                    id: CocktailsListBox.SelectedValue.ToString(),
                    name: Format.CapitalizeEvery(NameTextBox.Text),
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
                Data.RemoveCocktail(CocktailsListBox.SelectedValue.ToString());

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
            Data.GetCocktails();

            CocktailsListBox.DataSource = Data.Cocktails;
            
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
                && FullIngredientInfoTextBox.Text.Trim() != ""
                && RecipeTextBox.Text.Trim() != "";
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
            SuccessLabel.Text = "All fields must be filled!";
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
