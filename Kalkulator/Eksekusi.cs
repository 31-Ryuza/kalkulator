using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator
{
    class Eksekusi : Operasi
    {
        public override int penjumlahan()
        {
            int a, b, eksekusi;
            string ang_pertama, ang_kedua;
            Console.WriteLine("");
            Console.WriteLine("Penjumlahan");
            Console.WriteLine("~~~~~~~~~~~~");
            Console.Write("Masukkkan angka pertama = ");
            ang_pertama = Console.ReadLine();
            Console.Write("Masukkan angka ke dua = ");
            ang_kedua = Console.ReadLine();
            a = int.Parse(ang_pertama);
            b = int.Parse(ang_kedua);
            eksekusi = a + b;
            Console.WriteLine("Jumlah karakter angka pertama = " + ang_pertama.Length);
            Console.WriteLine("Jumlah karakter angka kedua = " + ang_kedua.Length);
            Console.WriteLine("Jadi hasil penjumlahan dari " + a + " + " + b + " adalah " + eksekusi);
            return eksekusi;
        }
        public override int pengurangan()
        {
            int a, b, eksekusi;
            string ang_pertama, ang_kedua;
            Console.WriteLine("");
            Console.WriteLine("Pengurangan");
            Console.WriteLine("~~~~~~~~~~~~");
            Console.Write("Masukkkan angka pertama = ");
            ang_pertama = Console.ReadLine();
            Console.Write("Masukkan angka ke dua = ");
            ang_kedua = Console.ReadLine();
            a = int.Parse(ang_pertama);
            b = int.Parse(ang_kedua);
            eksekusi = a - b;
            Console.WriteLine("Jumlah karakter angka pertama = " + ang_pertama.Length);
            Console.WriteLine("Jumlah karakter angka kedua = " + ang_kedua.Length);
            Console.WriteLine("Jadi hasil pengurangan dari " + a + " - " + b + " adalah " + eksekusi);
            return eksekusi;
        }
    }
}
