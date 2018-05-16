using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurATrouver = new Random().Next(0, 100);
            int nombreDeCoups = 0;
            Console.WriteLine("Veuillez saisir un nombre compris entre 0 et 100 (exclu)");
            while(true)
            {
                string saisie = Console.ReadLine();
                int valeurSaisie;
                if (!int.TryParse(saisie, out valeurSaisie))
                {
                    Console.WriteLine("la valeur saisie est incorrecte, veuillez recommencer ...");
                    continue;
                }
                if (valeurSaisie < 0 || valeurSaisie >= 100)
                {
                    Console.WriteLine("Vous devez saisir un nombre entre 0 et 100 exclu ...");
                    continue;
                }
                nombreDeCoups++;
                if (valeurSaisie == valeurATrouver)
                    break;
                if (valeurSaisie < valeurATrouver)
                    Console.WriteLine("Trop petit...");
                else
                    Console.WriteLine("Trop Grand");

            }
            if (nombreDeCoups == 1)
                Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coup");
            else
                Console.WriteLine("Vous avez trouvé en " + nombreDeCoups + " coups");
        }
    }
}
