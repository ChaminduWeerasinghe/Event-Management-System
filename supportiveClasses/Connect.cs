using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventorySystem.supportiveClasses
{
    class Connect
    {
        public static SqlConnection conn()
        {

            String connectionString = @"Data Source=msi\sqlexpress;Initial Catalog=Inventory2;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }

        public static int AI(String tblName, String primarykey)
        {
            int a, b, val = 0;
            String maxV = "0";

            SqlConnection con = conn();
            String sql = "select MAX("+primarykey+ ") AS[value] from  " + tblName+" ";

            SqlCommand cmd = new SqlCommand(sql,con);

            con.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    maxV = reader["value"].ToString();
                }
                reader.Close();

                val = Convert.ToInt32(maxV);
            }
            catch (Exception)
            {
                Console.WriteLine("No values in DB");
            }

                

                val++;
           
            return val;

        }

    }
}
