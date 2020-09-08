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
using InventorySystem.supportiveClasses;

namespace InventorySystem
{
    public partial class Form2maura : Form
    {
        SqlConnection con = Connect.conn();
        SqlCommand cmd;

        int recordId;
        int invoiceID = 0;

        public Form2maura()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Form1maura F1 = new Form1maura();
            this.Hide();
            F1.Show();
        }

        public void RundataGrid()
        {


            try
            {
                string sql = "SELECT invoiceNumber AS[INVOICE NUMBER], packageType AS[PACKAGE TYPE], packagePrice AS[PACKAGE PRICE], advance AS[ADVANCE], totalAmount AS[TOTAL AMMOUNT], purchaseDate AS[MONTH] FROM cusPayment WHERE customerID = " + int.Parse(ViewID.Text) + "";


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

        private void View_Click(object sender, EventArgs e)
        {
            RundataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                recordId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (e.RowIndex >= 0)
                {


                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    String ViewID = row.Cells["INVOICE NUMBER"].Value.ToString();

                    invoiceID = int.Parse(ViewID);

                    Console.WriteLine("Invoice Number : " + invoiceID);

                }
            }
            catch { }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete button Clicked");
            SqlConnection con = Connect.conn();
            String sql = "DELETE FROM cusPayment WHERE invoiceNumber = " + invoiceID + "";
            con.Open();



            SqlCommand cmd = new SqlCommand(sql, con);

            int Execute = cmd.ExecuteNonQuery();

            if (Execute == 1)
            {
                MessageBox.Show("Data Deleted Successfully!");
                RundataGrid();
            }
            else
            {
                MessageBox.Show("Try Again!!!");
            }

            con.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            SqlConnection con = Connect.conn();
            con.Open();
            cmd = new SqlCommand(" update cusPayment set packageType ='" + txt1.Text + "', packagePrice = '" + txt2.Text + "', advance = '" + txt3.Text + "', totalAmount = '" + txt4.Text + "',purchaseDate = '" + txt5.Text
                 + "' where  invoiceNumber = '" + recordId + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Records Have Updated Successfully !!!");
            con.Close();
            RundataGrid();

        }

        Bitmap bmp;




        private void Print_Click(object sender, EventArgs e)
        {

            Graphics grp = CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, grp);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Time.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void txt4_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt4.Text = (double.Parse(txt2.Text) - double.Parse(txt3.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
