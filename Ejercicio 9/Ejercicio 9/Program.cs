using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, promedio;

            Console.WriteLine("Ingrese la primer nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota:");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota:");
            nota4 = Convert.ToInt32(Console.ReadLine());
            
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Promedio de las notas:     " + promedio);
            Console.ReadKey();
        }
    }
}
