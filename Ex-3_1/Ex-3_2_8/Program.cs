using System;

namespace Ex_3_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                if (x % 10 == 0)
                {
                    Console.WriteLine("zugi and mitahlek");
                }
                else
                {
                    Console.WriteLine("zugi and lo mithalek");
                }
            }
            else
            {
                if (x % 5 == 0)
                {
                    Console.WriteLine("lo zugi and mitahlek");
                }
                else
                {
                    Console.WriteLine("lo zugi and lo mithalek");
                }
            }
                    
              
                   
                 
            
        }
    }
}
