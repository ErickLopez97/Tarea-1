using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su edad es de " + edad + " años");
            Console.ReadKey();
        }
    }
}
