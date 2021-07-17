using System.IO;

namespace MediaFileDemo.Classes
{
    public class MediaItem
    {
        public string FileName { get; set; }
        public override string ToString() => File.Exists(FileName) ? Path.GetFileName(FileName) : "";
    }
}
