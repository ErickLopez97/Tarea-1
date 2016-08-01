using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num1, v_num2, v_num3, v_operacion;

            Console.WriteLine("Ingrese numero a multiplicar");
            v_num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero a multiplicar");
            v_num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero a multiplicar");
            v_num3 = Convert.ToInt32(Console.ReadLine());

            v_operacion = v_num1 * v_num2 * v_num3;
            Console.WriteLine("Su resultado es:   " + v_operacion);
            Console.ReadKey();

        }
    }
}
