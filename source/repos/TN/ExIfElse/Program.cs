using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIfElse
{
    class Program
    {
        static string GetEven(int n)
        {
            if (n%2==0)
            {
                return "chet";
            }
            if (n % 2 != 0)
            {
                return "nechet";
            }
            return null;
        }
        static void Main(string[] args)
        {
            const bool logTest = 5 > 6;
            Console.WriteLine(logTest);
            var n = 23;
            n = int.Parse(Console.ReadLine());
            if (n > 9 && n < 100)
                Console.WriteLine("lol");
            else if (n < 10 || n >= 100)
                Console.WriteLine("lel");
          




            Console.ReadKey();


        }
    }
}
