using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxExtensions.Classes
{
    public class MediaItem
    {
        public string FileName { get; set; }
        public override string ToString() => File.Exists(FileName) ? Path.GetFileName(FileName) : "";
    }
}
