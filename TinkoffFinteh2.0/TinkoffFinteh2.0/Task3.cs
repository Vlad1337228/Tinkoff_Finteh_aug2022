using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffFinteh2._0
{
    public class Task3
    {
        public static void SearchSum()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            List<int> array = s.Split(' ').Select(x => int.Parse(x)).ToList();


            int difference = 0;
            int positionPositive = -1;
            int positionNegative = -1;
            for (int i = 1; i < n; i += 2)
            {
                if (array[i] - array[i - 1] > difference)
                {
                    difference = array[i] - array[i - 1];
                    positionNegative = i;
                    positionPositive = i - 1;
                }
                if (i + 1 < n)
                {
                    if (array[i] - array[i + 1] > difference)
                    {
                        difference = array[i] - array[i + 1];
                        positionNegative = i;
                        positionPositive = i + 1;
                    }
                }
            }
            if (positionPositive != -1 && positionNegative != -1)
            {
                int prom = array[positionPositive];
                array[positionPositive] = array[positionNegative];
                array[positionNegative] = prom;
            }


            int resultSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    resultSum += array[i];
                else
                    resultSum -= array[i];
            }

            Console.WriteLine(resultSum);
        }
    }
}
