using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new[] {1, 3, 5, 10, 5, 10, 3, 11, 12, 5};
            foreach (var i in A)
            {
                var count = A.Count(t => i == t);
                Console.WriteLine("{0} повторяеться {1} раз", i, count);
            }
           
            Console.ReadKey();
        }
    }
}
