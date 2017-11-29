using System;

namespace Array
{
    class Program
    {
        /// <summary>
        /// Function returns index of max element
        /// </summary>
        /// <param name="a">Array int numbers</param>
        /// <returns>index of max element</returns>
        static int GetIndexMaxElement(int[] a)
        {
            int max = a[0];
            int indexMax = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
        //======================================================================================

        static int[] ArrayPow(int[] a, int n)
        {
            int[] arrNew = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arrNew[i] = (int)Math.Pow(a[i], n);
            }
            return arrNew;
        }
        //=================================================================

        static void ModifyMatrix(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matr[i, j] = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays in C#");

            int[] arri;
            arri = new int[10];
            double[] arrd = new double[5];
            int[] arri2 = { 3, 1, 5, 6, 7 };

            Random random = new Random();
            Console.WriteLine("Array int random numbers");
            for (int i = 0; i < arri.Length; i++)
            {
                arri[i] = random.Next(150);
                Console.Write(arri[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Index of max element {0} arrays: {1}", arri[GetIndexMaxElement(arri)], GetIndexMaxElement(arri));
            Console.WriteLine();
            Console.WriteLine(("Index of max element new arrays: " +
                               GetIndexMaxElement(new int[] { 2, 9, 7, 5, 6, 3, 4, 1, 8 })));
            Console.WriteLine();

            Console.WriteLine("\nArray double random numbers");
            for (int i = 0; i < arrd.Length; i++)
            {
                arrd[i] = random.NextDouble() * 10;
                Console.Write("{0:0.00}  ", arrd[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Return array from function");
            int[] a1 = new[] { 2, 4, 7 };
            int[] a2 = new int[a1.Length];
            a2 = ArrayPow(a1, 3);
            foreach (var e in a2)
            {
                Console.WriteLine(e + "   ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Dinamic's Array");
            Console.WriteLine("Enter index of array");
            int size = int.Parse(Console.ReadLine());
            int[] arrput = new int[size];


            Console.WriteLine("Two Dimensional Array");
            int[,] matrix1 = new int[4, 4];
            int[][] matrix2 = new int[5][]; // неровные массивы 
            int[,] matrix3 = { { 1, 2, 3 }, { 3, 5, 6 } };

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(20);
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nUse function ModifyMatrix\n");

            ModifyMatrix(matrix1);
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
