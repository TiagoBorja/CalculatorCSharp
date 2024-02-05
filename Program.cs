using System;

namespace CalculatorC
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();

        }
        static void Sum()
        {
            Console.Clear();

            Console.Write("Number 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            Console.Write("Number 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            double total = v1 + v2;

            Console.WriteLine($"The total sum is {total}");
            Console.ReadKey();
        }
        static void Subtraction()
        {
            Console.Clear();

            Console.Write("Number 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            Console.Write("Number 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            double total = v1 - v2;
            Console.WriteLine($"The total subtraction is {total}");
            Console.ReadKey();
        }
    }
}