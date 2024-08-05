using System;
using System.Collections.Generic;

namespace DataKonsumen
{
    class Program
    {
        static List<Konsumen> konsumenList = new List<Konsumen>();

        static void Main(string[] args)
        {
            int pilihan;
            do
            {
                Console.WriteLine("=== Menu Konsol ===");
                Console.WriteLine("1. Input Data Konsumen");
                Console.WriteLine("2. Output Data Konsumen");
                Console.WriteLine("3. Searching Data Konsumen");
                Console.WriteLine("4. Keluar dari Aplikasi");
                Console.Write("Masukkan pilihan (1-4): ");
                
                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    switch (pilihan)
                    {
                        case 1:
                            InputDataKonsumen();
                            break;
                        case 2:
                            OutputDataKonsumen();
                            break;
                        case 3:
                            SearchingDataKonsumen();
                            break;
                        case 4:
                            Console.WriteLine("Keluar dari aplikasi.");
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid, silakan coba lagi.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid, silakan masukkan angka 1-4.");
                }
                Console.WriteLine();
            } while (pilihan != 4);
        }

        static void InputDataKonsumen()
        {
            Konsumen konsumen = new Konsumen();
            Console.Write("Masukkan nama: ");
            konsumen.Nama = Console.ReadLine();
            Console.Write("Masukkan alamat: ");
            konsumen.Alamat = Console.ReadLine();
            Console.Write("Masukkan nomor telepon: ");
            konsumen.NoTelepon = Console.ReadLine();
            konsumenList.Add(konsumen);
            Console.WriteLine("Data konsumen berhasil ditambahkan.");
        }

        static void OutputDataKonsumen()
        {
            Console.WriteLine("=== Daftar Konsumen ===");
            foreach (var konsumen in konsumenList)
            {
                Console.WriteLine($"Nama: {konsumen.Nama}, Alamat: {konsumen.Alamat}, No. Telepon: {konsumen.NoTelepon}");
            }
        }

        static void SearchingDataKonsumen()
        {
            Console.Write("Masukkan nama atau nomor telepon untuk mencari: ");
            string query = Console.ReadLine().ToLower();
            var hasil = konsumenList.FindAll(k => k.Nama.ToLower().Contains(query) || k.NoTelepon.Contains(query));

            if (hasil.Count > 0)
            {
                Console.WriteLine("=== Hasil Pencarian ===");
                foreach (var konsumen in hasil)
                {
                    Console.WriteLine($"Nama: {konsumen.Nama}, Alamat: {konsumen.Alamat}, No. Telepon: {konsumen.NoTelepon}");
                }
            }
            else
            {
                Console.WriteLine("Data konsumen tidak ditemukan.");
            }
        }
    }

    class Konsumen
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
    }
}
