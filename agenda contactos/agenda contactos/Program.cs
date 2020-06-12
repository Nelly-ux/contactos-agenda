using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_contactos
{
    class Program
    {
        static string[,] registro = new string[4, 10];
        static void Main(string[] args)
        {
            string usuario = "contacto no encontrado";

            string buscar = "";


            Console.Write("\nAGENDA\n");
            Console.Write("ingrese sus datos\n");
            for (int e = 0; e < 10; e++)

            {

                Console.Write("\nnombre: ");

                registro[0, e] = Console.ReadLine();


                Console.Write("ingrese apellido: ");

                registro[1, e] = Console.ReadLine();


                Console.Write("ingrese direccion: ");

                registro[2, e] = Console.ReadLine();



                Console.Write("ingrese telefono: ");

                registro[3, e] = Console.ReadLine();

            }

            Console.WriteLine("AGENDA\n");
            Console.WriteLine("___\n");

            for (int e = 0; e < 10; e++)

            {

                Console.WriteLine(registro[0, e] + "__" + registro[1, e] + "__" + registro[2, e] + "__" + registro[3, e]);

            }

            Console.WriteLine("___\n");



            Console.Write("BUSCAR CONTACTO: ");

            buscar = Console.ReadLine();



            for (int e = 0; e < 10; e++)

            {

                if (buscar == registro[0, e])

                {

                    usuario = registro[0, e] + "," + registro[1, e] + "," + registro[2, e] + "," + registro[3, e];

                }

            }



            Console.WriteLine(usuario);



            Console.ReadKey();

        }
    }
}
