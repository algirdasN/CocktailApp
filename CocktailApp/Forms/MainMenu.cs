using System;
using System.Windows.Forms;

namespace CocktailApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void IngredientsButton_Click(object sender, EventArgs e)
        {
            var form = new Ingredients { Tag = this };
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void CocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new Cocktails { Tag = this };
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void EditCocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new EditCocktails { Tag = this };
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
