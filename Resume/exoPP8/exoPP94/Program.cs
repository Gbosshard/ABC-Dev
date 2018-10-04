using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP94
{
    class Program
    {
        static void Main(string[] args)
        {
            double reel;
            Console.WriteLine("taper un nombre réel :");
            reel = double.Parse(Console.ReadLine());
            reel = Math.Abs(reel);
            Console.WriteLine("valeur absolue : "+reel);
            Console.ReadKey();
        }
    }
}
