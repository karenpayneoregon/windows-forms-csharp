namespace SelectRandomFile.Classes
{
    public class FileItem
    {
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public bool Selected { get; set; }
        public override string ToString() => FileName;
    }
}