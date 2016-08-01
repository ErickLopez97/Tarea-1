using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_num1, v_num2, v_num3, v_num4, v_operacion;

            Console.WriteLine("Ingrese un numero");
            v_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            v_num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            v_num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            v_num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            v_num4 = Convert.ToInt32(Console.ReadLine());

            v_operacion = v_num + v_num1 / v_num2 * v_num3 - v_num4 * 7 / 100;
            Console.WriteLine("El resultado es:     " + v_operacion);
            Console.ReadKey();

        }
    }
}
