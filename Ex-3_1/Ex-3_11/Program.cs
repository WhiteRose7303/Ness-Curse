using System;

namespace Ex_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Days: ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            days = days - years * 365;
            int months = days / 30;
            days = days - months * 30;
            int day = days;
            Console.WriteLine(years + " Years, " + months + " Months, " + days + " Days.");
        }
    }
}
