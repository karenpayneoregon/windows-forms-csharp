using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace MoviesCodeSample
{
    /// <summary>
    /// Movie operations which requires Json.Net NuGet package
    /// or if using .NET Core 5 or higher use System.Text.Json
    /// </summary>
    public class MovieOperations
    {
        /*
         * Mocked up for demonstration, these two properties
         * can be stored under application settings or a json file
         * obtaining your settings rather than done via project properties.
         */
        public static string FolderName = "C:\\Users\\paynek\\Documents\\Snagit\\SmallImages";
        public static string FileName = Path.Combine(FolderName,"Movies.json");

        /// <summary>
        /// Mockup for demonstration purposes, you would create your own
        /// list, perhaps creating a utility that reads images, allows you
        /// to add descriptions for each movie save back to disk
        /// </summary>
        public static List<Movie> Movies => new List<Movie>()
        {
            new Movie() { Title = "Movie 1", ImageName = "checkmark.png" },
            new Movie() { Title = "Movie 2", ImageName = "Mail_16x.png" },
            new Movie() { Title = "Movie 3", ImageName = "upGreenArrow.png" }
        };

        public static void CreateInitialMoviesJsonFile()
        {
            File.WriteAllText(
                FileName, 
                JsonConvert.SerializeObject(Movies, Formatting.Indented));
        }

        /// <summary>
        /// Read movies from json file, in this case for
        /// demonstration a mocked up json file is created if not exists
        /// which in this case it does not.
        /// </summary>
        /// <returns>movies in json file</returns>
        public static List<Movie> GetMovies()
        {

            if (!File.Exists(FileName))
            {
                CreateInitialMoviesJsonFile();
            }

            return JsonConvert.DeserializeObject<List<Movie>>(
                File.ReadAllText(FileName));

        }

        /// <summary>
        /// Get current movie triggered from selection changed in the ComboBox
        /// on the calling form.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Image GetMovieImage(string name) 
            => Image.FromFile(Path.Combine(FolderName, name));

    }
}