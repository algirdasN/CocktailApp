using System;
using System.Windows.Forms;

namespace CocktailApp
{
    public partial class Cocktails : Form
    {
        public Cocktails()
        {
            InitializeComponent();

            Data.GetNewCocktailList();

            RefreshListContent();

            CocktailsListBox.SetSelected(0, true);
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

        private void ShowOnlyAvailableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshListContent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchByNameRadioButton.Checked)
            {
                Data.SearchCocktails(SearchBar.Text, "Name");
            }
            else if (SearchByIngredientRadioButton.Checked)
            {
                Data.SearchCocktails(SearchBar.Text, "Ingredients");
            }

            RefreshListContent();
        }

        private void RefreshListContent()
        {

            if (ShowOnlyAvailableCheckBox.Checked)
            {
                CocktailsListBox.DataSource = Data.AvailableCocktails;
            }
            else
            {
                CocktailsListBox.DataSource = Data.Cocktails;
            }

            CocktailsListBox.DisplayMember = "InfoAvailable";
            CocktailsListBox.ValueMember = "Id";
        }

        private void CocktailsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CocktailsListBox.SelectedValue.ToString(), out int id))
            {
                var selectedCocktail = Data.Cocktails.Find(c => c.Id == id);
                CocktailNameLabel.Text = selectedCocktail.Name.ToUpper();
                IngredientsTextBox.Text = selectedCocktail.FullIngredientInfo;
                RecipeTextBox.Text = selectedCocktail.Recipe;

                CocktailImageBox.Image = selectedCocktail.Image == null ? 
                    CocktailImageBox.InitialImage : Format.GetImage(selectedCocktail.Image);
            }
        }
    }
}
