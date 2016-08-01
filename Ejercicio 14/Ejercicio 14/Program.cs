using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, kelvin, farenheit;

            Console.WriteLine("Ingrese los grados CELSIUS");
            celsius = Convert.ToInt32(Console.ReadLine());
            kelvin = celsius + 273;
            Console.WriteLine("Grados CELSIUS a KELVIN son:      " + kelvin);
            farenheit = (9 * celsius) / 5 + 32;
            Console.WriteLine("Grados CELSIUS a FARENHEIT son:   " + farenheit);

            Console.ReadKey();

        }
    }
}
