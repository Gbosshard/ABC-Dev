using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, n, S;
            double Sfinal1, Sfinal2;

            Console.WriteLine("indiquez le taux d'intérêt i (en %):");
            i = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("indiquez le nombre d'année de placement n :");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("indiquez la somme d'agent placée S :");
            S = double.Parse(Console.ReadLine());

            Sfinal1 = S * (1 + n * i);
            Sfinal2 = S * Math.Pow((1 + i), n);

            Console.WriteLine("intérêt simple  S(1+n*i) = " + Sfinal1);
            Console.WriteLine("intérêt composé S(1+i)^n = " + Sfinal2);
            Console.ReadKey();
        }
    }
}
