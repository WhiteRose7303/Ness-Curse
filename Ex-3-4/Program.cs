using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give number with 8 digits");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("number chosen is {0}", s);
            int n = reversenum(s);
            Console.WriteLine("number revesed is {0}", n);
            Console.ReadLine();
        }
        static int reversenum(int n)
        {
            string s = n.ToString();
            string f = "";
            for (int i = s.Length-1; i >=0 ; i--)
            {
                f += s[i];
            }
            return int.Parse(f) ;
            
        }
    }
}
