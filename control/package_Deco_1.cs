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
    public partial class package_Deco_1 : UserControl
    {

        public package_Deco_1()
        {
            InitializeComponent();
            showID();

        }

        int packid;
        string Pname;
        string Pprice;

        Customer customer = new Customer();
        CustomerImpl cusI = new CustomerImpl();

        //////////////////////////////////////////////////////////////////Item-01/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label1_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[0]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox1.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[0]["packname"];
                        item1N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[0]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-02/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label2_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[1]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox2.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[1]["packname"];
                        item2N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[1]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-03/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label3_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[2]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox3.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[2]["packname"];
                        item3N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[2]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-04/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label4_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[3]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox4.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[3]["packname"];
                        item4N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[3]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-05/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label5_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[4]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox5.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[4]["packname"];
                        item5N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[4]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-06/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label6_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[5]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox6.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[5]["packname"];
                        item6N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[5]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-07/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label7_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[6]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox7.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[6]["packname"];
                        item7N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[6]["packprice"].ToString();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////Item-08/////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label8_TextChanged(object sender, EventArgs e)
        {


            try
            {

                SqlConnection con = Connect.conn();

                String sql = " select p.packname,p.packprice,I.img1 from InvtEventPack p,InvtEventImages I where I.packid = p.packid ";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {
                    byte[] data = (byte[])dt.Rows[7]["img1"];
                    MemoryStream ms = new MemoryStream(data);
                    pictureBox8.Image = Image.FromStream(ms);
                }

                Pname = "";
                Pprice = "";


                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        Pname = reader["packname"].ToString();
                        string x = (string)dt.Rows[7]["packname"];
                        item8N.Text = x;

                        Pprice = reader["packprice"].ToString();
                        string y = (string)dt.Rows[7]["packprice"].ToString();
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

        private void pack_1_moredetail_btn_Click(object sender, EventArgs e)
        {
            package_wedd_11.BringToFront();
        }

        private void package_wedd_11_Load(object sender, EventArgs e)
        {

        }
    }  
}
