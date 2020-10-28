using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAlgoritmos.BusinessLayer;

namespace TallerAlgoritmos
{
    class AddProduct
    {
        static void Main(string[] args)
        {
            int num1 = 0; 
            int num2 = 0;
            int result = 0;

            Console.WriteLine("Operaciones básicas\r");
            Console.WriteLine("-------------------\n");


            Console.Write("Ingrese el primer número ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Elija una opción:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tm - Multiplicar");
            Console.Write("Opción ");

            switch (Console.ReadLine())
            {
                case "s":
                    result = BusinessLayer.AddProduct.Sumar(num1, num2);
                    Console.WriteLine($"Resultado: {num1} + {num2} = " + result);
                    break;

                case "m":
                    result = BusinessLayer.AddProduct.Multiplicar(num1, num2);
                    Console.WriteLine($"Resultado: {num1} + {num2} = " + result);
                    break;
            }

            Console.Write("Presione cualquier tecla para salir del programa");
            Console.ReadKey();
        }

    }
}
