using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Todo_En_uno2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int Opcion;
                String nuevo, mensaje, opcion;
                opcion = "Si";

                while (opcion == "Si")
                {
                    Console.Clear();
                    Console.WriteLine("1= Crear Un Archivo De Texto Nuevo");
                    Console.WriteLine("2= Agregar Texto A Cualquier Archivo");
                    Console.WriteLine("3= Mostrar Texto De Cualquier Archivo");
                    Console.WriteLine("Digite Una Opcion");
                    Opcion = Convert.ToInt16(Console.ReadLine());

                    switch (Opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Digite El Nombre Del Archivo A Crear");
                            nuevo = Console.ReadLine();
                            TextWriter archivo;
                            archivo = new StreamWriter(nuevo + ".txt");
                            Console.Clear();
                            archivo.Close();
                            Console.WriteLine("Archivo Creado Correctamente");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Digite El Nombre Del Archivo Para Agregar Informacion");
                            nuevo = Console.ReadLine();
                            StreamWriter Guardar = File.AppendText(nuevo + ".txt");
                            Console.Clear();
                            Console.WriteLine("Digite El Texto A Guardar");
                            mensaje = Console.ReadLine();
                            Guardar.WriteLine(mensaje);
                            Console.Clear();
                            Console.WriteLine("Informacion Guardada Correctamente");
                            Guardar.Close();
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Digite El Nombre Del Archivo A Mostrar");
                            nuevo = Console.ReadLine();
                            Console.Clear();
                            TextReader Mostrar;
                            Mostrar = new StreamReader(nuevo + ".txt");
                            Console.WriteLine(Mostrar.ReadToEnd());
                            Mostrar.Close();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Lo Sentimos, Esa Opcion No Existe");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Decea Volver Al Menu Principal Si/No");
                    opcion = Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lo Sentimos, Las Letras No Se Incluyen.");
                Console.ReadKey();
            }
               

        }
    }

}
