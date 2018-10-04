using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int N, nb,i;
            bool boolprem;
            List<int> prem = new List<int>();

            Console.WriteLine("valeur de l'entier N ?");
            N = int.Parse(Console.ReadLine());

            prem.Add(2);
            while (prem.Last() < N) //fin test
            {
                Console.Write("{0} ", prem.Last());
                boolprem = false;
                nb = prem.Last();
                do // recherche prochain nb premier
                {
                    nb++;
                    i = 0;
                    while ((i < prem.Count()) && ((nb % prem[i]) != 0)) // i++ pour voir si nb est premier
                    {
                        i++;
                    }
                    if (i == prem.Count())
                    {
                        boolprem = true;
                    }
                } while(!boolprem);
                prem.Add(nb);
            }
            Console.WriteLine("...", N);
            if (prem.Last() == N)
            {
                Console.WriteLine("{0} est premier", N);
            }
            else
            {
                Console.WriteLine("{0} n'est pas premier", N);
            }*/
            int N, nb;
            bool test, result = true;

            do
            {
                Console.WriteLine("valeur de l'entier N ?");
                test = int.TryParse(Console.ReadLine(), out N);
            } while (!test);

            for (nb = 2; nb <= Math.Sqrt(N); nb++)
            {
                //Console.WriteLine("reste {0} nb : {1} sqrt : {2}", N % nb, nb, Math.Sqrt(N));
                if ((N % nb) == 0)
                {
                    result = false;
                    break;
                }
            }
            if (result && (N > 1))
            {
                Console.WriteLine("{0} est premier", N);
            }
            else
            {
                Console.WriteLine("{0} n'est pas premier", N);
            }
            Console.ReadKey();
        }
    }
}
