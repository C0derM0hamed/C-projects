using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oob1
{
    internal class point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void DispalyPoint()
        {
            Console.Write($"x : {x},y : {y}, z : {z} ");
        }
        public static int CalculateDistatice(point p1,point p2)
        {
            return Math.Abs(p1.x - p2.x);
        } 
    }
}
