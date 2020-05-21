using System;
using System.IO;

namespace Zadanie_9_2_C
{
    class Program
    {
        static void Main()
        {
            StreamReader fs = new StreamReader("file.txt");
            string text = "";
            Console.WriteLine("В данном файле строки, имеющие пробел: ");
            while (true)
            {
                string temp = fs.ReadLine();               
                if (temp == null) break;
                text += temp;
                if (temp.Contains(' '))
                    Console.WriteLine(temp);
            }          
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
