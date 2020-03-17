using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemManajemenBank
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            TGL tgl = new TGL();
            ID id = new ID();
            Bank bn = new Bank();
            Console.WriteLine("****  Selamat Datang Di Sistem Pembuatan Akun Bank  ****");
            while (true)
            {
                Console.WriteLine("\nMasukan Pilihan Anda : ");
                Console.WriteLine("1. Buat Akun ");
                Console.WriteLine("2. Tampilkan Informasi Akun ");
                Console.WriteLine("3. Tampilkan Semua Akun Dengan Id ");
                Console.WriteLine("4. Hapus Layar ");
                Console.WriteLine("5. Keluar ");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);

                if (input == "1")
                {
                    Console.WriteLine("Masukan Jenis Akun :");
                    bn.buat_akun();

                }
                else if (input == "2")
                {
                    Console.Write("Masukan Id Akun : ");
                    bn.LihatInfo();
                }
                else if (input == "3")
                {
                    bn.TampilkanSemua();
                }
                else if (input == "4")
                {
                    Console.Clear();
                }
                else if (input == "5")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();


            }

        }

    }
}
