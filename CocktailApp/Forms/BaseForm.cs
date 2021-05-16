using System;
using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainForm)Tag;
            mainMenu.Show();
            mainMenu.Location = Location;
            Close();
        }

        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void FormClose(object sender, FormClosingEventArgs e)
        {
            /*
             * Closes the application if secondary form is closed by any means other than pressing the buttons on form.
             * Otherwise the application process would continue to run.
             */

            if ((sender as Form).ActiveControl != BackButton)
            {
                Application.Exit();
            }
        }
    }
}