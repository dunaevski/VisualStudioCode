using System;
/*
         Написать программу нахождения цифрового корня натурального числа. Цифровой корень данного числа 
         получается следующим образом. Если сложить все цифры этого числа, затем все цифры найденной суммы
         и повторять этот процесс, то в результате получится однозначное число, которое и называется цифровым 
         корнем данного числа.
 */
namespace for_while
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                var number = Console.ReadLine();
                if (long.TryParse(number, out var corrnumber))
                {
                    var sum = 0;
                    if (number != null)
                        for (var j = 0; j <= number.Length - 1; j++)
                            sum += int.Parse((number)[j].ToString());
                    Console.WriteLine("sum="+sum);
                    var result = sum % 10 + sum / 10;
                    Console.WriteLine("result="+result);
                    if (result / 10 > 0)
                    {
                        result = result % 10 + result / 10;
                        Console.WriteLine("result2="+result);
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("NENENENENENNE");
                    Console.ReadKey();
                }
            }
        }
    }
}