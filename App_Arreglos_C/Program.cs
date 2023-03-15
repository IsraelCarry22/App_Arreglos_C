using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Arreglos_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tc;
            int cont = 1;

            Console.WriteLine("========== Conversiones Temperatura ==========\n");
            Console.Write("Ingresa las cant de temperaturas: ");
            Tc = int.Parse(Console.ReadLine());

            int[] temperatura = new int[Tc];

            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.WriteLine("\nIngresa la temperatura: ");
                temperatura[i] = int.Parse(Console.ReadLine());
            }

            double[] ResultadoF_C = new double[Tc];
            for (int i = 0; i < ResultadoF_C.Length; i++)
            {
                ResultadoF_C[i] = (1.8 * temperatura[i]) + 32;
            }

            double[] ResultadoK_C = new double[Tc];
            for (int i = 0; i < ResultadoK_C.Length; i++)
            {
                ResultadoK_C[i] = temperatura[i] + 273.15;
            }

            double[] ResultadoK_F = new double[Tc];
            for (int i = 0; i < ResultadoK_F.Length; i++)
            {
                ResultadoK_F[i] = 1.8 * (ResultadoK_C[i] - 273.15) + 32;
            }

            Console.Clear();
            Console.WriteLine("\nTus temperaturas de Centigrada a Fahrenheit.");

            for (int i = 0; i < ResultadoF_C.Length; i++)
            {
                Console.WriteLine(cont + "°. " + ResultadoF_C[i]);
                cont++;
            }
            cont = 1;
            Console.WriteLine("\nTus temperaturas de Centigrada a Kelvin.");

            for (int i = 0; i < ResultadoK_C.Length; i++)
            {
                Console.WriteLine(cont + "°. " + ResultadoK_C[i]);
                cont++;
            }
            cont = 1;
            Console.WriteLine("\nTus temperaturas de Kelvin a Fahrenheit.");

            for (int i = 0; i < ResultadoK_F.Length; i++)
            {
                Console.WriteLine(cont + "°. " + ResultadoK_F[i]);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
