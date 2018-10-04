using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, nb;
            bool test;

            do
            {
                Console.WriteLine("valeur de l'entier N ?");
                test = int.TryParse(Console.ReadLine(), out N);
            } while (!test);

            for (nb = 1; nb <= N; nb++)
            {
                if ((N % nb) == 0)
                {
                    Console.WriteLine("{0} est un diviseur de {1}", nb, N);
                }
            }
            Console.ReadKey();
        }
    }
}
