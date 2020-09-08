using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.supportiveClasses;
using System.Data.SqlClient;

namespace InventorySystem
{
    public partial class Finance : Form
    {
        private const string Caption = "Successful";
        String Sid;
        int ID;

        public Finance()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            sales();

            runDataGrid();

            btndel.Enabled = false;
            btnupdt.Enabled = false;

        }

        /*private void Sales()
        {
            throw new NotImplementedException();
        }*/

        private void btndel_Click(object sender, EventArgs e)
        {


            SqlConnection con = Connect.conn();
            String sql = "DELETE FROM finance WHERE id = ID";
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();

            int exec = cmd.ExecuteNonQuery();

            if (exec == 1)
            {
                MessageBox.Show("Successfully Deleted", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                runDataGrid();
                btndel.Enabled = false;
                btnupdt.Enabled = false;
                //btnprint.Enabled = false;

                txtother.Text = null;

            }


            con.Close();


        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];

                Sid = row.Cells["ID"].Value.ToString();

                ID = int.Parse(Sid);

                btndel.Enabled = true;
                btnupdt.Enabled = true;


            }
        }



        private void runDataGrid()
        {
            SqlConnection con = Connect.conn();

            //String sql = "SELECT * from finance";
            //String sql = "SELECT id[ID],sale[Sales],expences[Expences],profit[Profit],dte[Date] from finance";
            String sql = "SELECT id AS [ID], sale AS [SALE], expences AS [EXPENCES], profit AS [PROFIT] , dte AS [DATE] from finance";


            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;

            con.Close();

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();
            int id = Connect.AI("finance", "id");
            String sql = "INSERT INTO finance(id,sale,expences,profit) VALUES(@id,1200,600,@profit)";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            if (id == null)
            {
                id = 0;
            }
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@profit", System.Data.SqlDbType.Real);

            double getExpences = expences();
            string getSal = sales();

            cmd.Parameters["@id"].Value = id;
            cmd.Parameters["@profit"].Value = double.Parse(txttot.Text);



            int exec = cmd.ExecuteNonQuery();

            con.Close();

            if (exec == 1)
            {
                MessageBox.Show("Data Inserted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                runDataGrid();

            }

            if (exec == 1)
            {
                //Change this "Test" part as you need
                MessageBox.Show("Print balance sheet", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                runDataGrid();

            }


        }




        public void calcProfit()
        {
            String WaterBill = txtwater.Text;
            String ElectricityBill = txtelect.Text;
            String EmployeeSal = txtempsal.Text;
            String Catering = txtcatr.Text;
            String tax = txttax.Text;
            String otherExp = txtother.Text;


            double total = 0;

            if (WaterBill == null || String.Equals(WaterBill, ""))
            {
                WaterBill = "0.00";
            }

            if (ElectricityBill == null || String.Equals(ElectricityBill, ""))
            {
                ElectricityBill = "0.00";
            }

            if (EmployeeSal == null || String.Equals(EmployeeSal, ""))
            {
                EmployeeSal = "0.00";
            }

            if (Catering == null || String.Equals(Catering, ""))
            {
                Catering = "0.00";
            }

            if (otherExp == null || String.Equals(otherExp, ""))
            {
                otherExp = "0.00";
            }
            if (tax == null || String.Equals(tax, ""))
            {
                tax = "0.00";
            }


            total = (double.Parse(WaterBill) + double.Parse(ElectricityBill) + double.Parse(Catering) + double.Parse(EmployeeSal) + double.Parse(tax) + double.Parse(otherExp));
            txttot.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public double expences()
        {
            double expence = 0;
            String salExpence = "";
            String supExpence = "";

            SqlConnection con = Connect.conn();
            String sMonth = DateTime.Now.ToString("MM");
            String StrMonth = GetMonth(sMonth);
            Console.WriteLine("Month Name : " + StrMonth);
            String sql = "SELECT sum(Total_Salary) AS [totalsal] FROM Employee_Salary WHERE Salary_Month LIKE '" + StrMonth + "'";
            String sql2 = "SELECT sum(payment) AS [payment]	FROM supplierPayment WHERE paymentDate =  " + int.Parse(sMonth) + " ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlCommand cmd2 = new SqlCommand(sql2, con);

            con.Open();


            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    salExpence = reader["totalsal"].ToString();
                }
            }
            reader.Close();
            con.Close();


            con.Open();

            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    supExpence = reader2["payment"].ToString();
                }
            }

            reader2.Close();
            con.Close();

            if (String.Equals(salExpence, ""))
            {
                salExpence = "0.00";
            }
            if (String.Equals(supExpence, ""))
            {
                supExpence = "0.00";
            }


            expence = double.Parse(salExpence) + double.Parse(supExpence);

            //txtexp.Text = expence.ToString() + ".00";
            return expence;

        }


        public string sales()
        {
            String Sal = "";
            SqlConnection con = Connect.conn();
            String sMonth = DateTime.Now.ToString("MM");
            String sql = "SELECT sum(packagePrice) AS [sales] FROM customerPayment WHERE purchaseDate = " + int.Parse(sMonth) + "";
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Sal = reader["sales"].ToString();
                }
            }
            reader.Close();
            con.Close();

            if (String.Equals(Sal, "") || Sal == null)
            {
                Sal = "0.00";
            }

            //txtSale.Text = Sal;

            return Sal;
        }





        public string GetMonth(String month)
        {
            if (String.Equals("01", month))
            {
                return "January";
            }
            else if (String.Equals("02", month))
            {
                return "February";
            }
            else if (String.Equals("03", month))
            {
                return "March";
            }
            else if (String.Equals("04", month))
            {
                return "April";
            }
            else if (String.Equals("05", month))
            {
                return "May";
            }
            else if (String.Equals("06", month))
            {
                return "June";
            }
            else if (String.Equals("07", month))
            {
                return "July";
            }
            else if (String.Equals("08", month))
            {
                return "August";
            }
            else if (String.Equals("09", month))
            {
                return "September";
            }
            else if (String.Equals("10", month))
            {
                return "October";
            }
            else if (String.Equals("11", month))
            {
                return "November";
            }
            else if (String.Equals("12", month))
            {
                return "December";
            }
            else if (month == null)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        private void tax_changed(object sender, EventArgs e)
        {
            //calcProfit();
        }

        private void other_changed(object sender, EventArgs e)
        {

        }

        private void txtexp_Click(object sender, EventArgs e)
        {



        }

        private void txtother_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }

        private void txtwater_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }

        private void txtelect_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }

        private void txtcatr_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }

        private void txtempsal_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }

        private void txttax_TextChanged(object sender, EventArgs e)
        {
            calcProfit();
        }


        private void btnupdt_Click_1(object sender, EventArgs e)
        {

            String sql = "UPDATE finance SET sale = 1800,expences = 400,profit = " + txttot.Text + " WHERE id = " + ID + "";
            SqlConnection con = Connect.conn();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);


            int exec = cmd.ExecuteNonQuery();

            if (exec == 1)
            {
                MessageBox.Show("Updated Successfully", Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                runDataGrid();
                btndel.Enabled = false;
                btnupdt.Enabled = false;
                //btnprint.Enabled = false;

                txtother.Text = null;
            }
        }
    }
}











