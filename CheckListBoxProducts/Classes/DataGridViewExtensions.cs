using System.Windows.Forms;

namespace CheckListBoxProducts.Classes
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumns(this DataGridView sender, bool sizable = false)
        {
            foreach (DataGridViewColumn col in sender.Columns)
            {
                if (col.ValueType.Name != "ICollection`1")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            if (!sizable) return;

            for (int index = 0; index <= sender.Columns.Count - 1; index++)
            {
                int columnWidth = sender.Columns[index].Width;

                sender.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                sender.Columns[index].Width = columnWidth;
            }


        }
    }
}