using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDebug
{
    class Program
    {
        static double GetDescriminant(double a, double b, double c) => b * b - 4 * a * c;

        static double GetFirstRoot(double a, double b, double c)
        {
            var d = GetDescriminant(a, b, c);
            var square = Math.Sqrt(d);
            return (-b - square / (2 * a));
        }
        static void Main(string[] args)
        {
            double result = GetFirstRoot(1, 1, 1);
            Console.WriteLine("Root = " + result);
            int varX = 5, varY = 7;
            SwapVariable(ref varX, ref varY);
            Console.WriteLine("теперь переменные х={0} y={1}", varX, varY);

            Console.ReadKey();

        }

        static void SwapVariable(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Внутри функции х={0} y={1}", x, y);

        }
    }
}
