using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(10);
            int size = myClass.get_n();
            Console.WriteLine("Length arr = " + size);
            foreach (var VARIABLE in myClass.get_a())
                Console.Write(VARIABLE + "  ");
            Console.Write("\n Введите кол-во сумированых элементов не более " + myClass.get_n());
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>size)
                Console.WriteLine("summ ne vozmojno");
            else
                Console.WriteLine("Sum {0} element of arr = {1}", number, myClass.summarr(number));

            int[] array = new int[12];
            Random random = new Random();
            Console.WriteLine("Mass for inicializ class: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.Write(array[i] + " ");
            }
            MyClass myClass1 = new MyClass(array);
            Console.WriteLine("\n ");
            Console.ReadKey();
        }
    }

    class MyClass
    {
        private int n;
        private int[] arr;

        public MyClass(int number)
        {
            n = number;
            arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * 2;
        }

        public MyClass(int[] arr)
        {
            n = arr.Length;
            arr = new int[n];
            arr.CopyTo(arr, 0);
        }
        ~MyClass()
        {
            Console.WriteLine("Distrucor");
        }

        public int get_n()
        {
            return n;
        }

        public int[] get_a()
        {
            return arr;
        }

        public int summarr(int q)
        {
            int s = 0;
            for (int i = 0; i < q; i++)
                s += arr[i];
            return s;
        }
    }
}
