namespace MasterDetail
{
    public class Division
    {
        public Division(string name)
        {
            Name = name;
            Teams = new TeamList();
        }

        public string Name { get; }
        public TeamList Teams { get; }

        public override string ToString() => Name;
    }
}