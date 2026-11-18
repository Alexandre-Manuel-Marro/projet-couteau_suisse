using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I114_pc51guf_Couteau_Suisse
{
    internal class Program
    {
        /////////////////Déclaration variables
        

        static void Main(string[] args)
        {
            string user;
            string choix;
            string phraseTransforme;

            do
            {
                Console.WriteLine("==========Couteau_Suisse==========");
                Console.WriteLine("1. Transformer une phrase en morse.");
                Console.WriteLine("2. Transformer un chiffre d'une base à une autre.");
                Console.WriteLine("3. W.I.P");
                Console.Write("Votre choix: ");

                choix = TryToParse(Console.ReadLine());

                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Veuillez écrire une phrase pour la transformer en morse. Tout caractère qui n'est pas un nombre ou une lettre sans accents (ou autres truc spécial, ex: ç) deviendra un '?'");
                        user = Console.ReadLine();
                        phraseTransforme = TransformerMorse(user.ToUpper());
                        Console.WriteLine($"{phraseTransforme}");
                        break;
                    case "2":
                        Console.WriteLine("==========Choix des bases==========");
                        Console.WriteLine("1. Décimal à Binaire.");
                        Console.WriteLine("2. Décimal à Octal.");
                        Console.WriteLine("3. Octal à Binaire.");
                        Console.WriteLine("4. Octal à Décimal.");
                        Console.WriteLine("5. Binaire à Octal.");
                        Console.WriteLine("6. Binaire à Décimal.");
                        Console.Write("Votre choix: ");
                        break;
                    case "3":
                        Console.WriteLine("Fonction pas encore ajouté, veuillez réessayer");
                        break;
                    default:
                        Console.WriteLine("Valeur invalide, veuillez réessayer");
                        break;
                }

            } while (true);
        }

        static string TransformerMorse(string valueUser)
        {
            string phrase = "";

            foreach (char letter in valueUser)
            {
                switch (letter)
                {
                    case 'A':
                        phrase += ".-";
                        break;
                    case 'B':
                        phrase += "-...";
                        break;
                    case 'C':
                        phrase += "-.-.";
                        break;
                    case 'D':
                        phrase += "-..";
                        break;
                    case 'E':
                        phrase += ".";
                        break;
                    case 'F':
                        phrase += "..-.";
                        break;
                    case 'G':
                        phrase += "--.";
                        break;
                    case 'H':
                        phrase += "....";
                        break;
                    case 'I':
                        phrase += "..";
                        break;
                    case 'J':
                        phrase += ".---";
                        break;
                    case 'K':
                        phrase += "-.-";
                        break;
                    case 'L':
                        phrase += ".-..";
                        break;
                    case 'M':
                        phrase += "--";
                        break;
                    case 'N':
                        phrase += "-.";
                        break;
                    case 'O':
                        phrase += "---";
                        break;
                    case 'P':
                        phrase += ".--.";
                        break;
                    case 'Q':
                        phrase += "--.-";
                        break;
                    case 'R':
                        phrase += ".-.";
                        break;
                    case 'S':
                        phrase += "...";
                        break;
                    case 'T':
                        phrase += "-";
                        break;
                    case 'U':
                        phrase += "..-";
                        break;
                    case 'V':
                        phrase += "...-";
                        break;
                    case 'W':
                        phrase += ".--";
                        break;
                    case 'X':
                        phrase += "-..-";
                        break;
                    case 'Y':
                        phrase += "-.--";
                        break;
                    case 'Z':
                        phrase += "--..";
                        break;
                    case '0':
                        phrase += "-----";
                        break;
                    case '1':
                        phrase += ".----";
                        break;
                    case '2':
                        phrase += "..---";
                        break;
                    case '3':
                        phrase += "...--";
                        break;
                    case '4':
                        phrase += "....-";
                        break;
                    case '5':
                        phrase += ".....";
                        break;
                    case '6':
                        phrase += "-....";
                        break;
                    case '7':
                        phrase += "--...";
                        break;
                    case '8':
                        phrase += "---..";
                        break;
                    case '9':
                        phrase += "----.";
                        break;
                    case ' ':
                        phrase += "/";
                        break;
                    default:
                        phrase += "?";
                        break;
                }

                phrase += " ";
            }

            if (phrase == "")
            {
                phrase = "Valeur invalide, veuillez réessayer.";
            }

            return phrase;
        }

        public static string TryToParse(string user)
        {
            int nombre;      //Variable entière pour comparer à la valeur donné par l'utilisateur

            //Essaye de déplacer la valeur donnée par l'utilisateur dans un entier
            bool nbr = Int32.TryParse(user, out nombre);

            //Si la valeur donné par l'utilisateur n'est pas un entier la valeur est mise à -1 pour qu'il n'y aie pas de message d'erreur
            if (!nbr)
            {
                user = "-1";
            }

            //Retourne la valeur
            return user;
        }
    }
}
