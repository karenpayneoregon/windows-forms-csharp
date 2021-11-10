using System;

namespace TextBoxExperiments.Extensions
{
    public static class StringExtensions
    {
        public static int IndexOfBreak(this string str, out int length)
        {
            return IndexOfBreak(str, 0, out length);
        }

        public static int IndexOfBreak(this string source, int startIndex, out int length)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                length = 0;
                return -1;
            }
            
            int ub = source.Length - 1;
            int intchr;

            if (startIndex > ub)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = startIndex; i <= ub; i++)
            {
                intchr = source[i];

                if (intchr == 0x0D)
                {
                    if (i < ub && source[i + 1] == 0x0A)
                    {
                        length = 2;
                    }
                    else
                    {
                        length = 1;
                    }
                    return i;
                }
                else if (intchr == 0x0A)
                {
                    length = 1;
                    return i;
                }
            }

            length = 0;
            return -1;
        }
    }
}