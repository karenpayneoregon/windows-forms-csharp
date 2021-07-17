namespace MediaFileDemo.Classes
{
    public class FileOperations
    {
        /// <summary>
        /// For a real app this would no be hard coded
        /// </summary>
        public static string MediaFileName => "Mediasongs.txt";
        /// <summary>
        /// For a real app we save to <see cref="MediaFileName"/> but this helps
        /// to ensure code is working correctly
        /// </summary>
        public static string SaveFileName => "MediasongsTest.txt";
    }
}