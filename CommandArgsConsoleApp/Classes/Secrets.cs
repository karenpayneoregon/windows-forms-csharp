using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandArgsConsoleApp.Classes
{
    /// <summary>
    /// Mocked information that would come from perhaps
    /// a database, encrypted file etc.
    /// </summary>
    public class Secrets
    {
        /// <summary>
        /// User name and password which are their first and last names
        /// keys are case insensitive, in real world we would be case sensitive
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> UsersInformation() =>
            new(StringComparer.InvariantCultureIgnoreCase)
            {
                { "karen", "payne" },
                { "vincent", "buchheitt" },
                { "amelia", "dinh" },
                { "garen", "porter" },
                { "lisa", "smith-burham" },
                { "james", "bennett" },
                { "yelena", "galante" },
                { "francis", "guarnes" },
                { "dino", "guevara" },
                { "bill", "rickman" },
                { "bick", "vu" },
                { "fred", "wenger" }
            };
        }
}
