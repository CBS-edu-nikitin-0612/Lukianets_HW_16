using System;
using System.Text;

namespace AdditionalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["ноутбук"]);
        }
    }
}
