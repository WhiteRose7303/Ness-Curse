using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //first exersise in page 69
            string name = "hadar roy and uri";
            int age = 16;
            string adress = "somewhere";
            int phone = 0123456789;
            string title = "nothing";
            print(name, age, adress, phone, title);

            
        }
        public static void print(string name, int age , string address , int phone , string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("*******************************************************");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Phone: "+phone);
            Console.WriteLine("Title: "+title);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#######################################################");
            Console.WriteLine();

        }

    }
}
