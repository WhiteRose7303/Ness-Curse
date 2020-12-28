using System;

namespace EX_2_2
{
    class Program
    {
        //PARCTICE 2
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Phone: ");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Celular: ");
            int celular = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("#######################################################");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Name: "+name);
            Console.WriteLine();
            Console.Write("Age: "+age);
            Console.WriteLine();
            Console.Write("Address: "+address);
            Console.WriteLine();
            Console.Write("Phone: "+phone);
            Console.WriteLine();
            Console.Write("Celcular: "+celular);
            Console.WriteLine();
            Console.Write("Title: "+title);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

        }
    }
}
