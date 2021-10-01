using System;
using System.Windows.Forms;

namespace LoadDataGridViewProgressBar.Controls
{
    public class DataGridViewJumper : DataGridView
    {
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (CurrentRow != null)
                {
                    int currentRow = CurrentRow.Index;
                    if (currentRow >= 0 && CurrentCell.ColumnIndex == ColumnCount -1)
                    {
                        CurrentCell = Rows[currentRow].Cells[0];
                    }
                }
            }
            base.OnKeyUp(e);
        }
    }

}
