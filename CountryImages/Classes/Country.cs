using System.Drawing;

namespace CountryImages.Classes
{
    public class Country
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public Image Image { get; set; }
        public string ImageFile { get; set; }
        public override string ToString() => Name;
    }
}