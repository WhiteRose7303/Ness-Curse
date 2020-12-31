using System;

namespace Ex_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Oporetor: ");
            Console.WriteLine("1) X");
            Console.WriteLine("2) +");
            Console.WriteLine("3) /");
            Console.WriteLine("4) -");
            int op = int.Parse(Console.ReadLine());
            Console.Write("Secconed number: ");
            int y = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine(x + " X " + y + " = " + (x*y));
            }
            if (op == 2)
            {
                Console.WriteLine(x + " + " + y + " = " + (x+y));
            }
            if (op == 3)
            {
                Console.WriteLine(x + " / " + y + " = " + (x/y));
            }
            if (op == 4)
            {
                Console.WriteLine(x + " - " + y + " = " + (x-y));
            }

        }
    }
}
