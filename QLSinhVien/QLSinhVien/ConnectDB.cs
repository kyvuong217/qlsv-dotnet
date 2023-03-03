using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class ConnectDB
    {
        public static SqlConnection conn;

        public static bool openConnection()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=WINDOWS-10;Initial Catalog=QLSinhVien;Integrated Security=True");
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
