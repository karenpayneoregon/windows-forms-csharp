using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListBoxFromFileList.Classes
{
    public static class JsonHelpers
    {
        public static string FileName = "Items.json";

        /// <summary>
        /// Create a mockup if file does not exists
        /// </summary>
        public static void InitializeData()
        {
            if (!File.Exists(FileName))
            {
                File.WriteAllText(JsonHelpers.FileName, JsonConvert.SerializeObject(MockOperations.List, Formatting.Indented));
            }
        }

        /// <summary>
        /// Read items
        /// </summary>
        /// <returns></returns>
        public static List<FileItem> Read() => 
            JsonConvert.DeserializeObject<List<FileItem>>(File.ReadAllText(JsonHelpers.FileName));

        /// <summary>
        /// Save items
        /// </summary>
        /// <param name="list"></param>
        public static void Save(List<FileItem> list) => 
            File.WriteAllText(FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
    }
   
}
