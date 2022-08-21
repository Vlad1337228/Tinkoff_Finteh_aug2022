using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinkoffFinteh2._0
{
    public class Task1
    {
        public static void Search(int x1, int y1, int x2, int y2, int xx1, int yy1, int xx2, int yy2)
        {
            int square = 0;

            int resMaxY = 0;
            int resMaxX = 0;
            int resMinY = 0;
            int resMinX = 0;

            if (y2 > yy2)
                resMaxY = y2;
            else
                resMaxY = yy2;

            if (x2 > xx2)
                resMaxX = x2;
            else
                resMaxX = xx2;

            if (y1 < yy1)
                resMinY = y1;
            else
                resMinY = yy1;

            if (x1 < xx1)
                resMinX = x1;
            else
                resMinX = xx1;

            if (resMaxX - resMinX > resMaxY - resMinY)
                square = (resMaxX - resMinX) * (resMaxX - resMinX);
            else
                square = (resMaxY - resMinY) * (resMaxY - resMinY);

            Console.WriteLine(square);
        }
    }
}
