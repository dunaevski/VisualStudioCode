using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    class Program
    {
        static void StringConcatination()
        {
            var str = "";
            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString() + " ";
            }
        }
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder();
            builder.Append("Это строка! - ");
            builder.Append("This is a string!");
            Console.WriteLine(builder);

            builder[0] = 'C';
            Console.WriteLine(builder);

            var watch = new Stopwatch();
            watch.Start();
            StringConcatination();
            Console.WriteLine("Отработало");
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
Dun kek
