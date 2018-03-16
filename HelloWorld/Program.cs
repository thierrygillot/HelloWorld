using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exo Parse
            //string nbr1Input = "Enter a number";
            //string nbr2nput = "Enter a second number";


            //Console.WriteLine(nbr1Input);
            //int nbr1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(nbr2nput);
            //int nbr = int.Parse(Console.ReadLine());
            //int result = nbr1 + nbr;
            //Console.WriteLine("Sum is: " + result.ToString());
            #endregion

            #region exo TryParse
            //string nbr1Input = "Enter a number: ";
            //string nbr2nput = "Enter a second number: ";
            //Console.Write(nbr1Input);
            //int n1;
            //bool nbr1 = int.TryParse(Console.ReadLine(), out n1);
            //Console.Write(nbr2nput);
            //int n2;
            //bool nbr2 = int.TryParse(Console.ReadLine(), out n2);
            //int result = n1 + n2;
            //Console.WriteLine("Sum is: " + result.ToString());
            #endregion

            #region Stringbuilder Test
            //StringBuilder myString = new StringBuilder("This is my StringBuilder");
            //myString.Append(" et voici un append");
            //Console.WriteLine(myString);
            #endregion

            #region test math
            //int a = 2 + 2 * 6;
            //Console.Write(a);
            #endregion

            #region nombrepair et impair

            //int n;
            //Console.Write("Entrez un nombre:");
            //bool x = int.TryParse(Console.ReadLine(),out n);
            //int halfN = n / 2;
            //int result = halfN*2;
            //if (result == n)
            //    Console.WriteLine("Le nombre est pair");
            //else
            //    Console.WriteLine("Le nombre est impair");


            #endregion

            #region Modulo - Exo 3
            //int n;
            //Console.WriteLine("Entrez un chiffre");
            //bool input = int.TryParse(Console.ReadLine(), out n);
            //int divEntier = n / 2;
            //int divModulo = n % 2;
            //float divF = n / 2F;
            //Console.WriteLine("Resultat de la division entière par deux: " + divEntier);
            //Console.WriteLine("Resultat du modulo: " + divModulo);
            //Console.WriteLine("Resultat de la division par deux " + divF);
            #endregion

            #region BBAN
            string compteBBAN = "539-0075470-34";
            string start = compteBBAN.Substring(0, 3);
            string middle = compteBBAN.Substring(4, 7);
            string end = compteBBAN.Substring(compteBBAN.Length - 2, 2);
            long endL = long.Parse(end);
            long compteInt = long.Parse(start + middle);
            if (compteInt % 97 == endL)
            {
                Console.WriteLine("Compte OK");
            }
            else if (compteInt % 97 == 0)
            {
                Console.WriteLine("Deux derniers chiffres sont 97");
            }
            else
            {
                Console.WriteLine("KO");
            }
            







            #endregion

            #region BBAN to IBAN

            #endregion
        }
    }
}
