using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandArgsConsoleApp.LanguageExtensions;

namespace CommandArgsConsoleApp.Classes
{
    public class Operations
    {
        /// <summary>
        /// Dummy work for the application
        /// </summary>
        /// <param name="options"><see cref="CommandLineOptions"/></param>
        public static void RunWork(CommandLineOptions options)
        {
            var userName = options.Username.Trim();
            var password = options.Password.Trim();

            if (Secrets.UsersInformation().ContainsKey(userName))
            {
                if (Secrets.UsersInformation()[userName] == password)
                {
                    Debug.WriteLine($"Welcome {userName.FirstCharToUpper()} {password.FirstCharToUpper()}");
                }
                else
                {
                    Debug.WriteLine("Access denied");
                }
            }
            else
            {
                Debug.WriteLine("Access denied");
            }
        }
    }
}
