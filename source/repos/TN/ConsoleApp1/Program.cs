using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// округление двух вещественных чисел
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>частвное</returns>
        static int DivideAndRound(int a, int b) => (int) Math.Round((double) a / b);
        static double DivideAndRound(double a, double b) => (int)Math.Round((double)a / b);

        static void Main(string[] args)
        {
            Console.WriteLine(DivideAndRound(5.2, 1.0));
            Console.WriteLine(DivideAndRound(3,2));
            Console.ReadKey();
        }
    }
}
