namespace LoadDataGridViewProgressBar.Classes
{
    public static class StringExtensions
    {
        public static string TrimLastCharacter(this string str) 
            => string.IsNullOrEmpty(str) ? str : str.TrimEnd(str[str.Length - 1]);
    }
}