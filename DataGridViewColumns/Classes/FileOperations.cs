using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DataGridViewColumns.Classes
{
    public class FileOperations
    {
        public static readonly string ConfigurationFileName = "Configuration.json";
        public static readonly string DataItemsFileName = "DataItems.json";

        /// <summary>
        /// Create file if not exists for list of <see cref="ConfigurationItem"/>
        /// </summary>
        public static void WriteConfigurationItems()
        {
            if (File.Exists(ConfigurationFileName)) return;
            
            var list = new List<ConfigurationItem>
            {
                new ConfigurationItem() { Id = 1, Name = "First" },
                new ConfigurationItem() { Id = 2, Name = "Second" }
            };

            File.WriteAllText(ConfigurationFileName, 
                JsonConvert.SerializeObject(list, Formatting.Indented));
        }
        /// <summary>
        /// Create file if not exists for list of <see cref="DataMapColumn"/>
        /// </summary>
        public static void WriteDataItems()
        {

            if (File.Exists(DataItemsFileName)) return;

            var list = new List<DataMapColumn>
            {
                new DataMapColumn() { ConfigurationId = 1, Name = "A1", DisplayName = "DateDate" },
                new DataMapColumn() { ConfigurationId = 2, Name = "A40", DisplayName = "Prod" },
                new DataMapColumn() { ConfigurationId = 1, Name = "A4", DisplayName = "Item" },
                new DataMapColumn() { ConfigurationId = 1, Name = "A10", DisplayName = "Site" }
            };

            File.WriteAllText(DataItemsFileName, 
                JsonConvert.SerializeObject(list, Formatting.Indented));
        }

        public static List<DataMapColumn> Columns 
            => JsonConvert.DeserializeObject<List<DataMapColumn>>(
                File.ReadAllText(DataItemsFileName));

        public static List<ConfigurationItem> Configurations
            => JsonConvert.DeserializeObject<List<ConfigurationItem>>(
                File.ReadAllText(ConfigurationFileName));
    }
}