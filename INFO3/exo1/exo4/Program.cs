using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, a, aire;
            Console.WriteLine("Longueurs des cotés du triangle :");
            Console.WriteLine("indiquez le rayon R :");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("indiquez l'angle a en degré(s):");
            a = double.Parse(Console.ReadLine());

            aire = Math.PI*R*R*a/360.0;

            Console.WriteLine("Aire du secteur circulaire : " + aire);
            Console.ReadKey();
        }
    }
}
