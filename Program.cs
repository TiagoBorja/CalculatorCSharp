using System;

namespace CalculatorC
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
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
        static void Division()
        {
            Console.Clear();

            Console.Write("Number 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            Console.Write("Number 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            double total = v1 / v2;
            Console.WriteLine($"The total division is {total}");
            Console.ReadKey();
        }
        static void Multiplication()
        {
            Console.Clear();

            Console.Write("Number 1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            Console.Write("Number 2: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");

            double total = v1 * v2;
            Console.WriteLine($"The total division is {total}");
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello! This aplication is a simple calculator. Choose 1 option!");

            Console.WriteLine("");

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("-------------------------");

            double option = Convert.ToDouble(Console.ReadLine());

            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;

                default: Menu(); break;
            }
        }
    }
}