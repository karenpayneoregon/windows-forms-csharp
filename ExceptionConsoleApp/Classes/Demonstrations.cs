using System;
using System.IO;
using ExceptionsLibrary.LanguageExtensions;

namespace ExceptionConsoleApp.Classes
{
    class Demonstrations
    {
        public static string Example1() 
            => TopException(out _).GetExceptionMessages($"{nameof(Demonstrations)}.{nameof(Example1)}\n");

        public static string Example2() 
            => TopException(out _).GetExceptionMessagesLineFeeds($"{nameof(Demonstrations)}.{nameof(Example1)}\n");

        public static string Example3() 
            => new FormatException("Format issue").GetExceptionMessages();

        public static string Example4()
        {
            try
            {
                throw new OverflowException("Overflow issue");
            }
            catch (Exception ex) when (ex is FormatException or OverflowException)
            {
                return ex.GetExceptionMessages();
            }
            catch 
            {
                return string.Empty;
            }
        }

        private static Exception TopException(out FileNotFoundException innerException)
        {
            innerException = new FileNotFoundException("SomeFile.txt ",
                new Exception("Inside File not found"));

            var topException = new Exception("Level 1",
                new Exception("Bogus",
                    innerException));
            
            return topException;
        }
    }
}

