using System;

namespace Ex_3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Winter");
            Console.WriteLine("2) Spring");
            Console.WriteLine("3) Summer");
            Console.WriteLine("4) Auttom");
            Console.Clear();
            Console.Write("Select: ");
            int chose = int.Parse(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    Console.WriteLine("December, January and February.");
                    break;

                case 2:
                    Console.WriteLine("March, April and May");
                    break;

                case 3:
                    Console.WriteLine("June, July and August.");
                    break;

                case 4:
                    Console.WriteLine("September, October and November.");
                    break;
            }
        }
    }
}
