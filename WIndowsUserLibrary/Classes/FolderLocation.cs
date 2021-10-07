using System.Configuration;
using System.IO;
using static System.Configuration.ConfigurationManager;

namespace WindowsUserLibrary.Classes
{
    /// <summary>
    /// </summary>
    /// <remarks>
    /// Depending on needs change <see cref="ConfigurationUserLevel"/>
    /// </remarks>
    public class FolderLocation
    {
        public string UserConfigFile() 
            => OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
                .FilePath;


        public string UserConfigurationFileFolder 
            => OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal)
                .FilePath.Replace("\\user.config", "");

        public bool UserConfigurationFileFolderExists 
            => Directory.Exists(UserConfigurationFileFolder);
    }
}
