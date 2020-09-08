//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WindowsFormsApp1.supportiveClasses;


//namespace WindowsFormsApp1


//{
//    public partial class CustomerPayment : Form
//    {
//        int invoiceID = 0;
//        SqlConnection con = Connect.conn();
//        SqlCommand cmd;
//        int recordId;


//        public CustomerPayment()
//        {
//            InitializeComponent();
//        }

//        private void CustomerPayment_Load(object sender, EventArgs e)
//        {

//        }

//        public void RundataGrid()
//        {


//            try
//            {
//                String sql = "SELECT invoiceNumber AS[INVOICE NUMBER], packageType AS[PACKAGE TYPE], packagePrice AS[PACKAGE PRICE], advance AS[ADVANCE], totalAmount AS[TOTAL AMMOUNT], purchaseDate AS[MONTH] FROM customerPayment WHERE customerID = " + int.Parse(txtId.Text) + "";


//                DataTable dt = new DataTable();

//                con.Open();

//                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
//                adapter.Fill(dt);
//                dataGrid.DataSource = dt;
//            }
//            catch (Exception)
//            {

//            }

//            con.Close();
//        }

//        private void dataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {


//                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

//                String invID = row.Cells["INVOICE NUMBER"].Value.ToString();

//                invoiceID = int.Parse(invID);

//                Console.WriteLine("Invoice Number : " + invoiceID);

//            }
//        }
//        private void View_Click(object sender, EventArgs e)
//        {

//            RundataGrid();
//        }

//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            Console.WriteLine("Delete button Clicked");
//            SqlConnection con = Connect.conn();
//            String sql = "DELETE FROM customerPayment WHERE invoiceNumber = " + invoiceID + "";
//            con.Open();



//            SqlCommand cmd = new SqlCommand(sql, con);

//            int Execute = cmd.ExecuteNonQuery();

//            if (Execute == 1)
//            {
//                MessageBox.Show("Data Deleted Successfully!");
//                RundataGrid();
//            }
//            else
//            {
//                MessageBox.Show("Try Again!!!");
//            }

//            con.Close();
//        }

//        private void Back_Click(object sender, EventArgs e)
//        {
//            Payment p = new Payment();
//            this.Hide();
//            p.Show();
//        }


//        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            recordId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
//            txt1.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
//            txt2.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
//            txt3.Text = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
//            txt4.Text = dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
//            txt5.Text = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
//        }


//        private void txtUpdate_Click(object sender, EventArgs e)
//        {






//            SqlConnection con = Connect.conn();
//            con.Open();
//            cmd = new SqlCommand(" update customerPayment set packageType ='" + txt1.Text + "', packagePrice = '" + txt2.Text + "', advance = '" + txt3.Text + "', totalAmount = '" + txt4.Text + "',purchaseDate = '" + txt5.Text
//                 + "' where  invoiceNumber = '" + recordId + "'", con);
//            cmd.ExecuteNonQuery();
//            MessageBox.Show("Records Have Updated Successfully !!!");
//            con.Close();
//            RundataGrid();



//        }

//        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
//        {
//            e.Graphics.DrawImage(bmp, 0, 0);
//        }

//        Bitmap bmp;

//        private void Print_Click(object sender, EventArgs e)
//        {
//            Graphics grp = CreateGraphics();
//            bmp = new Bitmap(this.Size.Width, this.Size.Height, grp);
//            Graphics g = Graphics.FromImage(bmp);
//            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
//            printPreviewDialog1.ShowDialog();

//        }
//    }
//}
