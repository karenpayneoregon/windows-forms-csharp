using System.Collections.Generic;

namespace SoftDeleteExample
{
    public class DataOperations
    {
        public static bool RemoveRow(int id)
        {
            // place code to set IsDeleted to true row in database, return true if 
            // success, false on failure
            return true;
        }
        public static List<Theater> LoadTheaters() =>
            new List<Theater>
            {
                new Theater() {Id = 1, Movie = "Movie A" },
                new Theater() {Id = 2, Movie = "Movie B" },
                new Theater() {Id = 3, Movie = "Movie C"}
            };
    }
}
