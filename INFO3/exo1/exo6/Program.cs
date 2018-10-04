using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("indiquez a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("indiquez b :");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;

            Console.WriteLine("maintenant, a vaut : "+ a +" et b vaut : "+ b);
            Console.ReadKey();
        }
    }
}
