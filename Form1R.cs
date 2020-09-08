using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using InventorySystem.supportiveClasses;

namespace InventorySystem
//namespace ITP_Project
{

    public partial class Form1R : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=WeddingCreation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlConnection con = Connect.conn();

        String cid, Cname, Caddress, Ctelephone, Cmobile, Cemail, Cnic, Cgender;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            address.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Cgender = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (Cgender == "male")
            {
                male.Checked = true;
            }
            else if (Cgender == "female")
            {
                female.Checked = true;
            }
            nic.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            telephone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            mobile.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            email.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            Add_New ad = new Add_New();
            ad.Show();
            this.Hide();
        }

        private void SubmitBTN_Click_1(object sender, EventArgs e)
        {
            update();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchValue.Text == "CustomerID")
            {
                search("CustomerID", searchTxt.Text);
            }
            else if (searchValue.Text == "Name")
            {
                search("Name", searchTxt.Text);
            }
            else if (searchValue.Text == "NationalID")
            {
                search("NIC", searchValue.Text);
            }
            else if (searchValue.Text == "Mobile")
            {
                search("Mobile", searchTxt.Text);
            }

            else if (searchValue.Text == "Email")
            {
                search("Email", searchTxt.Text);
            }


        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDetReport csDetREp = new CustomerDetReport();
            csDetREp.Show();
        }

        public Form1R()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            panel2.Hide();
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {

        }

        public void update()
        {
            try
            {
                if (male.Checked == true)
                {
                    Cgender = "male";

                }
                else if (female.Checked == true)
                {
                    Cgender = "female";
                }

                con.Open();
                string sql = "UPDATE customer set Name = '" + name.Text + "',Address = '" + address.Text + "',Gender = '" + Cgender + "',Telephone = '" + telephone.Text + "',Mobile = '" + mobile.Text + "',Email = '" + email.Text + "' where CustomerID = '" + ID.Text + "'";
                SqlDataAdapter aaa = new SqlDataAdapter(sql, con);
                aaa.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");

                panel2.Hide();
            }
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            finally
            {
                con.Close();
            }
            loadData();
        }

        public void delete()
        {
            con.Open();
            string sql1 = "Delete from cus_Event where customerID = '" + ID.Text + "'";
            SqlDataAdapter bbb1 = new SqlDataAdapter(sql1, con);
            bbb1.SelectCommand.ExecuteNonQuery();
            con.Close();
            try
            {

                if (MessageBox.Show("Are you sure remove this?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string sql = "Delete from customer where customerID = '" + ID.Text + "'";
                    SqlDataAdapter bbb = new SqlDataAdapter(sql, con);
                    bbb.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            loadData();
        }


        public void loadData()
        {
            try
            {
                con.Open();
                String sql = "SELECT * FROM customer ";
                SqlDataAdapter SDA = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void search(string tableName, string Stext)
        {
            try
            {

                con.Open();
                string sql = "Select * from customer where " + tableName + " LIKE '%" + Stext + "%'";
                SqlDataAdapter aaa = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                aaa.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



    }
}
