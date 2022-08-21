using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffFinteh2._0
{
    public class Task5
    {
        public static void FileConfig()
        {


            var s = (Console.ReadLine()).Split(' ');
            int countPerson = int.Parse(s[0]);
            int countRequest = int.Parse(s[1]);
            int[] resultArray = new int[countRequest];

            var arrayPerson = new List<string>();
            for (int i = 0; i < countPerson; i++)
            {
                arrayPerson.Add(Console.ReadLine());
            }

            var arrayPrefics = new List<string>();
            for (int i = 0; i < countRequest; i++)
            {
                arrayPrefics.Add(Console.ReadLine());

            }

            for (int i = 0; i < countRequest; i++)
            {
                Console.WriteLine(IndexPref(arrayPerson, int.Parse(arrayPrefics[i].Split(' ')[0]), arrayPrefics[i].Split(' ')[1]));
            }

        }

        public static int IndexPref(List<string> persons, int index, string prefics)
        {
            var list = persons.Where(x => x.StartsWith(prefics)).ToList();
            if (index - 1 < list.Count())
            {
                var str = list[index - 1];
                return persons.IndexOf(str) + 1;

            }
            return -1;
        }
    }

}
