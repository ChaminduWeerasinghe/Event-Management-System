using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InventorySystem.supportiveClasses;

namespace InventorySystem
{
    public partial class Form1maura : Form
    {
        SqlConnection con = Connect.conn();
        SqlCommand cmd;

        int invoiceID = 0;
        int recordId;
        int inv = 1;
        String inv2;

        public Form1maura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customerPaymentTableAdapter.Fill(this.inventoryDataSet.customerPayment);

            txtInv.Text = Connect.AI("cusPayment", "invoiceNumber").ToString();

            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            RundataGrid();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        public void RundataGrid()
        {


            try
            {
                String sql = "SELECT customerID AS[CUSTOMER ID], packageType AS[PACKAGE TYPE], packagePrice AS[PACKAGE PRICE], advance AS[ADVANCE], totalAmount AS[TOTAL AMMOUNT], purchaseDate AS[MONTH] FROM cusPayment ";


                DataTable dt = new DataTable();

                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

            }

            con.Close();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            try
            {



                con.Open();
                cmd = new SqlCommand("insert into cusPayment values(" + int.Parse(txtInv.Text) + "," + int.Parse(txtId.Text) + ",'" + txtTyp.Text + "'," + double.Parse(txtPrice.Text) + "," + double.Parse(txtAdv.Text) + "," + double.Parse(txtBal.Text) + ",'" + txtMonth.Text + "')", con);
                int exec = cmd.ExecuteNonQuery();

                if (exec == 1)
                {
                    MessageBox.Show(" Data Have Successfully Inserted Successful");
                }
                else
                {
                    MessageBox.Show(" Error ! ");
                }
                con.Close();
                RundataGrid();




            }
            catch
            {

            }

        }

        private void NextB_Click(object sender, EventArgs e)
        {
            Form2maura F2 = new Form2maura();
            this.Hide();
            F2.Show();
        }

        private void txtAdv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBal.Text = (int.Parse(txtPrice.Text) - int.Parse(txtAdv.Text)).ToString();
            }
            catch
            {

            }
        }

        private void txtTyp_TextChanged(object sender, EventArgs e)
        {

            txtTyp.Text = (comb1.Text).ToString();
        }

        private void comb2_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMonth.Text = (comb2.Text).ToString();
        }
    }
}
