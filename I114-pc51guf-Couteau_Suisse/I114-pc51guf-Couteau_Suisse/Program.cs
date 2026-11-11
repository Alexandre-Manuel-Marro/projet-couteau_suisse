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
            string phraseTransforme;

            do
            {
                user = Console.ReadLine();
                phraseTransforme = TransformerMorse(user.ToUpper());
                Console.WriteLine($"{phraseTransforme}");
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
                        break;
                }

                phrase += " ";
            }

            return phrase;
        }
    }
}
