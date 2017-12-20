using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static int minVal(params int[] num)
        {
            int min;
            if (num.Length == 0)
            {
                Console.WriteLine("Ne ukazan argument");
                return 0;
            }
            else
            {
                min = num[0];
                foreach (int t in num)
                {
                    if (t<min)
                        min = t;
                }
                return min;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(minVal(3,4,-5,8));
            Console.WriteLine(minVal(17,12,87));
            Console.WriteLine(minVal());

            Console.ReadLine();
        }
    }
}
