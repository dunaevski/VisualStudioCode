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
            for (int i = 0; i < num; i++)
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
        }
    }
}
