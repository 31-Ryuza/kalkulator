using System;
using librarykal;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator +, -, x, :");
            Console.ReadLine();
            awal();
        }
        static void awal()
        {
            string pilih1;
            int pilihan;
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            try
            {
                Console.Write("Silahkan pilih jenis perhitungan yang diinginkan = ");
                pilihan = int.Parse(Console.ReadLine());
                if (pilihan == 1)
                {
                    try
                    {
                        Operasi jumlah = new Eksekusi();
                        jumlah.penjumlahan();
                    }
                    catch (FormatException)
                    {
                        string pilih;
                        Console.WriteLine("Maaf format yang harus diinputkan harus angka");
                        Console.Write("Ingin mengulangi lagi? (Y/N) =  ");
                        pilih1 = Console.ReadLine().ToLower();

                        if (pilih1 == "y")
                        {
                            Console.WriteLine("Enter Untuk Memulai Lagi");
                            Console.ReadLine();
                            awal();
                        }
                        else
                        {
                            Console.WriteLine("Terimakasih!");
                        }
                    }
                }
                else if (pilihan == 2)
                {
                    try
                    {
                        Operasi kurang = new Eksekusi();
                        kurang.pengurangan();
                    }
                    catch (FormatException)
                    {
                        string pilih;
                        Console.WriteLine("Maaf format yang harus diinputkan harus angka");
                        Console.Write("Ingin mengulangi lagi? (Y/N) =  ");
                        pilih1 = Console.ReadLine().ToLower();

                        if (pilih1 == "y")
                        {
                            Console.WriteLine("Enter Untuk Memulai Lagi");
                            Console.ReadLine();
                            awal();
                        }
                        else
                        {
                            Console.WriteLine("Terimakasih!");
                        }
                    }
                }
                else if (pilihan == 3)
                {
                    try
                    {
                        Class1 kali = new Class1();
                        kali.perkalian();
                    }
                    catch (FormatException)
                    {
                        string pilih;
                        Console.WriteLine("Maaf format yang harus diinputkan harus angka");
                        Console.Write("Ingin mengulangi lagi? (Y/N) =  ");
                        pilih1 = Console.ReadLine().ToLower();

                        if (pilih1 == "y")
                        {
                            Console.WriteLine("Enter Untuk Memulai Lagi");
                            Console.ReadLine();
                            awal();
                        }
                        else
                        {
                            Console.WriteLine("Terimakasih!");
                        }
                    }
                }
                else if (pilihan == 4)
                {
                    try
                    {
                        Class1 bagi = new Class1();
                        bagi.pembagian();
                    }
                    catch (FormatException)
                    {
                        string pilih;
                        Console.WriteLine("Maaf format yang harus diinputkan harus angka");
                        Console.Write("Ingin mengulangi lagi? (Y/N) =  ");
                        pilih1 = Console.ReadLine().ToLower();

                        if (pilih1 == "y")
                        {
                            Console.WriteLine("Enter Untuk Memulai Lagi");
                            Console.ReadLine();
                            awal();
                        }
                        else
                        {
                            Console.WriteLine("Terimakasih!");
                        }
                    }
                }
                Console.Write("Apakah anda mau menghitung lagi? (Y/N) =  ");
                pilih1 = Console.ReadLine().ToLower();

                if (pilih1 == "y")
                {
                    Console.WriteLine("Enter Untuk Memulai Lagi");
                    Console.ReadLine();
                    awal();
                }
                else
                {
                    Console.WriteLine("Terimakasih!");
                }
           }
            catch (FormatException)
            {
                string pilih;
                Console.WriteLine("Maaf format yang harus diinputkan harus angka");
                Console.Write("Ingin mengulangi lagi? (Y/N) =  ");
                pilih1 = Console.ReadLine().ToLower();

                if (pilih1 == "y")
                {
                    Console.WriteLine("Enter Untuk Memulai Lagi");
                    Console.ReadLine();
                    awal();
                }
                else
                {
                    Console.WriteLine("Terimakasih!");
                }
            }
        }
    }
}
