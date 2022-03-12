using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace CountryImages.Classes
{
    public class Operations
    {
        private static readonly string FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Countries.json");

        public static List<Country> GetCountries()
        {
            List<Country> list = JsonConvert.DeserializeObject<List<Country>>(File.ReadAllText(FileName));
            foreach (var country in list)
            {
                country.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", country.ImageFile));
            }

            return list;
        }

        public static void CreateFile()
        {

            List<Country> list = new List<Country>
            {
                new Country() { Name = "Select", Currency = "", ImageFile =  "0.png"},
                new Country() { Name = "China", Currency = "CNY", ImageFile =  "China.png" },
                new Country() { Name = "Russia", Currency = "RUB", ImageFile =  "Russia.png" },
                new Country() { Name = "USA", Currency = "USD", ImageFile =  "USA.png" }
            };

            
            File.WriteAllText(FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
        }

    }
}