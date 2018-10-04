using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. et 2.
            int a, b, c, d;

            Console.WriteLine("valeur de a ?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("valeur de b ?");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("valeur de c ?");
            c = int.Parse(Console.ReadLine());

            if (a > b) 
            {
                d = a;
                a = b;
                b = d;
            }
            if (a > c)
            {
                d = a;
                a = c;
                c = d;
            }
            if (b > c)
            {
                d = b;
                b = c;
                c = d;
            }
            Console.WriteLine("en ordre croissant : "+a+", "+b+", "+c);
            Console.ReadKey();
        }
    }
}
