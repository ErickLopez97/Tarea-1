using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_num1, v_num2, v_num3, v_suma;
            Console.WriteLine("Ingrese un numero a sumar");
            v_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero a sumar negativo");
            v_num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero a multiplicar");
            v_num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero a dividir");
            v_num3 = Convert.ToInt32(Console.ReadLine());
            v_suma = v_num + v_num1 * v_num2 / v_num3;
            Console.WriteLine("El resultado es:     " + v_suma);
            Console.ReadKey();

        }
    }
}
