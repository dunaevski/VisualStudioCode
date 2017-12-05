using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>(5);
            dictionary.Add('a', "Russia");
            dictionary.Add('b', "USA");
            dictionary.Add('c', "qwe");
            dictionary.Add('d', "asd");

            foreach (KeyValuePair<char, string> elemKeyValuePair in dictionary)
            {
                Console.WriteLine(elemKeyValuePair.Key + " = " + elemKeyValuePair);
            }

            Console.WriteLine(dictionary['b']);
            dictionary['b'] = "Hello world";
            Console.WriteLine(dictionary['b']);
            dictionary.Remove('d');
            foreach (KeyValuePair<char, string> elemKeyValuePair in dictionary)
            {
                Console.WriteLine(elemKeyValuePair.Key + " = " + elemKeyValuePair);
            }


            Console.ReadLine();

        }
    }
}
