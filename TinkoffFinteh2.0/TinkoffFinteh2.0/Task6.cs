using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffFinteh2._0
{
    public static class Task6
    {
        static int countRoad = -1;
        public static void SearchRoad()
        {
            int n = int.Parse(Console.ReadLine());
            List<KeyValueP> keyValuePs = new List<KeyValueP>();
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                var begin = int.Parse(str.Split(' ')[0]);
                var end = int.Parse(str.Split(' ')[1]);
                keyValuePs.Add(new KeyValueP() { Key = begin, Value = end });

            }
            var sortedKeyValuePr = keyValuePs.OrderBy(x => x.Key).ToList();
            for (int i = 0; i < sortedKeyValuePr.Count; i++)
            {
                CountPairs(sortedKeyValuePr, sortedKeyValuePr[0].Key, 0, 0);

            }
            Console.WriteLine(countRoad);
        }

        public static void CountPairs(List<KeyValueP> sortedKeyValuePr, int index, int result, int indexRemove)
        {
            if (sortedKeyValuePr.Any(x => x.Key == index))
            {
                var distList = sortedKeyValuePr.GetRange(indexRemove, sortedKeyValuePr.Count - indexRemove)
                                               .Where(x => x.Key == index)
                                               .OrderBy(x => x.Value)
                                               .ToList();

                if (distList.Count > 0)
                    result += 1;
                for (int i = 0; i < distList.Count; i++)
                {
                    if (distList[i].Value == index)
                        result += 1;
                    indexRemove += 1;
                    CountPairs(sortedKeyValuePr, sortedKeyValuePr[index].Value, result, indexRemove);
                }
            }
            else
            {
                if (countRoad < result)
                {
                    countRoad = result;
                }
            }
        }
    }

}
