using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemManajemenBank
{
    class Bank
    {
        string id;
        public int idnum = 0;

        public string[] myId = new string[100];
        public string[] myName = new string[100];
        public string[] TipeAcc = new string[100];
        public string[] ttl = new string[100];
        public string[] panggilan = new string[100];
        public double[] saldoku = new double[100];
        public double saldomaks = 1000000;
        public double saldomin = 200000;

        ID Id = new ID();
        TGL tgl = new TGL();
        public bool nilai = true;
        public bool deb_nilai = true;

        private void hasilAcc(string ID)
        {
            ID = this.id;
            myId[idnum] = ID;
            idnum++;

        }
        public void TampilkanSemua()
        {
            Console.WriteLine("Semua Akun Adalah :\n");
            for (int i = 0; i < idnum; i++)
            {
                Console.WriteLine(myId[i]);

            }
        }

        public void LihatInfo()
        {
            int indeksNomor;
            string inId = Convert.ToString(Console.ReadLine());
            if (myId.Contains(inId))
            {
                indeksNomor = Array.IndexOf(myId, inId);
                Console.WriteLine("Identitas Anda : ");
                Console.WriteLine("Nama           : " + myName[indeksNomor]);
                Console.WriteLine("Id             : " + myId[indeksNomor]);
                Console.WriteLine("Tipe Akun      : " + TipeAcc[indeksNomor]);
                Console.WriteLine("Tanggal Lahir  : " + ttl[indeksNomor]);
                Console.WriteLine("Nama Panggilan : " + panggilan[indeksNomor]);
                Console.WriteLine("Saldo Anda     : " + saldoku[indeksNomor]);
            }
            else
            {
                Console.WriteLine("Id anda salah!");
            }


        }

        public void buat_akun()
        {

            string typeacc;
            string name;
            int d, m, y;
            string pgl;
            double saldo;
            string input;
            Console.WriteLine("1. Akun Debit");
            Console.WriteLine("2. Akun Kredit");
            Console.WriteLine("3. Akun Rekening Tabungan");
            object ob1 = Console.ReadLine();
            input = Convert.ToString(ob1);

            if (input == "1")
            {

                typeacc = "Debit";
                TipeAcc[idnum] = typeacc;
                Console.Write("Nama : ");

                name = Convert.ToString(Console.ReadLine());
                myName[idnum] = name;

                while (nilai == true)
                {
                    Console.WriteLine("Masukan Tanggal Lahir : ");

                    d = Convert.ToInt32(Console.ReadLine());
                    m = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    tgl.set(d, m, y);
                    if (tgl.tampilkanWaktu() == false)
                    {
                        ttl[idnum] = Convert.ToString(d + "/" + m + "/" + y);
                        nilai = false;
                    }
                    else nilai = true;
                }
                nilai = true;
                Console.WriteLine("Masukan Nama Panggilan : ");
                pgl = Convert.ToString(Console.ReadLine());
                panggilan[idnum] = pgl;
                while (deb_nilai == true)
                {
                    Console.WriteLine("Masukan Saldo Akun : ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    if (saldo > saldomaks)
                    {
                        Console.WriteLine("Saldo maksimal Akun Debit adalah 1000000!");
                        deb_nilai = true;
                    }
                    else if (saldo < saldomin)
                    {
                        Console.WriteLine("Saldo minimal Akun Debit adalah 200000!");
                    }
                    else
                    {
                        saldoku[idnum] = saldo;
                        deb_nilai = false;
                    }
                }
                deb_nilai = true;
                Console.WriteLine("Akun Debit berhasil dibuat...! ");
                id = Id.HasilId();
                id = id + "Dbt";
                Console.WriteLine("Id Akun Anda : " +id);
                hasilAcc(id);

            }
            else if (input == "2")
            {
                typeacc = "Kredit";
                TipeAcc[idnum] = typeacc;
                Console.Write("Nama : ");
                name = Convert.ToString(Console.ReadLine());
                myName[idnum] = name;
                while (nilai == true)
                {
                    Console.WriteLine("Masukan Tanggal Lahir : ");

                    d = Convert.ToInt32(Console.ReadLine());
                    m = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    tgl.set(d, m, y);
                    if (tgl.tampilkanWaktu() == false)
                    {
                        ttl[idnum] = Convert.ToString(d + "-" + m + "-" + y);
                        nilai = false;
                    }
                    else nilai = true;
                }
                nilai = true;
                Console.WriteLine("Masukan Nama Panggilan : ");
                pgl = Convert.ToString(Console.ReadLine());
                panggilan[idnum] = pgl;
                while (deb_nilai == true)
                {
                    Console.WriteLine("Masukan Saldo Akun : ");
                    saldo = Convert.ToDouble(Console.ReadLine());
                    if (saldo < saldomin)
                    {
                        Console.WriteLine("Nilai minimal Kredit Akun adalah 100000!");
                        deb_nilai = true;
                    }
                    else
                    {
                        saldoku[idnum] = saldo;
                        deb_nilai = false;
                    }
                }
                deb_nilai = true;
                Console.WriteLine("Akun Kredit berhasil dibuat...! ");
                id = Id.HasilId();
                id = id +"Crd";
                Console.WriteLine("Id Akun Anda : " + id);
                hasilAcc(id);

            }
            else if (input == "3")
            {
                typeacc = "Rekening Tabungan";
                TipeAcc[idnum] = typeacc;
                Console.Write("Nama : ");

                name = Convert.ToString(Console.ReadLine());
                myName[idnum] = name;
                while (nilai == true)
                {
                    Console.WriteLine("Masukan Tanggal Lahir : ");

                    d = Convert.ToInt32(Console.ReadLine());
                    m = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                    tgl.set(d, m, y);
                    if (tgl.tampilkanWaktu() == false)
                    {
                        ttl[idnum] = Convert.ToString(d + "-" + m + "-" + y);
                        nilai = false;
                    }
                    else nilai = true;
                }
                nilai = true;
                Console.WriteLine("Masukan Nama Panggilan : ");
                pgl = Convert.ToString(Console.ReadLine());
                panggilan[idnum] = pgl;
                Console.WriteLine("Masukan Saldo Akun : ");
                saldo = Convert.ToDouble(Console.ReadLine());
                saldoku[idnum] = saldo;
                Console.WriteLine("Akun Rekening Tabungan berhasil dibuat...! ");
                id = Id.HasilId();
                id = id +"Sav";
                Console.WriteLine("Id Akun Anda : " + id);
                hasilAcc(id);

            }


       }
   }
}

