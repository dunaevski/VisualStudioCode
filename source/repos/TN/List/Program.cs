using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(3);
            list.Insert(1, 8);
            list.Remove(0);
            list.Sort();
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();

        }
    }
}
