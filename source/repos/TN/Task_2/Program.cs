﻿using System;
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
            Console.WriteLine("Введите размер массива: ");
            var n = int.Parse(Console.ReadLine());
            var random =new Random();
            var a = new int[n];
            // var a = new int[9] {2,1,3,8,1,1,2,8,9};
        
            var count = new int[a.Length];
              for (var i = 0; i < a.Length; i++)
                  a[i] = random.Next(5); 


            for (var index = 0; index < a.Length; index++)
            {
                count[index] = a.Count(t => a[index] == t);
                Console.Write(a[index] + " ");
            }
            Console.WriteLine("\n{0} повторяется {1} раз",a[count.ToList().IndexOf(count.Max())], count.Max());
            Console.ReadKey();
        }
    }
}
