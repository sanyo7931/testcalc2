using System;

namespace Propram
{
    class Program
    {
        static void Main(string[] args)
        {
            Calclators calc = new Calclators();

            Console.WriteLine($"3+5={calc.Add(3, 5)}");
            Console.WriteLine($"3-5={calc.Sub(3, 5)}");
            Console.WriteLine($"3*5={calc.Mul(3,5)}");
            Console.WriteLine($"3/5={calc.Div(3, 5)}");

            Console.ReadKey();
        }
    }
}