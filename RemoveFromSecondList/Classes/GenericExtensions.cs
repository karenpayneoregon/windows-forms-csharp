using System.Collections.Generic;

namespace RemoveFromSecondList.Classes
{
    public static class GenericExtensions
    {
        public static void RemoveAllSpecial<T>(this IList<T> iList, IEnumerable<T> itemsToRemove)
        {
            var set = new HashSet<T>(itemsToRemove);

            var list = iList as List<T>;
            if (list == null)
            {
                int index = 0;
                while (index < iList.Count)
                {
                    if (set.Contains(iList[index]))
                    {
                        iList.RemoveAt(index);
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            else
            {
                list.RemoveAll(set.Contains);
            }
        }
    }
}
