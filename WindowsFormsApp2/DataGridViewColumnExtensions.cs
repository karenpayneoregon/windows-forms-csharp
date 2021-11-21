using System.Reflection;
using System.Windows.Forms;

namespace DataGridViewGetCellSyle
{
    public static class DataGridViewColumnExtensions
    {
        public static DataGridViewCellStyle GetFormattedStyle(this DataGridViewCell cell)
        {
            var dgv = cell.DataGridView;

            if (dgv == null)
            {
                return cell.InheritedStyle;
            }

            var formattingArgs = new DataGridViewCellFormattingEventArgs(
                cell.ColumnIndex, 
                cell.RowIndex, 
                cell.Value, 
                cell.FormattedValueType, 
                cell.InheritedStyle);

            var methodInfo = dgv.GetType().GetMethod("OnCellFormatting",
                BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                new[] { typeof(DataGridViewCellFormattingEventArgs) },
                null);

            methodInfo.Invoke(dgv, new object[] { formattingArgs });
            return formattingArgs.CellStyle;
        }
    }
}