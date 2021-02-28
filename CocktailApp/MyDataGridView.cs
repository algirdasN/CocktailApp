using System.Windows.Forms;

namespace CocktailApp
{
    public class MyDataGridView : DataGridView
    {
        public string SelectedId;

        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            // Removes the highlighting of the first row when column header is clicked.
            if (e.RowIndex == -1)
            {
                return;
            }

            base.OnCellMouseDown(e);
        }

        protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            // Stores the selected item ID in order to select it after sorting.
            SelectedId = this.SelectedCells.Count > 0 ? this.SelectedCells[0].Value.ToString() : "";

            base.OnColumnHeaderMouseClick(e);
        }
    }
}
