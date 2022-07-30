using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailApp.Tools
{
    public static class MsgBox
    {
        public static void ShowAsync(string text, string caption)
        {
             Task.Run(() => MessageBox.Show(text, caption));
        }
    }
}