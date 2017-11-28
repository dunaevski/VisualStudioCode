using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static int GetIndexMaxElement(int[] a)
        {
            int max = a[0];
            int indexMax = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>max)
                {
                    indexMax = i;

                }
            }
            return indexMax;
        }

        //======================================================================================
        static int[] ArrayPow(int[]a, int n)
        {
            int[] arrNew = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arrNew[i] = (int) Math.Pow(a[i], n);
            }
            return arrNew;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in C#");

            int[] arri;
            arri = new int[10];
            double[] arrd = new double[5];
            int[] arri2 = {3, 1, 5, 6, 7};

            Random random = new Random();
            Console.WriteLine("Array int random numbers");
            for (int i = 0; i < arri.Length; i++)
            {
                arri[i] = random.Next(150);
                Console.Write(arri[i] + "\t");
            }

            Console.WriteLine("\nArray double random numbers");
            for (int i = 0; i < arrd.Length; i++)
            {
                arrd[i] = random.NextDouble()*10;
                Console.Write("{0:0:000}", arrd[i] + "\t");
            }

            Console.WriteLine("Return array from function");
            int[] a1 = new[] { 2, 4, 7 };
            int[] a2 = new int[a1.Length];
            a2 = ArrayPow(a1, 3);
            foreach (var e in a2)
            {
                Console.WriteLine(e + "   ");
            }

            Console.ReadLine();


        }
    }
}
