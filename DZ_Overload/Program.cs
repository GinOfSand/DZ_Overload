using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(4, 3, 0);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine(f);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
        }
    }
}
