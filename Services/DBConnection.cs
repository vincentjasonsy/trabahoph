using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabahoPH.Services
{
    public class DBConnection
    {
        private static MySqlConnection _myConn { get; set; }

        public static MySqlConnection MyConn
        {
            get
            {
                if (_myConn == null)
                {
                    string cs = @"server=localhost;userid=root;password=root;database=trabahoph";
                    _myConn = new MySqlConnection(cs);
                }

                return _myConn;
            }
        }

        //can be called for insert and update
        public static bool ExecuteQuery(string query)
        {
            try
            {
                MyConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, MyConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ooopss {e.Message}");
                return false;
            }
            finally
            {
                MyConn.Close();
            }
            return true;
        }

        public static MySqlConnection GetConnection()
        {
            if (_myConn == null)
            {
                string cs = @"server=localhost;userid=root;password=root;database=trabahoph";
                _myConn = new MySqlConnection(cs);
            }

            return _myConn;
        }

        public static void CloseConnection()
        {
            if (_myConn != null)
            {
                _myConn.Close();
            }
        }

        public static void OpenConnection()
        {
            if (_myConn != null)
            {
                _myConn.Open();
            }
        }
    }
}