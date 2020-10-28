using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAlgoritmos.BusinessLayer;

namespace TallerAlgoritmos
{
    class Program
    {
        public static void Main()
        {
            int num = 0;
            int num1 = 0;
            int num2 = 0;
            int resultsum = 0;
            int resultpro = 0;
            int result = 0;

            Console.WriteLine("Operaciones");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("Elija una opción:");
            Console.WriteLine("\tsm - Operación suma y multiplicación");
            Console.WriteLine("\tcn - Contador de números");
            Console.WriteLine("\tc - Conversión a Celsius");
            Console.WriteLine("\tf - Conversión a Fahrenheit");
            Console.Write("Opción ");

            switch (Console.ReadLine())
            {
                case "sm":
                    Console.Write("Ingrese el primer número ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Ingrese el segundo número ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    resultsum = Operaciones.Sumar(num1, num2);
                    resultpro = Operaciones.Multiplicar(num1, num2);

                    Console.WriteLine($"Resultado: {num1} + {num2} = " + resultsum);
                    Console.WriteLine($"Resultado: {num1} * {num2} = " + resultpro);
                    break;

                case "cn":
                    result = ContadorNumeros.Contador(num);
                    break;

                case "c":
                    break;

                case "f":
                    break;
            }

            Console.Write("Presione cualquier tecla para salir del programa");
            Console.ReadKey();
        }
            
    }
}
