using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffFinteh2._0
{
    public class Task2
    {
        public static void SearchComman()
        {
            int result = 0;
            int n = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                var arrPerson = string.Join(" ", s.Split(' ').OrderBy(x => x).ToArray());
                commands.Add(arrPerson);
            }

            for (int i = 0; i < n; i++)
            {
                int prom = 0;
                for (int j = 0; j < n; j++)
                {
                    if (commands[i] == commands[j])
                        prom++;
                }
                if (result < prom)
                    result = prom;
            }

            Console.WriteLine(result);

        }
    }
}
