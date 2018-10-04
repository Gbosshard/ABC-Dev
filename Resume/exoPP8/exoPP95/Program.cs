using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP95
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;

            Console.WriteLine("équation : a*x+b = 0");
            Console.WriteLine("valeur de a ?");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("valeur de b ?");
            b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("l'équation est indéterminée");
                }
                else
                {
                    Console.WriteLine("l'équation est impossible");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("x = "+x);
            }

            Console.ReadKey();
        }
    }
}
