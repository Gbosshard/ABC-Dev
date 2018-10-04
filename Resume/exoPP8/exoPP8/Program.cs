using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("valeur de a ?");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("valeur de b ?");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("valeur de c ?");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("b>8 ou c<1 a la valeur " + ((b > 8) || (c < 1)));
            Console.WriteLine("b>0 ou c>1 a la valeur " + ((b > 0) || (c > 1)));
            Console.WriteLine("b>9 ou c>1 a la valeur " + ((b > 9) || (c > 1)));
            Console.WriteLine("b>a et c>b a la valeur " + ((b > a) && (c > b)));
            Console.WriteLine("b>a et c<0 a la valeur " + ((b > a) && (c < 0)));
            Console.WriteLine("non(c<a) a la valeur " + (!(c < a)));
            Console.WriteLine("non(b>a et c>b) a la valeur " + !((b > a) && (c > b)));
            Console.WriteLine("(b>a et c>b) ou (a<0) a la valeur " + (((b > a) && (c > b)) || (a < 0)));
            Console.ReadKey();
        }
    }
}
