using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace zeamart
{
    internal class Connections
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string sConnstring = "server = localhost;database= zeamart;uid=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
