using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxProducts.Classes
{
    static class CheckedListBoxExtensions
    {
        public static List<string> SelectedColumnNames(this CheckedListBox sender) 
            => sender.Items.Cast<string>()
                .Where((item, index) => sender.GetItemChecked(index)).Select(item => item)
                .ToList();

        /// <summary>
        /// Move a selected item up or down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pDirectionUp">
        /// true to move up, false to move down (default is move up)
        /// </param>
        public static void MoveItem(this CheckedListBox sender, bool pDirectionUp = true)
        {
            if (sender.SelectedItem == null)
            {
                return;
            }

            sender.BeginUpdate();

            try
            {

                var selectedIndex = sender.SelectedIndex;
                var selectedItem = sender.SelectedItem;
                var checkedState = sender.GetItemChecked(selectedIndex);

                sender.Items.RemoveAt(selectedIndex);

                var newIndex = selectedIndex;
                if (pDirectionUp)
                {
                    newIndex -= 1;
                }
                else
                {
                    newIndex += 1;
                }

                if (newIndex > sender.Items.Count - 1 | newIndex < 0)
                {
                    newIndex = sender.Items.Count;
                }


                sender.Items.Insert(newIndex, selectedItem);
                sender.SetItemChecked(newIndex, checkedState);

                sender.SelectedIndex = newIndex;
            }
            finally
            {
                sender.EndUpdate();
            }
        }
    }
}
