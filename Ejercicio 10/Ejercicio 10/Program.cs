using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, total;

            Console.WriteLine("Ingrese un numero:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero:");
            z = Convert.ToInt32(Console.ReadLine());

            total = (x + y) * z;
            Console.WriteLine("El resultado es:     " + total);
            Console.ReadKey();
        }
    }
}
