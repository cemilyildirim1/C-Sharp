using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    internal class DbHelper
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=ogrenci_islemleri;Uid=root;Pwd=12345");
            return conn;
        }
    }
}
