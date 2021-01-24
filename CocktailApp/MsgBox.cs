using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocktailApp
{
    public static class MsgBox
    {
        public static async void ShowAsync(string text, string caption)
        {
            await Task.Run(() => MessageBox.Show(text, caption));
        }
    }
}
