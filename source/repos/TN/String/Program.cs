using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа со строками");
            string str1 = "Я изучаю язык программирования C#";
            string str2 = "Hello " + "World!!!";
            string str3 = "";
            Console.WriteLine("Строка str1: {0}", str1);
            Console.WriteLine("Строка str2: {0}", str2);
            if (string.IsNullOrEmpty(str3) == true)
            {
                Console.WriteLine("Строка str3 - пустая");
            }
            else
                Console.WriteLine("Строка str3: {0}", str3);
            //Сравнивание строк
            Console.WriteLine("Сравнение строк");
            Console.WriteLine(string.Compare("aaa", "bbb"));
            Console.WriteLine(string.Compare("aaa", "aaa"));
            Console.WriteLine(string.Compare("bbb", "aaa"));
            if (string.Compare("aaa", "Aaa", true) == 0)//true - игнор регистра
            {
                Console.WriteLine("Строки одинаковые");
            }
            //Поиск подстроки
            Console.WriteLine("Поиск подстроки");
            if (str1.Contains("язык"))
                Console.WriteLine("Строка {0} содержит подстроку \"язык\"", str1);
            Console.WriteLine("Индекс символа \"я\" в строке str1 = " + str1.IndexOf("я"));
            if (str2.StartsWith("Hell"))
            {
                Console.WriteLine("Да это жостка");
            }
            Console.WriteLine(str2.Insert(5, " this"));//Добавление в строку
            str3 = "Привет всем!";
            Console.WriteLine(str3.Replace("всем", "каждому"));//Замена
            Console.WriteLine(str3);
            //Удаление
            Console.WriteLine(str3.Remove(9));//Удаление с 9 индекса от 0
            Console.WriteLine(str1.Substring(14, 16));//Страт с 0. с 14 индекса и кол-во символов
            string str4 = str2.ToUpper();//Все заглавные
            Console.WriteLine(str4);
            //Преобразование строки символов
            Char[] arr = str4.ToCharArray();//Преобразует в массив
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            string[] arr1 = str1.Split(' ');//Разделяем пробелами
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
            string str5 = string.Concat("231", " и ", "341");
            Console.WriteLine(str5);
            string str6 = string.Copy(str2);//Копирует строку
            Console.WriteLine(str6);
            if (str6.Equals(str2))
            {
                Console.WriteLine("str6 = str2");
            }
            Console.ReadLine();

        }
    }
}
