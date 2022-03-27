using System.Collections.Generic;

namespace RemoveFromSecondList.Classes
{
    public class DataItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;

        protected bool Equals(DataItem other)
        {
            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DataItem)obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public static bool operator ==(DataItem left, DataItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DataItem left, DataItem right)
        {
            return !Equals(left, right);
        }


    }

    public class Mocked
    {
        public static List<DataItem> List() =>
            new List<DataItem>
            {
                new DataItem() { Id = 1, Name = "A" },
                new DataItem() { Id = 2, Name = "B" },
                new DataItem() { Id = 3, Name = "C"},
                new DataItem() { Id = 4, Name = "D"},
                new DataItem() { Id = 5, Name = "E"}
            };
    }
}
