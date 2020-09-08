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
    public partial class PackageMenu : Form
    {
        private packInsert packIns;
        private InvPackageUpdate invPackageUpdate;

        int packID;
        String StrpackID;
        String StrpackPrice;
        String StrpackName;

        public PackageMenu()
        {
            InitializeComponent();
        }

        private void PackageMenu_Load(object sender, EventArgs e)
        {
            runDataGrid();
        }

        public void runDataGrid()
        {
            SqlConnection con = Connect.conn();
            String sql = " SELECT packid AS [PACKAGE ID], packprice AS [PACKAGE PRICE], packname AS [PACKAGE NAME] FROM InvtEventPack";

            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            dataGridPackage.DataSource = dt;

            con.Close();


        }


        private void dataGridPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridPackage.Rows[e.RowIndex];

                StrpackID = row.Cells["PACKAGE ID"].Value.ToString();

                txtPackID.Text = StrpackID;

            }
        }

        private void packID_changed(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();

            try
            {

                String sql = " SELECT packname,packprice  FROM InvtEventPack WHERE packid = " + int.Parse(txtPackID.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StrpackName = reader["packname"].ToString();
                        StrpackPrice = reader["packprice"].ToString();
                    }

                    txtPackName.Text = StrpackName;
                    txtPrice.Text = StrpackPrice + ".00";

                }

            }
            catch (Exception)
            {

            }

            con.Close();
        }

        private void txtPackName_changed(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();

            try
            {

                String sql = " SELECT packid,packprice  FROM InvtEventPack WHERE packname LIKE '" + txtPackName.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        StrpackID = reader["packid"].ToString();
                        StrpackPrice = reader["packprice"].ToString();
                    }

                    txtPackID.Text = StrpackID;
                    txtPrice.Text = StrpackPrice + ".00";

                }

            }
            catch (Exception)
            {

                txtPackID.Text = "";
                txtPrice.Text = StrpackPrice + "";
            }

            con.Close();
        }




        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (packIns == null)
            {
                packIns = new packInsert();
            }
            ObjectHolder.packMenu = this;
            this.Hide();
            packIns.Show();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!String.Equals(txtPackID.Text, "") || txtPackID.Text == null)
            {
                DialogResult result = MessageBox.Show("Do you Really Want to Delete Package  " + txtPackName.Text + " (Package id : " + txtPackID.Text + " ) ", "DO you Want to Delete..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = Connect.conn();
                    String sql = "DELETE FROM InvtEventImages WHERE packid = " + int.Parse(txtPackID.Text) + "";
                    String sql2 = "DELETE FROM InvtEventPack WHERE packid = " + int.Parse(txtPackID.Text) + "";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlCommand cmd2 = new SqlCommand(sql2, con);

                        int exec = cmd.ExecuteNonQuery();
                        int exec2 = cmd2.ExecuteNonQuery();


                        if (exec == 1 && exec2 == 1)
                        {
                            MessageBox.Show("Successfully DELETED", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            runDataGrid();
                            clearAll();
                        }
                        else if (exec != 1 && exec2 == 1)
                        {
                            MessageBox.Show("Successfull but No Images Deleted or Images Doent have correspond to this Package", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            runDataGrid();
                            clearAll();
                        }
 
                    else
                    {
                        MessageBox.Show("Check Database is Connected", "Unknown Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Package that you Want to Delete From Table or Type Package ID of it", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            }
            catch (Exception)
            {
                MessageBox.Show("Item That You Tring to Delete is Used in Another Section of this Company", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void clearAll()
        {
            txtPackID.Text = "";
            txtPackName.Text = "";
            txtPrice.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (invPackageUpdate == null)
            {
                invPackageUpdate = new InvPackageUpdate();
            }
            ObjectHolder.packMenu = this;
            this.Hide();
            invPackageUpdate.Show();
        }

        private void hme_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;

            mainM.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            InventoryMenu inventoryM = ObjectHolder.inventoryMainMenu;
            inventoryM.Show();
            this.Hide();
        }
    }
}
