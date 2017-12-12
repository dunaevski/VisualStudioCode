using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Key
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ" +
                                                 " дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой" +
                                                 " Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть" +
                                                 " если особенно упорно подойдешь к делу" +
                                                 " будет Трудно конечнО" +
                                                 " Код ведЬ не из простых" +
                                                 " очень ХОРОШИЙ код" +
                                                 " то у тебя все получится" +
                                                 " и я буДу Писать тЕбЕ еще" +
                                                 " чао\n");
            string sbs = sb.ToString();
            Console.WriteLine(sbs);
            string text = " ";
            Regex regA = new Regex(@"\s[А-Я]\S*");
            foreach (var i in regA.Matches(sbs))
                text += i;
            string[] words = text.Split(' ');
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            

            Console.ReadLine();
        }
    }
}
