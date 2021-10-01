using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNetCoreCharCount
{
    public class CharacterItem
    {
        public char Letter { get; set; }
        public int Occurrences { get; set; }
        public int Code { get; set; }
        public override string ToString()
        {
            return $"{Letter,-3}{Occurrences,-4}{Code}";
        }
    }

    public class CharacterOperations
    {
        public static List<CharacterItem> CountOccurrences(string sender)
        {
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;

            byte[] utfBytes = utf8.GetBytes(sender);
            byte[] isoBytes = Encoding.Convert(utf8, iso, utfBytes);

            string items = iso.GetString(isoBytes);

            var characterGroup = 
                (
                    items
                        .ToCharArray()
                        .GroupBy(chr => chr)
                        .Select(@group => new CharacterItem
                        {
                            Letter = @group.Key, 
                            Occurrences = @group.Count(), 
                            Code = Convert.ToInt32((int)@group.Key)
                        }))
                .ToList()

                .OrderBy((item) => item.Letter.ToString());

            return (characterGroup.Select(item => item)).ToList();

        }
    }
}
