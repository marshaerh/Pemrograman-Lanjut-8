using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sekolah_1814.KoneksiDB
{
    class Koneksi
    {
        private static SqlConnection koneksi;

        public static SqlConnection GetKoneksi()
        {
            koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=WINDOWS-8MM842K\\SQLEXPRESS;" +
                                       "Initial Catalog=Sekolah_1814;" +
                                       "Integrated Security=True";

            return koneksi;
        }
    }
}
