using System;

namespace Ex_3_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First num: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("secconed num: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("third number: ");
            int z = int.Parse(Console.ReadLine());

            if (x+y > z)
            {
                Console.WriteLine("OK");
            }
            else if (y+z >x)
            {
                Console.WriteLine("OK");
            }
            else if (x+z > y)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not OK");
            }


        }
    }
}
