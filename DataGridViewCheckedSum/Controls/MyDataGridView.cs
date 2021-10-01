using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCheckedSum.Controls
{
    public class MyDataGridView : DataGridView
    {
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (CurrentCell.ColumnIndex == ColumnCount -1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    return ProcessTabKey(e.KeyData);
                }
            }
            

            return base.ProcessDataGridViewKey(e);
        }
    }

}
