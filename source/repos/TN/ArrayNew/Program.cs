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

            for (int i = 10; i < a.Length; i++)
            {
                int sum1;
                int n;
                int m;
                if (a[i] > 100)
                {
                    m = a[i] % 100;
                    n = m % 10;
                    var k = m / 10;
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
