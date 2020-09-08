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
using System.IO;

namespace InventorySystem
{
    public partial class EventForm : Form
    {
        int quant,ino,reqid,eventid;
        String squant, sprice, snme, sno, seventid;
        double fee;
        object borrower;
        DataGridViewCellEventArgs ea;
        String imglocation = "";
        Boolean rslt;


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemNo.Text != null && txtName2.Text != null && txtName2.Text != null && txtStockCnt2.Text != null && picBx.Image != null)
                {
                    insertInventory("UPDATE InvtEventSell SET iprice = @price, iname = @name, stckcnt = @cnt, img = @imge WHERE itemCode = @code", "update");


                }
                else if (picBx.Image == null)
                {
                    DialogResult result = MessageBox.Show("You are not Insert an Image. Do you need to Keep the items without image..?", "Image is not Inserted....!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        insertInventory("UPDATE InvtEventSell SET iprice = @price, iname = @name, stckcnt = @cnt WHERE itemCode = @code", "update");

                    }

                }
                else
                {
                    MessageBox.Show("Please insert Data or Mark Item From Table        ", "No Data Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception)
            {
                MessageBox.Show("Pleasse Check Wather Data that your Entered is Correct", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }

        }

        //Insert Click Event
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.Equals(txtItemNo2.Text, "") && !String.Equals(txtName2.Text, "") && !String.Equals(txtPrice2.Text, ""))
                {
                    if (checkAvailability("SELECT itemCode FROM InvtEventSell WHERE iname LIKE '%" + txtName2.Text + "'") == true)
                    {
                        DialogResult dialog = MessageBox.Show("Do You Want to Insert " + snme + " as Item Number   And   " + sprice + " as Item Price", "Data Found Same as '" + snme + "'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialog == DialogResult.Yes)
                        {
                            if (picBx.Image == null)
                            {
                                MessageBox.Show("                  ", "Please Add the Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                insertInventory("Insert into InvtEventSell(itemCode,iprice,iname,stckcnt,img) Values(@code,@price,@name,@cnt,@imge)", "insert");

                            }
                        }

                    }
                    else
                    {
                        if (picBx.Image != null)
                        {
                            insertInventory("Insert into InvtEventSell(itemCode,iprice,iname,stckcnt,img) Values(@code,@price,@name,@cnt,@imge)", "insert");
                        }
                        else
                        {
                            MessageBox.Show("           ", "Please Add Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Data to Fill the Fileds ", "Cannot Keep Fields Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception)
            {
                MessageBox.Show("Please check Data ThatYou Entered is Correct", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtItemNo2_MouseHover(object sender, EventArgs e)
        {
            txtItemNo2.ReadOnly = false;
        }

        private void InventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.InventoryDataGrid.Rows[e.RowIndex];

                txtItemNo2.Text = row.Cells["ITEM CODE"].Value.ToString();
                sno = row.Cells["ITEM CODE"].Value.ToString();

            }



        }
        //Insert Part
        public void insertInventory(String qry,String type)
        {
            try
            {
                if (String.Equals(type, "insert"))
                {
                    reqid = Connect.AI("InvtEventSell", "ItemCode"); //auto increment code
                }
                SqlConnection con = Connect.conn();
                String sql = qry;

                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.Add("@code", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@price", System.Data.SqlDbType.Real);
                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@cnt", System.Data.SqlDbType.Int);

                if (picBx.Image != null)
                {
                    byte[] images = null;
                    FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    images = reader.ReadBytes((int)stream.Length);

                    cmd.Parameters.Add("@imge", System.Data.SqlDbType.Image);

                    cmd.Parameters["@imge"].Value = images;
                }

                if (String.Equals(type, "insert"))
                {
                    cmd.Parameters["@code"].Value = reqid;
                }
                else
                {
                    if (txtItemNo2.Text != null)
                    {
                        cmd.Parameters["@code"].Value = int.Parse(txtItemNo2.Text);
                    }
                    else
                    {
                        MessageBox.Show("        ", "Item Number is Empty....!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cmd.Parameters["@price"].Value = double.Parse(txtPrice2.Text);
                cmd.Parameters["@name"].Value = txtName2.Text;
                cmd.Parameters["@cnt"].Value = int.Parse(txtStockCnt2.Text);


                int execute = cmd.ExecuteNonQuery();
                con.Close();

                if (execute == 1)
                {

                    if (String.Equals(type, "update"))
                    {
                        MessageBox.Show("                      ", "Succesfully Updated....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        runDataGridInventory();
                        ClearAll();

                    }
                    else if (String.Equals(type, "insert"))
                    {
                        MessageBox.Show("                ", "Succesfully Inserted....!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        runDataGridInventory();
                        ClearAll();

                    }
                }
                else
                {
                    MessageBox.Show("        ", "Error Occured....!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check Data That You Added ", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
        }



        public Boolean checkAvailability(String qry)
        {
            SqlConnection con = Connect.conn();
            con.Open();

            String sql = qry;
            SqlCommand cmd = new SqlCommand(sql,con);
            DataSet ds = new DataSet();
            ds.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            int i = ds.Tables[0].Rows.Count;
   
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }   

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            dialog.Title = "Insert Picture of the Item";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                picBx.ImageLocation = imglocation;
            }
        }



        private void txtItemNo2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();

            try
            {

                

                String sql = "SELECT iprice,iname,stckcnt FROM InvtEventSell WHERE itemCode = " + int.Parse(txtItemNo2.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, con);

                sprice = "";
                snme = "";
                squant = "";

                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        sprice = reader["iprice"].ToString();
                        snme = reader["iname"].ToString();
                        squant = reader["stckcnt"].ToString();
                    }

                    reader.Close();

                    txtName2.Text = snme;
                    txtStockCnt2.Text = squant;
                    txtPrice2.Text = sprice;

                    con.Close();

                }
                catch (Exception)
                {
                    con.Close();
                    txtName2.Text = "";
                    txtPrice2.Text = "0.00";
                    txtStockCnt2.Text = "0";
                }
            }
            catch(Exception)
            {
                con.Close();
                txtName2.Text = "";
                txtPrice2.Text = "0.00";
                txtStockCnt2.Text = "0";
            }

        }

        public void ClearAll()
        {
            txtItemNo2.Clear();
            txtName2.Clear();
            txtPrice2.Clear();
            txtStockCnt2.Clear();
            picBx.Image = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemNo2.Text == null)
                {
                    MessageBox.Show("Please Enter Value on the Textbox or Mark the Value that you want in the Inventory Table", "Item is not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (checkAvailability("select * from InvtEventSell WHERE itemCode = " + int.Parse(txtItemNo2.Text) + "") == true)
                {
                    DialogResult dialog = MessageBox.Show("Do you Want to Delete Which Item ID is Named as '" + txtItemNo2.Text + "' And Item Name is Named as '" + txtName2.Text + "'.. \n This Process can not be Undone", "Do You Really Want to Delete the Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        SqlConnection con = Connect.conn();

                        String sql = "delete from InvtEventSell where itemCode = '" + int.Parse(txtItemNo2.Text) + "'";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(sql, con);

                        try
                        {
                            int rslt = cmd.ExecuteNonQuery();

                            if (rslt == 1)
                            {
                                MessageBox.Show("Item Deleted   ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                runDataGridInventory();
                                ClearAll();

                            }
                            else
                            {
                                MessageBox.Show("Item Can not Deleted", "Error Occured When Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            con.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Item that You Tring to Delete is Gave some Infromation to Other Departments(Event Management & Seller Management) therefore this item can not Delete.\nIf You Really need to Delete this item Contact Other Departments & Delete Their Information Regaurding this Item     \nItem Code :'" + txtItemNo2.Text + "'\nItemName : '" + txtName2.Text + "'", "Item Can Not Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            ClearAll();
                        }
                    }

                }
                else if (checkAvailability("select * from InvtEventSell WHERE itemCode = " + int.Parse(txtItemNo2.Text) + "") == false)
                {
                    MessageBox.Show("Please Check Whether Item that You Want to Delete is Available in the Inventory.. If its Avaibale, Please Contact our Support Team", "No Item Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Please Contact our Support Team", "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }catch(Exception)
            {
                MessageBox.Show("Please Check Wheather the data that You Inserte is Correct", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblItemNo_Click(object sender, EventArgs e)
        {

        }

        private void txtItemNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (!String.Equals(txtItemNo.Text, "") && !String.Equals(txtQuantity.Text, ""))
            {

                sendReqeust();

            }
            else
            {
                MessageBox.Show("Please Mark Item That You Want or Fill the Text Boxes", "Empty Fields Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void hme_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;
            this.Hide();
            mainM.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            InventoryMenu invM = ObjectHolder.inventoryMainMenu;
            this.Hide();
            invM.Show();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            
            if (!String.Equals(txtItemNo.Text,"") && !String.Equals(txtQuantity.Text,""))
            {

                sendReqeust();

            }
            else
            {
                MessageBox.Show("Please Mark Item That You Want or Fill the Text Boxes", "Empty Fields Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        public EventForm()
        {
            InitializeComponent();
            ObjectHolder.sellCrud = this;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            runDataGridDeny();
            runDataGridInventory();
            txtName2.Text = "";
            txtPrice2.Text = "0.00";
            txtStockCnt2.Text = "0";

            txtItemName.Text = "";
            txtQuantity.Text = "0";

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            borrower = sender;
            ea = e;

            if (e.RowIndex >= 0)
            {
                
   
                DataGridViewRow row = this.denyDataGrid.Rows[e.RowIndex];

                    seventid = row.Cells["EVENT ID"].Value.ToString();
                    squant = row.Cells["NEEDED ITEMS"].Value.ToString();
                    sno = row.Cells["ITEM CODE"].Value.ToString();
                    txtItemName.Text = row.Cells["ITEM NAME"].Value.ToString();
                    

                    ino = int.Parse(sno);
                    quant = int.Parse(squant);
                    eventid = int.Parse(seventid);
                    txtItemNo.Text = sno;
                    txtQuantity.Text = squant;


            }

    
        }

        public void runDataGridDeny()
        {
            SqlConnection con = Connect.conn();

            String sql = "SELECT Eventid AS[EVENT ID], ItemCode AS[ITEM CODE], ItemName AS[ITEM NAME], NeededItems[NEEDED ITEMS] FROM neededItems";
          

            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            denyDataGrid.DataSource = dt;

            con.Close();

            txtItemName.Text = "";
            txtQuantity.Text = "0";

        }
        public void runDataGridInventory()
        {
            SqlConnection con = Connect.conn();

            String sql2 = "SELECT itemCode AS [ITEM CODE], iprice AS [ITEM STOCK PRICE], iname AS [ITEM NAME], stckcnt AS [STOCK COUNT] FROM InvtEventSell";
            DataTable dt2 = new DataTable();

            con.Open();

            SqlDataAdapter adapter2 = new SqlDataAdapter(sql2, con);
            adapter2.Fill(dt2);
            InventoryDataGrid.DataSource = dt2;
       
            con.Close();

        }

        public void sendReqeust()
        {

            try
            {

                SqlConnection con = Connect.conn();

                reqid = Connect.AI("InventoryRequest", "requestid");


                con.Open();



                SqlCommand cmd = new SqlCommand("Insert into InventoryRequest(requestid,itemno,itemName,quantity) Values(@reqid,@ino,@name,@quant)", con);

                SqlCommand cmd2 = new SqlCommand("UPDATE denyEventSell SET state = 1 WHERE eventid = @evnt", con);




                cmd.Parameters.Add("@reqid", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@ino", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@quant", System.Data.SqlDbType.Int);

                cmd.Parameters["@reqid"].Value = Convert.ToInt32(reqid);
                cmd.Parameters["@ino"].Value = Convert.ToInt32(txtItemNo.Text);
                cmd.Parameters["@name"].Value = Convert.ToString(txtItemName.Text);
                cmd.Parameters["@quant"].Value = Convert.ToInt32(txtQuantity.Text);

                int affected = cmd.ExecuteNonQuery();

                cmd2.Parameters.Add("@evnt", System.Data.SqlDbType.Int);
                cmd2.Parameters["@evnt"].Value = Convert.ToInt32(seventid);

                int affected2 = cmd2.ExecuteNonQuery();

                if (affected == 1 && affected2 == 1)
                {
                    ino = int.Parse(txtItemNo.Text);
                    eventid = int.Parse(seventid);

                    MessageBox.Show("Data Inserted", "SuccessFull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    runDataGridDeny();



                }
                else
                {
                    MessageBox.Show("Please Contact Developer Team to Fix this Error... (Error Description : Data Dosent inserted to InventoryRequest Table)", "Error Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check Data That You Edited or Inserted", "Wrong Input Addded", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }


        }


    }
}
