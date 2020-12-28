using System;

namespace Ex_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pay = new int[12];
            Console.Write("Name: ");
            string name = Console.ReadLine();
            for (int i = 1; i < pay.Length+1;i++)
            {
                Console.Write("Pay "+i+": ");
                pay[i - 1] = int.Parse(Console.ReadLine());
            }
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(name);
            for (int i = 1; i < pay.Length; i++)
            {
                Console.WriteLine(pay[i]);
            }
            Console.WriteLine("Happy new tax year!");
                
        }
    }
}
