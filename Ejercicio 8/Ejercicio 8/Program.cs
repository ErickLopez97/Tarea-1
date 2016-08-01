using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_resultado;
            Console.WriteLine("Ingrese el valor a multiplicar");
            v_num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                v_resultado = v_num * i;
                Console.WriteLine(v_num + " * " + i + " = " + v_resultado);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
