using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
    class Sumator
    {
        public int summa;

        public Sumator(int num)
        {
            summa = 0;
            for (int i = 0; i <= num; i++)
                summa += i;
        }

        public Sumator(Sumator obj)
        {
            summa = obj.summa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sumator s1 = new Sumator(9);
            Sumator s2 = new Sumator(s1);
            Console.WriteLine("Object s1 = " + s1.summa);
            Console.WriteLine("Object s2 = " + s2.summa);
            Console.ReadLine();

        }
    }
}
