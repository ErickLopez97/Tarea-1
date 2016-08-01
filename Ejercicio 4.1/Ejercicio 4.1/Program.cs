using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_num1, v_num2, v_operacion;

            Console.WriteLine("Ingrese numero Negativo");
            v_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero a sumar");
            v_num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero a multiplicar");
            v_num2 = Convert.ToInt32(Console.ReadLine());
            v_operacion = v_num + v_num1 * v_num2;
            Console.WriteLine("Su total es:     " + v_operacion);
            Console.ReadKey();

        }
    }
}
