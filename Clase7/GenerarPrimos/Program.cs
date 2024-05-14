using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desde=0;
            int hasta = 0;

            Console.WriteLine("Ingrese el desde y el hasta");
            desde = Convert.ToInt32(Console.ReadLine());
            hasta = Convert.ToInt32(Console.ReadLine());

            for (int contador = desde; contador <= hasta; contador++) 
            {
                int divisibilidad = 0;
                int numero = contador;
                #region verificar primos

                for (int divisor = 1; divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        divisibilidad++;
                    }
                }

                if (divisibilidad <= 2)
                    Console.WriteLine(numero);
                #endregion
            }

            Console.ReadKey();
        }
    }
}
