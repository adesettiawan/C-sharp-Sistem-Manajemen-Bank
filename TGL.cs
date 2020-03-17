using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemManajemenBank
{
    class TGL
    {
        public int hari;
        private int bulan;
        private int tahun;

        public void set(int d, int m, int y)
        {

            this.hari = d;
            this.bulan = m;
            this.tahun = y;

        }
        public bool cekTanggal()
        {
            if (hari > 31 || bulan > 12 || tahun > 2019)
            {
                Console.WriteLine("Tanggal Lahir tidak valid! ");
                return false;

            }
            else
                return true;

        }
        public bool tampilkanWaktu()
        {

            if (cekTanggal() == true)
            {
                Console.WriteLine("Tanggal Lahir : " + hari + "-" + bulan + "-" + tahun);
                return false;
            }
            else
                Console.WriteLine("Masukan Tanggal Lahir dengan benar!");
                return true;

        }
    }
}
