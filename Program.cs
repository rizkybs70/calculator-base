using System;

namespace Permulaann
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Flow Control";

            Console.Write("Pilih menu calculator: \n");
            Console.Write("1. Penambahan \n");
            Console.Write("2. Pengurangan \n");
            Console.Write("3. Perkalian \n");
            Console.Write("4. Pembagian \n");
            Console.Write("Input nomor menu [1-4] :");
            int opsi = int.Parse(Console.ReadLine());


            switch (opsi)
            {
                case 1:

                    Console.Write("Inputkan nilai a = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Penambahann(a, b));
                    break;

                case 2:
                    Console.Write("Inputkan nilai a = ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", c, d, Pengurangann(c, d));
                    break;

                case 3:
                    Console.Write("Inputkan nilai a = ");
                    int e = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", e, f, Perkaliann(e, f));
                    break;

                case 4:
                    Console.Write("Inputkan nilai a = ");
                    float g = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan nilai b = ");
                    float h = float.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", g, h, Pembagiann(g, h));
                    break;
                default:
                    Console.WriteLine("Maaf menu yang anda pilih salah\n");
                    break;

            }
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
        static float Pembagiann(float a, float b)
        {
            return a / b;
        }
    }
}
