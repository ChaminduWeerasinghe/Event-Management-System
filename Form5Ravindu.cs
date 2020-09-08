
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form5Ravindu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi\sqlexpress;Initial Catalog=Inventory2;Integrated Security=True");
        public Form5Ravindu()
        {
            InitializeComponent();
            FillCombo1();
            FillCombo2();
            FillCombo3();
        }

        void FillCombo1()
        {
            string que = "SELECT * from catering_Package";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    //special code
                    if (!comboBox1.Items.Contains(rd.GetString(1)))
                        comboBox1.Items.Add(rd.GetString(1));
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //changed
        void FillCombo2()
        {
            string que = "SELECT * from cus_cat_package";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBox2.Items.Add(rd.GetString(2));
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillCombo3()
        {
            string que = "SELECT * from cus_cat_package";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBox3.Items.Add(rd.GetString(2));
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM catering_Package where package_Name = '" + comboBox1.Text + "'", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }



        //changed












        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox3.Text != "")
            {
                con.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT price,Name FROM cus_cat_package WHERE Name = '" + comboBox3.Text + "'", con);
                DataTable dtb2 = new DataTable();
                sqlData.Fill(dtb2);
                dataGridView1.DataSource = dtb2;
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT DISTINCT package_Name,package_price,Appetizer,Rice,Curries,Devels,Dessert FROM catering_Package where package_Name = '" + comboBox1.Text + "'", con);
                // DataTable dtb2 = new DataTable();
                sqlDa.Fill(dtb2);
                dataGridView1.DataSource = dtb2;
                con.Close();

                //  MessageBox.Show("Select one at a time");
            }
            else if (comboBox1.Text != "")
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT DISTINCT package_Name,package_price,Appetizer,Rice,Curries,Devels,Dessert FROM catering_Package where package_Name = '" + comboBox1.Text + "'", con);
                //       SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT pack")
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
                con.Close();
            }
            else if (comboBox3.Text != "")
            {
                con.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM cus_cat_package WHERE Name = '" + comboBox3.Text + "'", con);
                DataTable dtb2 = new DataTable();
                sqlData.Fill(dtb2);
                dataGridView1.DataSource = dtb2;
                con.Close();
            }

            if (comboBox1.Text == "" && comboBox3.Text == "")
            {
                MessageBox.Show("You need to at least enter one box");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1Ravindu fm1 = new Form1Ravindu();
            fm1.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Select an Item and Enter a Price.");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Select an Item");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Enter the number needs to be updated");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE cus_cat_package SET price = '" + textBox4.Text + "' WHERE Name = '" + comboBox2.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string que = "SELECT package_Name,package_price,Appetizer,Rice,Curries,Devels,Dessert from catering_Package where package_Name = '" + comboBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
              //  MessageBox.Show("Deleted");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string que = "SELECT * from cus_cat_package where name = '" + comboBox2.Text + "'";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
         //       MessageBox.Show("Deleted");

                /*     while (rd.Read())
                     {
                         string price = rd.GetDouble(1).ToString();
                         textBox4.Text = price;
                     }*/

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string que = "SELECT * from cus_cat_package where name = '" + comboBox2.Text + "'";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
           //     MessageBox.Show("Deleted");

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1Ravindu fm1 = new Form1Ravindu();
            fm1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM catering_Package WHERE package_Name = '" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                //changed

                comboBox1.SelectedItem = null;
                MessageBox.Show("record successfully deleted");
            }

            if (comboBox3.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM cus_cat_package WHERE Name = '" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully deleted");
            }

            if (comboBox1.Text == "" && comboBox3.Text == "")
            {
                MessageBox.Show("At least an Item or a Package needs to be selected");
            }

            if (comboBox1.Text != "" && comboBox3.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM catering_Package WHERE package_Name = '" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully deleted");

                con.Open();
                SqlCommand c = con.CreateCommand();
                c.CommandType = CommandType.Text;
                c.CommandText = "DELETE FROM cus_cat_package WHERE Name = '" + comboBox1.Text + "'";
                c.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully deleted");
            }
        }
    }
}
