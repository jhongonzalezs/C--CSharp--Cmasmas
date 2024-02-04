using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, C_Numeros;

            Console.WriteLine("Digite Una La cantidad");
            C_Numeros = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= C_Numeros; i++) {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine("Par" + " (" + i+") ");
                }
                else
                {
                    if (i%2 != 0)
                    {
                        Console.WriteLine("Impar" + " (" + i + ") ");
                    }
                }
            }

            Console.ReadKey();
            
        }
    }
}
