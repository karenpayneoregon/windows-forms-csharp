namespace PictureBoxSqlServer.Classes
{
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        /// <summary>
        /// Provides a default property for a ListBox DisplayMember
        /// </summary>
        /// <returns></returns>
        public override string ToString() => CategoryName;

    }
}