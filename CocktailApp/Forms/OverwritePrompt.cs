using System;
using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public enum TriState { Yes, No, Undefined }

    public partial class OverwritePrompt : Form
    {
        public TriState Overwrite = TriState.Undefined;
        public OverwritePrompt(string cocktail)
        {
            InitializeComponent();

            label1.Text = $"Cocktail '{cocktail}' already exists in the database.\r\n\r\nDo you want to replace it with the one being imported?";
        }

        private void YesToAllButton_Click(object sender, EventArgs e)
        {
            Overwrite = TriState.Yes;
        }

        private void NoToAllButton_Click(object sender, EventArgs e)
        {
            Overwrite = TriState.No;
        }
    }
}
