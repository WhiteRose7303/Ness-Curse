using System;

namespace Ex_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("secconed number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double tosq = 5 * x + 7 * y * (x + y) / 2;
            Console.WriteLine(Math.Sqrt(tosq));
        }
    }
}
