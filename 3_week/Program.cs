using System;
using System.Text;

namespace _3_week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Что заменять:");
            string substr1 = Console.ReadLine();

            Console.Write("На что заменять:");
            string substr2 = Console.ReadLine();

            Console.Write("Введите текст:");
            StringBuilder t = new StringBuilder(Console.ReadLine());

            t = t.Replace(substr1, substr2);

            Console.WriteLine("\n" + t);
            Console.ReadKey();
        }
    }
}
