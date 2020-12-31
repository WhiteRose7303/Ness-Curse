using System;

namespace Ex_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Insret PayCheck: ");
            double Pay = int.Parse(Console.ReadLine());
            double fin = Pay - (Pay * 0.15);
            fin -= (Pay * 0.04);
            fin -= (Pay * 0.025);
            Console.WriteLine("Neto: " + fin);
        }
    }
}
