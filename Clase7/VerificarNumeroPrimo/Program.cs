using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisibilidad = 0;
            Console.WriteLine("Ingrese un número");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int divisor = 1; divisor <= numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    divisibilidad++;
                }
            }

            if (divisibilidad <= 2)
                Console.WriteLine("Es primo");
            else 
            {
                Console.WriteLine("no Es primo");
            }
            Console.ReadKey();

        }
    }
}
