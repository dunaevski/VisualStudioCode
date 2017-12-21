using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMyArray
{
    class MyArray
    {
        double[] a;
        public int length;
        public bool errFlag;

        public MyArray(int size)
        {
            a = new double[size];
            length = size;
        }

        private bool Ok(int index)
        {
            if (index >= 0 && index < length)
                return true;
            else
                return false;
        }

        public double this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    errFlag = false;
                    return a[index]
                }
                else
                {
                    errFlag = true;
                    return 0;
                }
            }
            set
            {
                if (Ok(index))
                {
                    a[index] = value;
                    errFlag = false;
                }
                else
                    errFlag = true;
            }
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(5);
            Console.WriteLine("Использование метода set индексатора: ");
            for (int i = 0; i < array.length; i++)
            {
                array[i] = Math.Sqrt(i);
            }
        }
    }
    }
}
