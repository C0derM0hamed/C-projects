using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1,2,3);
            point p2 = new point(4, 5, 6);
            p1.DispalyPoint();
            Console.WriteLine(point.CalculateDistatice(p1,p2));
        }
    }
}
