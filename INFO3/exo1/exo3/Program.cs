using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, aire;
            Console.WriteLine("Longueurs des cotés du triangle :");
            Console.WriteLine("indiquez a :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("indiquez b :");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("indiquez c :");
            c = double.Parse(Console.ReadLine());

            p = a + b + c;
            aire = Math.Sqrt(p / 2 * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Périmètre du triangle : {0:#.00}", p);
            Console.WriteLine("Aire du triangle : {0:#.00}", aire);
            Console.ReadKey();
        }
    }
}
