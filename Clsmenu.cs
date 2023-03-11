using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_INFO104
{
    internal class Clsmenu
    {
        public static ClsTransacciones transacciones = new ClsTransacciones();
        public static void menu()
        {

            byte opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar");
                Console.WriteLine("2- Ingresar");
                Console.WriteLine("3- Consultar");
                Console.WriteLine("4- Modificar");
                Console.WriteLine("5- Reporte");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1- Inicializar"); transacciones.inicializar();
                        break;
                    case 2:
                        Console.WriteLine("2- Ingresar"); transacciones.ingresar();
                        break;
                    case 3:
                        Console.WriteLine("3- Consultar"); transacciones.consultar();
                        break;
                    case 4:
                        Console.WriteLine("4- modificar"); transacciones.modificar();
                        break;
                    case 5:
                        Console.WriteLine("5- Reporte"); transacciones.reportar();
                        break;
                    case 6:
                        Console.WriteLine("6- Salir");
                        break;
                    default:
                        break;
                }

            } while (opcion != 6);
        }
    }
}
