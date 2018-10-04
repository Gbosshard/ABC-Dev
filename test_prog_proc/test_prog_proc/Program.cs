// Q2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_prog_proc
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabLogins = new string[3,2];
            string login;
            string motDePasse;
            int i;
            bool motDePasseEstValide = false;
            
            tabLogins[0,0] = "user";
            tabLogins[0,1] = "";
            tabLogins[1,0] = "adelon";
            tabLogins[1,1] = "leclandessiciliens";
            tabLogins[2,0] = "jbelmondo";
            tabLogins[2,1] = "leprofessionnel";
            
            Console.WriteLine("Entrez votre login svp :");
            login = Console.ReadLine();
            Console.WriteLine("Entrez votre mot de passe svp :");
            motDePasse = Console.ReadLine();

            for(i=0; i<3; i++)
            {
                if ((tabLogins[i,0] == login)&&(tabLogins[i,1] == motDePasse)) {
                    motDePasseEstValide = true;
                }
            }
            if(motDePasseEstValide)
            {
                Console.WriteLine("La connexion est réussie");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }
            Console.ReadKey();
        }
    }
}
