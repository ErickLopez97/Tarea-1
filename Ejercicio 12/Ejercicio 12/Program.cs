using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_num1;

            Console.WriteLine("Ingrese un numero");
            v_num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (v_num1 = 1; v_num1 <= 4; v_num1++)
            {
                Console.Write(+v_num + " ");
            }
            Console.WriteLine();
            for (v_num1 = 1; v_num1 <= 4; v_num1++)
            {
                Console.Write(+v_num);
            }
            Console.WriteLine();
            for (v_num1 = 1; v_num1 <= 4; v_num1++)
            {
                Console.Write(+v_num + " ");
            }
            Console.WriteLine();
            for (v_num1 = 1; v_num1 <= 4; v_num1++)
            {
                Console.Write(+v_num);
            }
            Console.ReadKey();
        }
    }
}
