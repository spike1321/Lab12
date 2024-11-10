using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Circle
    {
        static public double GetSquare(double r)
        {
           
            return Math.PI * Math.Pow(r, 2);
        }
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public bool GetAffiliation(double r, double x0, double y0, double x, double y)
        {
            return Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y)) <= r;
        }
    }
}
