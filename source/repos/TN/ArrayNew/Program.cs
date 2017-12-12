using System;

namespace ArrayNew
{
    class Program
    {
        private static void Return()
        {
            const int size = 2018;
            var arrInts = new int[120];
            var number = new int[size];
            var index = 0;
            for (int i = 0; i < size; i++)
            {
                number[i] = i + 1;
                var temp = number[i];
                var sum = 0;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                if (sum == 10)
                {
                    arrInts[index] = number[i];
                    index++;
                    if (index+1%12==0)
                        Console.WriteLine("\n");
                    else
                        Console.Write(number[i] + "\t");
                }
                if (index == 120)
                    break;
            }
        }

        static void Main()
        {
            Return();
            Console.ReadLine();
        }
    }
}
