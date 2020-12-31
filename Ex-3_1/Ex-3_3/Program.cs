using System;

namespace Ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(x, 2));
            Console.WriteLine(Math.Sqrt(x));
        }
    }
}
