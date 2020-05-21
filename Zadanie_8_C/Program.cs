using System;
using System.Text.RegularExpressions;

namespace Zadanie_8_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;
            string s = "33,2 коровы гуляли по траве где было 115 травинки! Мурка, ты съела 1,33 травинки?";

            Regex n = new Regex(@"\d\w*,\w*e\S*|\d\w*,\w*|\d\w*");
            MatchCollection num = n.Matches(s);
            string str;
            
            for (int i = 0; i < num.Count; i++)
            {
                str = num[i].ToString();
                res += double.Parse(str);   
            }

            Console.WriteLine("Строка:" + s + "\n Сумма:" + res);
            Console.ReadKey();
        }
    }
}
