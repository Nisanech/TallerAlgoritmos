using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerAlgoritmos.BusinessLayer
{
    static public class AddProduct
    {
        /// <summary>
        /// Suma de dos números enteros
        /// </summary>
        /// <param name="var1">Primer número entero</param>
        /// <param name="var2">Segundo número entero</param>
        /// <returns>Resultado de sumar los dos números</returns>
        public static int Sumar(int var1, int var2)
        {
            int result = var1 + var2;
            
            return result;
        }

        /// <summary>
        /// Multiplicación de dos números
        /// </summary>
        /// <param name="var1">Primer número entero</param>
        /// <param name="var2">Segundo número entero</param>
        /// <returns>Resultado de multiplicar los dos números</returns>
        public static int Multiplicar(int var1, int var2)
        {
            int result = var1 * var2;

            return result;
        }
    }


    public static class NumberCounter
    {
        /// <summary>
        /// Contador de números pares, impares, positivos y negativos
        /// </summary>
        /// <param name="num">Límite de números a ingresar</param>
        /// <returns>
        ///     Mostrará la cantidad de números positivos, negativos,
        ///     pares e impares
        /// </returns>
        public static int Contador(int num)
        {
            int cont = 25;
            int pos = 0;
            int neg = 0;
            int par = 0;
            int impar = 0;
            int result = 0;
            string linea;

            for(int i = 0; i<cont; i++)
            {
                Console.Write("Ingrese los números " + i + ": ");
                linea = Console.ReadLine();
                num = int.Parse(linea);

                if(num > 0)
                {
                    pos++;
                }
                else
                {
                    if (num < 0)
                    {
                        neg++;
                    }
                }
                if(num % 2 == 0)
                {
                    par++;
                }
                else 
                {
                    if (num % 2 != 0)
                    {
                        impar++;
                    }
                }
            }
            Console.WriteLine("Números positivos: " + pos);
            Console.WriteLine("Números negativos: " + neg);
            Console.WriteLine("Números pares: " + par);
            Console.WriteLine("Números impares: " + impar);
            return result;
        }
    }

    public static class Temperature
    {
        public static double Fahrenheit(double num)
        {
            double f = (1.8) * num + 32;

            return f;
        }

        public static double Celsius(double num)
        {
            double c = (num - 32) / 1.8;

            return c;
        }
    }
}
