using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num, v_num1, v_suma;
            Console.WriteLine("Ingrese un numero");
            v_num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un numero");
            v_num1 = Convert.ToInt32(Console.ReadLine());

            v_suma = (v_num + v_num1) * 7 / 100;

            Console.WriteLine("El 7% de la suma es:     " + v_suma);
            Console.ReadKey();
        }
    }
}
