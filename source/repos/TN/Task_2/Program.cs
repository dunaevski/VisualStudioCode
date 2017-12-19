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
            int n;
            Console.WriteLine("Введите размер массива: ");
            n =Int32.Parse(Console.ReadLine());
            Random random =new Random();
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = random.Next(10);
            }
            for (var index = 0; index < A.Length; index++)
            {
                var i = A[index];
                var count = A.Count(t => i == t);
                Console.Write(i+" ");
                if (index == A.Length-1)
                    Console.WriteLine("\n{0} повторяется {1} раз", i, count);
            }

            Console.ReadKey();
        }
    }
}
