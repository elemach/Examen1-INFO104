using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_INFO104
{
    internal class ClsTransacciones
    {
        protected int[] numfactura = new int[15];
        protected string[] numplaca = new string[15];
        protected string[] fecha = new string[15];
        protected string[] hora = new string[15];
        protected int[] tipovehiculo = new int[15];
        protected int[] numcaseta = new int[15];
        protected float[] montopagar = new float[15];
        protected float[] pagacon = new float[15];
        protected float[] vuelto = new float[15];
        protected int count = 0;
        public ClsTransacciones() { }
        public ClsTransacciones(int[] numfactura, string[] numplaca, string[] fecha, string[] hora, int[] tipovehiculo, int[] numcaseta, float[] montopagar, float[] pagacon, float[] vuelto)
        {
            this.numfactura = numfactura;
            this.numplaca = numplaca;
            this.fecha = fecha;
            this.hora = hora;
            this.tipovehiculo = tipovehiculo;
            this.numcaseta = numcaseta;
            this.montopagar = montopagar;
            this.pagacon = pagacon;
            this.vuelto = vuelto;
        }
        public void inicializar()
        {
            ClsTransacciones vector = new ClsTransacciones();
            for (int i = 0; i < vector.numfactura.Length; i++)
            {
                vector.numfactura[i] = 0;
                vector.numplaca[i] = "";
                vector.fecha[i] = "";
                vector.hora[i] = "";
                vector.tipovehiculo[i] = 0;
                vector.numcaseta[i] = 0;
                vector.montopagar[i] = 0;
                vector.pagacon[i] = 0;
                vector.vuelto[i] = 0;
            }
        }
        public void ingresar()
        {
            ClsTransacciones vector = new ClsTransacciones();
            byte opcion = 0;
            while (opcion == 1)
            {
                if (count == 15)
                {
                    Console.Write("Vectores Llenos.");
                    break;
                }
                count++;
                Console.WriteLine("Digite el numero de la factura");
                vector.numfactura[count] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el numero de placa");
                vector.numplaca[count] = Console.ReadLine();

                Console.WriteLine("Digite la fecha (DD/MM/AAAA)");
                vector.fecha[count] = Console.ReadLine();

                Console.WriteLine("Digite la hora(HH:MM)");
                vector.hora[count] = Console.ReadLine();

                for (bool i = false; i == true;)
                {
                    Console.WriteLine("Digite el tipo de vehiculo. \n 1:Moton \n 2:Vehiculo Liviano \n 3:Camion o Pesado \n 4:Autobus");
                    int validar = int.Parse(Console.ReadLine());
                    if (validar == 1 || validar == 2 || validar == 3 || validar == 4)
                    {
                        vector.tipovehiculo[count] = validar;
                        i=true;
                    }
                    else Console.WriteLine("Tipo de Vehiculo invalido.");
                }

                for (bool i = false; i == true;)
                {
                    Console.WriteLine("Digite el numero de caseta:1,2,3.");
                    int validar = int.Parse(Console.ReadLine());
                    if (validar == 1 || validar == 2 || validar == 3)
                    {
                        vector.numcaseta[count] = validar;
                        i = true;
                    }
                    else Console.WriteLine("Numero de caseta invalido");
                }

                switch (tipovehiculo[count])
                {
                    case 1:
                        vector.montopagar[count] = 500;
                        break;
                    case 2:
                        vector.montopagar[count] = 700;
                        break;
                    case 3:
                        vector.montopagar[count] = 2700;
                        break ;
                    case 4:
                        vector.montopagar[count] = 3700;
                        break;
                }

                while (vector.montopagar[count]< vector.pagacon[count])
                {
                    Console.WriteLine("Monto con el que va a cancelar");
                    vector.pagacon[count] = float.Parse(Console.ReadLine());
                }

                vector.vuelto[count] = vector.pagacon[count] - vector.montopagar[count];
                Console.WriteLine("El cambio del cliente es de: " + vector.vuelto[count]);

                Console.WriteLine("Desea ingresar nuevos datos? \n 0:Si 1:No");
                opcion = byte.Parse(Console.ReadLine());
            }
        }
        public void consultar()
        {
            ClsTransacciones vector = new ClsTransacciones();
            string busqueda = "";
            int indexer = Array.IndexOf(vector.numplaca, busqueda);
            Console.WriteLine("Digite el numero de placa que desea buscar");
            busqueda = Console.ReadLine();
            if (indexer != -1)
            {
                Console.WriteLine("El numero de factura es: "+ vector.numfactura[indexer]+
                    "\n El numero de placa es: " + vector.numplaca[indexer]+
                    "\n La fecha es: " + vector.fecha[indexer]+
                    "\n La hora es: " + vector.hora[indexer]+
                    "\n El tipo de vehiculo es: " + vector.tipovehiculo[indexer]+
                    "\n El numero de caseta es: " + vector.numcaseta[indexer]+
                    "\n El monto a pagar es: " + vector.montopagar[indexer]+
                    "\n Se paga con: " + vector.pagacon[indexer]+
                    "\n El vuelto es de: " + vector.vuelto[indexer]);
            }
        }
        public void modificar()
        {

        }
        public void reportar()
        {

        }
    }
}
