using System;
using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void IngredientsButton_Click(object sender, EventArgs e)
        {
            var form = new IngredientsForm { Tag = this };
            form.Location = Location;
            form.Show();
            Hide();
        }

        private void CocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new CocktailsForm { Tag = this };
            form.Location = Location;
            form.Show();
            Hide();
        }

        private void EditCocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new EditCocktailsForm { Tag = this };
            form.Location = Location;
            form.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}