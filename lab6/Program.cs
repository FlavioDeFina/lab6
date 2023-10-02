using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero maximo de personas: ");
            int limite = int.Parse(Console.ReadLine());

            Console.Clear();

            int AsistActuales = 0;
            int PersIngresaron = 0;
            int PersSalieron = 0;
            int lleno = 0;
            int vacio = 0;

            while (true) 
            {
                float Aforo = (float)AsistActuales / limite * 100;
                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " +AsistActuales);
                Console.WriteLine("| Aforo |" + Aforo.ToString("0") + "%");
                Console.WriteLine("| Máximo | " + limite + " personas");
                Console.WriteLine("=================================");

                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                char opcion = Console.ReadKey().KeyChar;

                Console.Clear();

                switch (opcion)
                {
                    case 'i':
                        if (AsistActuales < limite)
                        {
                            AsistActuales++;
                            PersIngresaron++;
                        }
                        else
                        {
                            Console.WriteLine("El local está lleno. No se pueden ingresar más personas.");
                            lleno++;
                        }
                        break;
                    case 's':
                        if (AsistActuales > 0)
                        {
                            AsistActuales--;
                            PersSalieron++;
                        }
                        else
                        {
                            Console.WriteLine("El local ya está vacío. No se pueden sacar más personas.");
                            vacio++;
                        }
                        break;
                    case 'x':
                        Console.Clear();
                        Console.WriteLine("======================== =========");
                        Console.WriteLine("El programa ha terminado");
                        Console.WriteLine("=================================");

                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(PersIngresaron + " personas ingresaron");
                        Console.WriteLine(PersSalieron + " personas salieron");
                        Console.WriteLine(lleno + " veces se llenó el local");
                        Console.WriteLine("Estuvo vacío " + vacio + " veces");
                        break;
                }
            }
        }
    }
}
