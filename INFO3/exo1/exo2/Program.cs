using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, aire, volume;
            Console.WriteLine("indiquez R le rayon de la sphère :");
            R = double.Parse(Console.ReadLine());

            aire = 4 * Math.PI * R * R;
            volume = 4.0 / 3 * Math.PI * Math.Pow(R,3);

            Console.WriteLine("la sphère de rayon {0:##,###.00} a une aire de {1:##,###.00} et un volume de {2:##,###.00}", R, aire, volume);
            Console.ReadKey();
        }
    }
}
