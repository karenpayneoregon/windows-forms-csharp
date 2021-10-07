namespace MasterDetail
{
    public class Team
    {
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString() => Name;
    }
}