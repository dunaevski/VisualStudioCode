using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Dimensional Array");
            int[,] matrix1 = new int[4, 4];
            int[][] matrix2 = new int[5][]; // неровные массивы 
            int[,] matrix3 = {{1, 2, 3}, {3, 5, 6}};

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    
                }
            }


            Console.ReadLine();
        }

        }
    }
}
