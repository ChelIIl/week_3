using System;
using System.IO;

namespace Zadanie_10_C
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create("C:\\Users\\Denis\\Desktop\\K2\\3.txt").Close();
            StreamWriter t_3 = new StreamWriter("C:\\Users\\Denis\\Desktop\\K2\\3.txt");
            StreamReader t = new StreamReader(@"C:\\Users\\Denis\\Desktop\\t1.txt");

            t_3.WriteLine(t.ReadToEnd());
            t.Close();

            t = new StreamReader(@"C:\\Users\\Denis\\Desktop\\t2.txt");

            t_3.WriteLine(t.ReadToEnd());
            t.Close();
            t_3.Close();
        }
    }
}
