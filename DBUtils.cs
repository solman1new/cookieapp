using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CookieApp
{
    public class DBUtils
    {

        public string loginUser;
        private string connString = "";

        /// <summary>
        /// Create for SQLConnection
        /// </summary>
        /// <param name="connString"></param>
        public DBUtils(string connString)
        {
            this.connString = connString;
        }

        public bool IsRowExist(string sqlQuery)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                var count = 0;

                while (reader.Read())
                    count++;

                reader.Close();

                if (count > 0)
                    return true;
            }

            return false;
        }

        public int IsRowExistAutorizatoin(string sqlQuery)
        {
            var count = 0;
            var flagAdmin = false;

            using (SqlConnection conn = new SqlConnection(this.connString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    if (reader.GetInt32(3) == 1)
                    {
                        flagAdmin = true;
                    }

                    count++;
                }

                reader.Close();
            }

            var response = 0;

            response += flagAdmin ? 1 : 0;
            response += count > 0 ? 1 : 0;

            return response;
        }

        public bool ToInsertQuery(string sqlQuery)
        {
            int stat = 0;
            using(SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                stat = cmd.ExecuteNonQuery();
            }
            return stat > 0 ? true : false;
        }

        public string GetConnectionString()
        {
            return this.connString;
        }

        //public ArrayList GetRowsQuery(string sqlQuery)
        //{
        //    ArrayList resultQueyr = new ArrayList();

        //    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, connectionMySQL)) 
        //    {
        //        connectionMySQL.Open();

        //        MySqlDataReader reader = cmd.ExecuteReader();

        //    }

        //    return resultQueyr;
        //}
    }
}
