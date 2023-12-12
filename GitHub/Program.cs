using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.WriteLine("Escolha um numero para A");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um numero para B");

            b = Convert.ToInt32(Console.ReadLine());

          resultado = a + b;

            Console.WriteLine("O resultado é");

            Console.WriteLine(resultado);

            Console.ReadKey();





        }



    }
}
