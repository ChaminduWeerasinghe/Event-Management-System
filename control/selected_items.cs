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
using System.Collections;

namespace InventorySystem.control
{
    public partial class selected_items : UserControl
    {


        SqlConnection con = Connect.conn();

        CustomerImpl cusI = new CustomerImpl();
        Customer customer = new Customer();

        private int cus;


        public selected_items()
        {
            InitializeComponent();
            showID();
        }




        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.dataTable2TableAdapter.Fill(this.selectedpackages_new.DataTable2);
                con.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.eventSellBindingSource.RemoveCurrent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventSellBindingSource.EndEdit();
            this.eventSellTableAdapter.Update(this.inventory2DataSet);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.eventSellTableAdapter.FillBy(this.inventory2DataSet.EventSell);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillBy(this.selectedpakages.DataTable1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.FillBy(this.selectedpakages.DataTable1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


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


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer.cusName = ID_combo.Text;
            int cusId = cusI.GetCustomerIDs(customer);

            ID_display.Text = cusId.ToString();

            if (!String.Equals(ID_display.Text, ""))
            {
                getPackageTotal();
                getSellTotal();

                try
                {

                    double pack = Double.Parse(lblSellTotal.Text);
                    double sell = Double.Parse(lblPackTotal.Text);

                    wholeTotal.Text = (pack + sell).ToString() + "0";
                }
                catch (Exception)
                {

                }
            }
            else
            {
                wholeTotal.Text = "0.00";
            }
        }

        private void getPackageTotal()
        {
            String sql = "select SUM(p.packprice) AS [totalPack] FROM cus_Event c, EventPack p WHERE c.evntID = p.eventid AND c.customerID = " + int.Parse(ID_display.Text) + "";
            SqlConnection con = Connect.conn();
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblPackTotal.Text = reader["totalPack"].ToString();
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }

        }


        private void getSellTotal()
        {
            String sql = "select SUM(itemPrice) AS [totalSell] FROM EventSell WHERE CustomerID = " + int.Parse(ID_display.Text) + "";

            SqlConnection con = Connect.conn();
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblSellTotal.Text = reader["totalSell"].ToString();
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
        }

 /*       public void search(string Stext)
        {
            try
            {

                con.Open();
                string sql = "Select * from EventSell where Name LIKE '%" + Stext + "%'";
                SqlDataAdapter aaa = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                aaa.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }*/

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //search(ID_combo.Text);
        
        }
    }
}
