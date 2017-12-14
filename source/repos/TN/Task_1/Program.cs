using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var count = 0;
            while (!string.IsNullOrEmpty(number))
            {
                count++;
                number = number.Replace("" + number[0], "");
            }
            Console.WriteLine(count);


          Console.ReadKey();
        }
    }
}
