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
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void CocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new CocktailsForm { Tag = this };
            form.Show();
            form.Location = Location;
            Hide();
        }

        private void EditCocktailsButton_Click(object sender, EventArgs e)
        {
            var form = new EditCocktailsForm { Tag = this };
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