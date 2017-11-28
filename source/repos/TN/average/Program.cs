using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    class Program
    {
        static int MiddleOf (int a, int b, int c)
        {
            if (b >= a && a >= c || c >= a && a >= b)
                return a;
            if (a >= b && b >= c || c >= b && b >= a)
                return b;
            if (a >= c && c >= b || b >= c && c >= a)
                return c;
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(15, 5, 90)); //должно вывести  15
            Console.WriteLine(MiddleOf(7, 7, 5)); // должно вывести  7
            Console.WriteLine(MiddleOf(8, 13, 8)); // должно вывести 8
            Console.WriteLine(MiddleOf(3, 3, 3)); // должно вывести  3
            Console.WriteLine(MiddleOf(5, 0, 1)); // должно вывести  1
            Console.WriteLine(MiddleOf(10, 5, 5)); // должно вывести  5
            Console.ReadKey();

        }
    }
}
