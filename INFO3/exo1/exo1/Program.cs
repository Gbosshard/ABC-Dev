using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, moy;
            Console.Write("indiquez a : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("indiquez b : ");
            b = float.Parse(Console.ReadLine());
            moy = (a+b)/2;

            Console.WriteLine("la moyenne de a et b vaut : {0}", moy);
            Console.ReadKey();
        }
    }
}
