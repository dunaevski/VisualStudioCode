using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    class Program
    {
        static bool Polindrom(string number)
        {
            if (!long.TryParse(number, out var corrnumber)) return false;
            for (var i = 0; i <= number.Length; i++)
                return (number)[i].ToString() == (number)[number.Length - (i + 1)].ToString();
            return false;
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите число: ");
                var number = Console.ReadLine();
                if (Polindrom(number))
                    Console.WriteLine("Число " + number + " - полиндром");
                else
                    Console.WriteLine("Число " + number + " -  НЕ полиндром");
            } while (Console.ReadKey().Key != ConsoleKey.Spacebar);
        }
    }
}
