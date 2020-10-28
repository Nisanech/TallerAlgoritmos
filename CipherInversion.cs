using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerAlgoritmos.BusinessLayer;

namespace TallerAlgoritmos
{
    class CipherInversion
    {
        static void Main(String[] args)
        {
            int num = 0;
            int numinverso = 0;
            

            Console.WriteLine("Invertir número\r");
            Console.WriteLine("---------------\n");

            Console.Write("Ingrese el número ");
            num = int.Parse(Console.ReadLine());
            numinverso = BusinessLayer.CipherInversion.Invertir(num);

            Console.WriteLine("El número inverso de {num} es {numinverso}", num, numinverso);
        }
    }
}
