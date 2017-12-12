using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запись файла
            System.IO.File.WriteAllText("test.txt", "Тут что-то!");
            // Путь записи файла
            Console.WriteLine(Environment.CurrentDirectory);
            // Пусть относительно текущей директории
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
            // Сформировать абсолютный путь по оносительному 
            Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "test.txt"));
            System.IO.File.WriteAllLines("test1.txt", new []{"Привет!", "Как дела?"});
            System.IO.File.WriteAllBytes("test3.dat", new byte[10420]);
            string text = System.IO.File.ReadAllText("test.txt");
            Console.WriteLine("Содержимое файла {0}",text);
            string[] lines = System.IO.File.ReadAllLines("test1.txt");
            foreach (var VARIABLE in lines)
                Console.WriteLine(VARIABLE);
            byte[] bytes = System.IO.File.ReadAllBytes("test3.dat");
            foreach (var VARIABLE in bytes)
                Console.Write(VARIABLE);
            // Вывести всей файлы из текущей директории
            foreach (var VARIABLE in Directory.GetFiles("."))
                Console.WriteLine(VARIABLE);
            Console.ReadKey();
        }
    }
}
