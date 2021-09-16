namespace ListBoxDisableApp
{
    public class ListItem
    {
        public bool Disable { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}