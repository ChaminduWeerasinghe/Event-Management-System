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
using InventorySystem.supportiveClasses;
using System.IO;
using System.Collections;

namespace InventorySystem.control
{
    public partial class item_wedd : UserControl
    {

        public item_wedd()
        {
            InitializeComponent();
            showID();

        }

        int eventid;
        string iname;
        string iprice;

        Customer customer = new Customer();
        CustomerImpl cusI = new CustomerImpl();

        //////////////////////////////////////////////////////////////////Item-01/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label1_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[0]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[0]["iname"];
                        item1N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[0]["iprice"].ToString();
                        item1price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange1.RangeMax;
            range1.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-02/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label2_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[1]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox2.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[1]["iname"];
                        item2N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[1]["iprice"].ToString();
                        item2price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange2_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange2.RangeMax;
            range2.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-03/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label3_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[2]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox3.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[2]["iname"];
                        item3N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[2]["iprice"].ToString();
                        item3price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange3_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange3.RangeMax;
            range3.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-04/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label4_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[3]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox4.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[3]["iname"];
                        item4N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[3]["iprice"].ToString();
                        item4price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange4_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange4.RangeMax;
            range4.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-05/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label5_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[4]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox5.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[4]["iname"];
                        item5N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[4]["iprice"].ToString();
                        item5price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange5_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange5.RangeMax;
            range5.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-06/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label6_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[5]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox6.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[5]["iname"];
                        item6N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[5]["iprice"].ToString();
                        item6price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange6_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange6.RangeMax;
            range6.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-07/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label7_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[6]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox7.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[6]["iname"];
                        item7N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[6]["iprice"].ToString();
                        item7price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange7_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange7.RangeMax;
            range7.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-08/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label8_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select iprice,iname,img from InvtEventSell ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[7]["img"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox8.Image = Image.FromStream(ms);
                }

                iname = "";
                iprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        iname = reader["iname"].ToString();
                        string x = (string)dt.Rows[7]["iname"];
                        item8N.Text = x;

                        iprice = reader["iprice"].ToString();
                        string y = (string)dt.Rows[7]["iprice"].ToString();
                        item8price.Text = y;

                    }

                    reader.Close();


                    //lb_wed_item1.Text = iname;


                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }

        private void bunifuRange8_RangeChanged(object sender, EventArgs e)
        {

            int i = bunifuRange8.RangeMax;
            range8.Text = i.ToString();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void item_wedd_Load(object sender, EventArgs e)
        {

        }

        private void item1price_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            insertInventory("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///////////////////////////////////////////////////////////////////Insert/////////////////////////////////////////////////////////////////////////////////////////

        public void insertInventory(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item1price.Text);
            cmd.Parameters["@itemName"].Value = item1N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range1.Text);
            cmd.Parameters["@itemCode"].Value = 001;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;

            



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            insertInventory2("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            insertInventory3("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            insertInventory4("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            insertInventory5("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            insertInventory6("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            insertInventory7("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            insertInventory8("Insert into EventSell(eventid,itemCode,itemPrice,itemName,itemAmmt,CustomerID) Values(@eventid,@itemCode,@itemPrice,@itemName,@itemAmmt,@cusid)", "insert");
            MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void insertInventory2(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item2price.Text);
            cmd.Parameters["@itemName"].Value = item2N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range2.Text);
            cmd.Parameters["@itemCode"].Value = 002;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory3(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item3price.Text);
            cmd.Parameters["@itemName"].Value = item3N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range3.Text);
            cmd.Parameters["@itemCode"].Value = 003;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory4(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item4price.Text);
            cmd.Parameters["@itemName"].Value = item4N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range4.Text);
            cmd.Parameters["@itemCode"].Value = 004;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory5(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item5price.Text);
            cmd.Parameters["@itemName"].Value = item5N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range5.Text);
            cmd.Parameters["@itemCode"].Value = 005;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory6(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item6price.Text);
            cmd.Parameters["@itemName"].Value = item6N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range6.Text);
            cmd.Parameters["@itemCode"].Value = 006;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory7(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item7price.Text);
            cmd.Parameters["@itemName"].Value = item7N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range7.Text);
            cmd.Parameters["@itemCode"].Value = 007;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void insertInventory8(String qry, String type)
        {
            if (String.Equals(type, "insert"))
            {
                eventid = Connect.AI("EventSell", "eventid"); //auto increment code
            }
            SqlConnection con = Connect.conn();


            String sql = qry;
            con.Open();


            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@eventid", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemCode", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@itemPrice", System.Data.SqlDbType.Real);
            cmd.Parameters.Add("@itemName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@itemAmmt", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@cusid", System.Data.SqlDbType.Int);


            cmd.Parameters["@eventid"].Value = eventid;
            cmd.Parameters["@itemPrice"].Value = double.Parse(item8price.Text);
            cmd.Parameters["@itemName"].Value = item8N.Text;
            cmd.Parameters["@itemAmmt"].Value = int.Parse(range8.Text);
            cmd.Parameters["@itemCode"].Value = 008;
            cmd.Parameters["@cusid"].Value = fname_txt.Text;



            int execute = cmd.ExecuteNonQuery();
            con.Close();

            if (execute == 1)
            {
                MessageBox.Show("        ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        /////////get customers ///// 
        ///

        public void showID()
        {
            ArrayList arr = new ArrayList();
            arr = cusI.GetCustomerNames();

            ID_combo.Items.Clear();

            foreach (string line in arr)
            {
                ID_combo.Items.Add(line);
            }
        }

        private void ID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer.cusName = ID_combo.Text;
            int cusId = cusI.GetCustomerIDs(customer);

            fname_txt.Text = cusId.ToString();

        }



        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
