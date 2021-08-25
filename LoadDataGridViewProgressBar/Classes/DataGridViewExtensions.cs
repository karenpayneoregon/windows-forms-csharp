using System.Windows.Forms;

namespace LoadDataGridViewProgressBar.Classes
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumns(this DataGridView sender, bool sizable = false)
        {
            foreach (DataGridViewColumn col in sender.Columns)
            {
                // ensure we are not attempting to do this on a Entity
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
