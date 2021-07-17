using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ListBoxExtensions.Classes
{
    public static class Extensions
    {
        /// <summary>
        /// Load file names into a BindingSource which in turn becomes the DataSource for a ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool LoadFromFile(this BindingSource sender)
        {
            if (File.Exists(FileOperations.MediaFileName))
            {
                var lines = File.ReadAllLines(FileOperations.MediaFileName).Where(x => !string.IsNullOrWhiteSpace(x));
                
                sender.DataSource = (lines.Where(File.Exists).Select(line => new MediaItem() {FileName = line})).ToList();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Save contents of ListBox to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="FileName"></param>
        public static void SaveToFile(this BindingSource sender, string FileName)
        {
            File.WriteAllLines(FileName, (from Row in sender.Cast<MediaItem>() select Row.FileName).ToArray());
        }

    }
}