using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using InventorySystem.supportiveClasses;
using System.Collections;

namespace InventorySystem.supportiveClasses
{
    class InsertPackage
    {
        public Boolean val;

        public void InsertEvent(int packid,String packname, double packprice,int cusID)
        {
            int eventid = Connect.AI("Eventpack", "eventid");
            SqlConnection con = Connect.conn();
            String sql = "Insert INTO Eventpack(eventid,packid,packname,packprice) VALUES(@eventid,@packid,@packname,@packprice) ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@packid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@packname", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@packprice", System.Data.SqlDbType.Real);

            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@packid"].Value = packid;
            cmd.Parameters["@packname"].Value = packname;
            cmd.Parameters["@packprice"].Value = packprice;


            int exec = cmd.ExecuteNonQuery();

            con.Close();

            if(exec == 1)
            {
                InsertCustomer(cusID,eventid);

            }
            else
            {
                val = false;
            }

        }

        private void InsertCustomer(int cusID,int eventid)
        {
       
            SqlConnection con = Connect.conn();
            String sql = "INSERT INTO cus_Event(evntID,customerID) VALUES(@eventid,@cusid)";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);

            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@cusid"].Value = cusID;


            int exec = cmd.ExecuteNonQuery();

            con.Close();

            if (exec == 1)
            {
                val = true;
            }
            else
            {
                val = false;
            }

        }




    }
}
