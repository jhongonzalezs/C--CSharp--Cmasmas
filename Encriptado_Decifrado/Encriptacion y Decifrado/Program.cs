using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptacion_y_Decifrado
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            String Palabra, seguir;
            char nueva;
            seguir = "si";


            while (seguir == "si")
            {
                Console.Clear();
                Console.WriteLine("1. Encriptacion");
                Console.WriteLine("2. Desencriptacion");
                Console.WriteLine("Escoja Una Sola Opcion");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite La Palabra/Texto A Encriptar");
                        Palabra = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" ");
                        foreach (char letra in Palabra)
                        {
                            nueva = letra;
                            switch (letra)
                            {
                                case '.':
                                    nueva = '*';
                                    break;
                                case ',':
                                    nueva = '#';
                                    break;
                                case ' ':
                                    nueva = ' ';
                                    break;
                                case 'a':
                                    nueva = 'D';
                                    break;
                                case 'b':
                                    nueva = 'E';
                                    break;
                                case 'c':
                                    nueva = 'F';
                                    break;
                                case 'd':
                                    nueva = 'G';
                                    break;
                                case 'e':
                                    nueva = 'H';
                                    break;
                                case 'f':
                                    nueva = 'I';
                                    break;
                                case 'g':
                                    nueva = 'J';
                                    break;
                                case 'h':
                                    nueva = 'K';
                                    break;
                                case 'i':
                                    nueva = 'L';
                                    break;
                                case 'j':
                                    nueva = 'M';
                                    break;
                                case 'k':
                                    nueva = 'N';
                                    break;
                                case 'l':
                                    nueva = 'Ñ';
                                    break;
                                case 'm':
                                    nueva = 'O';
                                    break;
                                case 'n':
                                    nueva = 'P';
                                    break;
                                case 'ñ':
                                    nueva = 'Q';
                                    break;
                                case 'o':
                                    nueva = 'R';
                                    break;
                                case 'p':
                                    nueva = 'S';
                                    break;
                                case 'q':
                                    nueva = 'T';
                                    break;
                                case 'r':
                                    nueva = 'U';
                                    break;
                                case 's':
                                    nueva = 'V';
                                    break;
                                case 't':
                                    nueva = 'W';
                                    break;
                                case 'u':
                                    nueva = 'X';
                                    break;
                                case 'v':
                                    nueva = 'Y';
                                    break;
                                case 'w':
                                    nueva = 'Z';
                                    break;
                                case 'x':
                                    nueva = 'A';
                                    break;
                                case 'y':
                                    nueva = 'B';
                                    break;
                                case 'z':
                                    nueva = 'C';
                                    break;


                                case 'A':
                                    nueva = 'D';
                                    break;
                                case 'B':
                                    nueva = 'E';
                                    break;
                                case 'C':
                                    nueva = 'F';
                                    break;
                                case 'D':
                                    nueva = 'G';
                                    break;
                                case 'E':
                                    nueva = 'H';
                                    break;
                                case 'F':
                                    nueva = 'I';
                                    break;
                                case 'G':
                                    nueva = 'J';
                                    break;
                                case 'H':
                                    nueva = 'K';
                                    break;
                                case 'I':
                                    nueva = 'L';
                                    break;
                                case 'J':
                                    nueva = 'M';
                                    break;
                                case 'K':
                                    nueva = 'N';
                                    break;
                                case 'L':
                                    nueva = 'Ñ';
                                    break;
                                case 'M':
                                    nueva = 'O';
                                    break;
                                case 'N':
                                    nueva = 'P';
                                    break;
                                case 'Ñ':
                                    nueva = 'Q';
                                    break;
                                case 'O':
                                    nueva = 'R';
                                    break;
                                case 'P':
                                    nueva = 'S';
                                    break;
                                case 'Q':
                                    nueva = 'T';
                                    break;
                                case 'R':
                                    nueva = 'U';
                                    break;
                                case 'S':
                                    nueva = 'V';
                                    break;
                                case 'T':
                                    nueva = 'W';
                                    break;
                                case 'U':
                                    nueva = 'X';
                                    break;
                                case 'V':
                                    nueva = 'Y';
                                    break;
                                case 'W':
                                    nueva = 'Z';
                                    break;
                                case 'X':
                                    nueva = 'A';
                                    break;
                                case 'Y':
                                    nueva = 'B';
                                    break;
                                case 'Z':
                                    nueva = 'C';
                                    break;
                                default:
                                    Console.WriteLine("Imposible De Encriptar");
                                    break;
                            }
                            Console.Write(nueva);

                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite La Palabra/Texto A Desencriptar");
                        Palabra = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(" ");
                        foreach (char letra in Palabra)
                        {
                            nueva = letra;
                            switch (letra)
                            {
                                case '*':
                                    nueva = '.';
                                    break;
                                case '#':
                                    nueva = ',';
                                    break;
                                case ' ':
                                    nueva = ' ';
                                    break;
                                case 'd':
                                    nueva = 'A';
                                    break;
                                case 'e':
                                    nueva = 'B';
                                    break;
                                case 'f':
                                    nueva = 'C';
                                    break;
                                case 'g':
                                    nueva = 'D';
                                    break;
                                case 'h':
                                    nueva = 'E';
                                    break;
                                case 'i':
                                    nueva = 'F';
                                    break;
                                case 'j':
                                    nueva = 'G';
                                    break;
                                case 'k':
                                    nueva = 'H';
                                    break;
                                case 'l':
                                    nueva = 'I';
                                    break;
                                case 'm':
                                    nueva = 'J';
                                    break;
                                case 'n':
                                    nueva = 'K';
                                    break;
                                case 'ñ':
                                    nueva = 'L';
                                    break;
                                case 'o':
                                    nueva = 'M';
                                    break;
                                case 'p':
                                    nueva = 'N';
                                    break;
                                case 'q':
                                    nueva = 'Ñ';
                                    break;
                                case 'r':
                                    nueva = 'O';
                                    break;
                                case 's':
                                    nueva = 'P';
                                    break;
                                case 't':
                                    nueva = 'Q';
                                    break;
                                case 'u':
                                    nueva = 'R';
                                    break;
                                case 'v':
                                    nueva = 'S';
                                    break;
                                case 'w':
                                    nueva = 'T';
                                    break;
                                case 'x':
                                    nueva = 'U';
                                    break;
                                case 'y':
                                    nueva = 'X';
                                    break;
                                case 'z':
                                    nueva = 'W';
                                    break;
                                case 'a':
                                    nueva = 'X';
                                    break;
                                case 'b':
                                    nueva = 'Y';
                                    break;
                                case 'c':
                                    nueva = 'Z';
                                    break;


                                case 'D':
                                    nueva = 'A';
                                    break;
                                case 'E':
                                    nueva = 'B';
                                    break;
                                case 'F':
                                    nueva = 'C';
                                    break;
                                case 'G':
                                    nueva = 'D';
                                    break;
                                case 'H':
                                    nueva = 'E';
                                    break;
                                case 'I':
                                    nueva = 'F';
                                    break;
                                case 'J':
                                    nueva = 'G';
                                    break;
                                case 'K':
                                    nueva = 'H';
                                    break;
                                case 'L':
                                    nueva = 'I';
                                    break;
                                case 'M':
                                    nueva = 'J';
                                    break;
                                case 'N':
                                    nueva = 'K';
                                    break;
                                case 'Ñ':
                                    nueva = 'L';
                                    break;
                                case 'O':
                                    nueva = 'M';
                                    break;
                                case 'P':
                                    nueva = 'N';
                                    break;
                                case 'Q':
                                    nueva = 'Ñ';
                                    break;
                                case 'R':
                                    nueva = 'O';
                                    break;
                                case 'S':
                                    nueva = 'P';
                                    break;
                                case 'T':
                                    nueva = 'Q';
                                    break;
                                case 'U':
                                    nueva = 'R';
                                    break;
                                case 'V':
                                    nueva = 'S';
                                    break;
                                case 'W':
                                    nueva = 'T';
                                    break;
                                case 'X':
                                    nueva = 'U';
                                    break;
                                case 'Y':
                                    nueva = 'X';
                                    break;
                                case 'Z':
                                    nueva = 'W';
                                    break;
                                case 'A':
                                    nueva = 'X';
                                    break;
                                case 'B':
                                    nueva = 'Y';
                                    break;
                                case 'C':
                                    nueva = 'Z';
                                    break;
                                default:
                                    Console.WriteLine("Imposible De Desencriptar");
                                    break;
                            }
                            Console.Write(nueva);

                        }
                        break;
                    default:
                        Console.WriteLine("Digite Una Opcion Valida");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Decea Volver Intentar si/no");
                seguir = Console.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
