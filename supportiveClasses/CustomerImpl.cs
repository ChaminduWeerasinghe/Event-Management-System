using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.supportiveClasses
{
    class CustomerImpl
    {
        private SqlConnection con = Connect.conn();
        public int GetCustomerIDs(Customer customer)
        {
            int CusID = 0;

            try
            {

                con.Open();

                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;

                command.CommandText = "Select CustomerID from customer where Name = @cusName";
                command.Parameters.AddWithValue("@cusName", customer.cusName);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CusID = reader.GetInt32(0);
                }
            }
            catch (SqlException e)
            {

            }
            finally
            {

                con.Close();
            }

            return CusID;
        }

        public ArrayList GetCustomerNames()
        {
            ArrayList fname = new ArrayList();
            con.Open();

            try
            {

                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select c.Name from customer as c";
//                command.Parameters.AddWithValue("@CustomerID", customer.cusid);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fname.Add(reader.GetString(0));

                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
            return fname;
        }
    }
}
