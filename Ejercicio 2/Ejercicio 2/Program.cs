using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v_num = 0;
            int v_num1 = 0;
            int v_suma = 0;
            Console.WriteLine("Ingrese un numero");
            v_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            v_num1 = Convert.ToInt32(Console.ReadLine());
            v_suma = v_num + v_num1;
            Console.WriteLine("Su total es:   " + v_suma);
            Console.ReadKey();
        }
    }
}
