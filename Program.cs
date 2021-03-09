using System;

namespace Permulaannn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Input";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahann(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangann(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkaliann(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagiann(a, b));

            Console.WriteLine("\nTekan sembarang untuk keluar");
            Console.ReadKey();
        }
        static int Penambahann(int a, int b)
        {
            return a + b;
        }
        static int Pengurangann(int a, int b)
        {
            return a - b;
        }
        static int Perkaliann(int a, int b)
        {
            return a * b;
        }
        static int Pembagiann(int a, int b)
        {
            return a / b;
        }
    }
}
