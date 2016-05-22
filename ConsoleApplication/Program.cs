using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.ServicioAritmeticoReference;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacionSeleccionada;
            double resul;

            Console.WriteLine("Seleccione la operación que desea realizar: " + "\n" +
                               "1.Sumar" + "\n" +
                               "2.Restar" + "\n" +
                               "3.Multiplicar" + "\n" +
                               "4.Dividir" + "\n");

            operacionSeleccionada = Int32.Parse(Console.ReadLine());

            switch (operacionSeleccionada)
            {

                case 1:
                    resul = procesarOperacion("sumar");
                    Console.WriteLine("\n" + "El resultado de la operación es: " + resul + "\n");
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadLine();
                    break;
                case 2:
                    resul = procesarOperacion("restar");
                    Console.WriteLine("\n" + "El resultado de la operación es: " + resul + "\n");
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadLine();
                    break;
                case 3:
                    resul = procesarOperacion("multiplicar");
                    Console.WriteLine("\n" + "El resultado de la operación es: " + resul + "\n");
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadLine();
                    break;
                case 4:
                    resul = procesarOperacion("dividir");
                    Console.WriteLine("\n" + "El resultado de la operación es: " + resul + "\n");
                    Console.WriteLine("Presione cualquier tecla para salir...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción Inválida" + "\n");
                    Console.WriteLine("Presione cualquier tecla para salir..." + "\n");
                    Console.ReadLine();
                    break;
            }
        }

        private static double procesarOperacion(string ptipoOperacion)
        {
            using (var svcAritmetico = new ServicioAritmeticoClient())
            {
                double valor1, valor2, resultado;

                Console.WriteLine("\n" + "Digite el valor número 1");
                valor1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("\n" + "Digite el valor número 2");
                valor2 = Double.Parse(Console.ReadLine());

                resultado = svcAritmetico.procesar(ptipoOperacion, valor1, valor2);

                return resultado;
            }
        }

    }
}
