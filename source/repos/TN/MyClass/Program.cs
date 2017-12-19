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
            int size = myClass.
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
