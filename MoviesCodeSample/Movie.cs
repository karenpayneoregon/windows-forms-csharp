namespace MoviesCodeSample
{
    /// <summary>
    /// Represents a single movie, add other
    /// properties if needed before serializing
    /// data in MovieOperations.
    /// </summary>
    public class Movie
    {
        public string Title { get; set; }
        public string ImageName { get; set; }
        /// <summary>
        /// For ComboBox DisplayMember 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Title;
    }
}