using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimosConMetodo
{
    internal class Program
    {
        static bool VerificarPrimo(int numero)
        {
            int divisibilidad = 0;

            for (int divisor = 1; divisor <= numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    divisibilidad++;
                }
            }

            return divisibilidad <= 2;
        }

        static void Main(string[] args)
        {
            int desde = 0;
            int hasta = 0;

            Console.WriteLine("Ingrese el desde y el hasta");
            desde = Convert.ToInt32(Console.ReadLine());
            hasta = Convert.ToInt32(Console.ReadLine());

            for (int contador = desde; contador <= hasta; contador++)
            {
                if (VerificarPrimo(contador))
                {
                    Console.WriteLine(contador);
                }
            }

            Console.ReadKey();
        }
    }
}
