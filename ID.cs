using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemManajemenBank
{
    class ID
    {
        static int id = 0;
        string tokoId;
        DateTime Tanggal = DateTime.Now;

        public string HasilId()
        {
            string gid = DateTime.Now.ToString("yyyy-MM-");
            tokoId = gid + ++id;

            return tokoId;

        }

    }
}
