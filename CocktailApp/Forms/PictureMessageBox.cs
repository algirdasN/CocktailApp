using System.Windows.Forms;

namespace CocktailApp.Forms
{
    public partial class PictureMessageBox : Form
    {
        public PictureMessageBox(byte[] cocktailImage)
        {
            InitializeComponent();

            if (cocktailImage != null)
            {
                pictureBox1.Image = Format.GetImage(cocktailImage);
            }
        }
    }
}
