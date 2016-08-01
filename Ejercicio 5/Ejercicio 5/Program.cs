using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_A, v_B, v_Cambio;

            Console.WriteLine("Ingrese valor de A");
            v_A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese valor de B");
            v_B = Convert.ToInt32(Console.ReadLine());

            v_Cambio = v_A;
            v_A = v_B;
            v_B = v_Cambio;

            Console.WriteLine("Ahora el valor de A es:   " + v_A + "  y el valor de B es:   " + v_B);
            Console.ReadKey();

        }
    }
}
