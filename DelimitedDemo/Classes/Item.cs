namespace DelimitedDemo.Classes
{
    public class Item
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
        public string Column5 { get; set; }
        public string Column6 { get; set; }
        public string Column7 { get; set; }

        public string Part1 => $"{Column1},{Column2},{Column3}";
        public string Part2 => $"{Column4},{Column5},{Column6}";
        public string Part3 => $"{Column7}";
    }
}