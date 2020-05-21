using System;
using System.Text;
using System.IO;


namespace Zadanie_9_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кол-во чисел:");
            int n = int.Parse(Console.ReadLine());
            double r;
            double num;

            FileStream file = new FileStream("te.dat", FileMode.Open);
            BinaryWriter Ofile = new BinaryWriter(file);

            for (int i = 0; i < n; i++)
            {
                Ofile.Write(double.Parse(Console.ReadLine()));
            }

            Ofile.Close();

            file = new FileStream("te.dat", FileMode.Open);
            BinaryReader Rfile = new BinaryReader(file);

            long l = file.Length;

            Console.Write("Меньше числа:");
            num = double.Parse(Console.ReadLine());

            for (long i = 8; i < l; i+=16)
            {
                file.Seek(i, SeekOrigin.Begin);
                r = Rfile.ReadDouble();
                if(r < num)
                    Console.WriteLine(r + " ");
            }

            Rfile.Close();
            file.Close();

            Console.ReadKey();
        }
    }
}
