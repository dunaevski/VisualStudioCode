using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNew
{
    class Program
    {
        static void Return(int[] a)
        {
            const int sum = 10;
            var sum1 = 0;
            var n = 0;
            var m = 0;
            var k = 0;

            for (int i = 10; i < a.Length; i++)
            {
                if (a[i] > 100)
                {
                    m = a[i] % 100;
                    n = m % 10;
                    k = m / 10;
                    sum1 = 1 + n + k;
                }
                else
                {
                    m = a[i] % 10;
                    n = a[i] / 10;
                    sum1 = m + n;
                }

                if (sum == sum1)
                {
                    Console.WriteLine(a[i]+ "\n");
                }

            }
        }
        static void Main(string[] args)
        {
            int [] array = new int[120];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Return(array);
            Console.ReadLine();
        }
    }
}
