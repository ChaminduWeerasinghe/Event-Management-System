using System;
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
using System.Threading;

namespace InventorySystem
{
    public partial class InvPackageUpdate : Form
    {
        int id;
        String name;
        double price;

        Image getImage01;
        Image getImage02;
        Image getImage03;
        Image getImage04;
        Image getImage05;
        Image getImage06;
        updateInventorySup sup;
        Thread mainThread;

        object packLoadObj;
        EventArgs packLoadArgs;

        public InvPackageUpdate()
        {
            InitializeComponent();
            ObjectHolder.packupdate = this;

        }

        private void InvPackageUpdate_Load(object sender, EventArgs e)
        {
            packLoadObj = sender;
            packLoadArgs = e;

            mainThread = Thread.CurrentThread;
            clearAll();
        }

        private void getPreData()
        {
            SqlConnection con = Connect.conn();
            try
            {
                String sql = "SELECT * FROM InvtEventImages WHERE packid = " + int.Parse(txtID.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        try
                        {
                            MemoryStream ms1 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img1"]);
                            picBx01.Image = new Bitmap(ms1);
                            getImage01 = new Bitmap(ms1);
                            Clear01.Visible = true;
                        }
                        catch (Exception) { }
                        try
                        {
                            MemoryStream ms2 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img2"]);
                            picBx02.Image = new Bitmap(ms2);
                            getImage02 = new Bitmap(ms2);
                            Clear02.Visible = true;

                        }
                        catch (Exception) { }
                        try
                        {
                            MemoryStream ms3 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img3"]);
                            picBx03.Image = new Bitmap(ms3);
                            getImage03 = new Bitmap(ms3);
                            Clear03.Visible = true;

                        }
                        catch (Exception) { }
                        try
                        {
                            MemoryStream ms4 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img4"]);
                            picBx04.Image = new Bitmap(ms4);
                            getImage04 = new Bitmap(ms4);
                            Clear04.Visible = true;

                        }
                        catch (Exception) { }
                        try
                        {
                            MemoryStream ms5 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img5"]);
                            picBx05.Image = new Bitmap(ms5);
                            getImage05 = new Bitmap(ms5);
                            Clear05.Visible = true;

                        }
                        catch (Exception) { }
                        try
                        {
                            MemoryStream ms6 = new MemoryStream((byte[])ds.Tables[0].Rows[0]["img6"]);
                            picBx06.Image = new Bitmap(ms6);
                            getImage06 = new Bitmap(ms6);
                            Clear06.Visible = true;

                        }
                        catch (Exception) { }

                    }

                }
                catch (Exception)
                {

                }

            }
            catch (Exception)
            {

            }

        }




        public void checkBrowser()
        {
            if (picBx01.Image != null && picBx02.Image != null && picBx03.Image != null && picBx04.Image != null && picBx05.Image != null && picBx06.Image != null)
            {
                btnbrowse.Enabled = false;
            }
            else
            {
                if (btnbrowse.Enabled == false)
                {
                    btnbrowse.Enabled = true;
                }
            }

        }


        public byte[] convertToByte(PictureBox picture)
        {
            if (picture.Image != null)
            {
                byte[] images = null;
                FileStream stream = new FileStream(picture.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                images = reader.ReadBytes((int)stream.Length);

                return images;
            }
            else
            {
                return null;
            }


        }


        public String Browse()
        {
            Console.WriteLine("Came Here");

            String imageLocation = "";
            OpenFileDialog dialog = null;

            dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            dialog.Title = "Insert Picture of the Item";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                Console.WriteLine("Location : " + imageLocation);
                return imageLocation;

            }
            else
            {
                return null;
            }
        }




        private void Clear01_Click(object sender, EventArgs e)
        {
            picBx01.Image = null;
            getImage01 = null;
            picBx01.Refresh();
            Clear01.Visible = false;
            checkBrowser();
        }

        private void Clear02_Click(object sender, EventArgs e)
        {
            picBx02.Image = null;
            getImage02 = null;
            picBx02.Refresh();
            Clear02.Visible = false;
            checkBrowser();
        }

        private void Clear03_Click(object sender, EventArgs e)
        {
            picBx03.Image = null;
            getImage03 = null;
            picBx03.Refresh();
            Clear03.Visible = false;
            checkBrowser();
        }

        private void Clear04_Click(object sender, EventArgs e)
        {
            picBx04.Image = null;
            getImage04 = null;
            picBx04.Refresh();
            Clear04.Visible = false;
            checkBrowser();
        }

        private void Clear05_Click(object sender, EventArgs e)
        {
            picBx05.Image = null;
            getImage05 = null;
            picBx05.Refresh();
            Clear05.Visible = false;
            checkBrowser();
        }

        private void Clear06_Click(object sender, EventArgs e)
        {
            picBx06.Image = null;
            getImage06 = null;
            picBx06.Refresh();
            Clear06.Visible = false;
            checkBrowser();
        }

        public Image convertImg(byte[] arr)
        {
            Image i = (Bitmap)((new ImageConverter()).ConvertFrom(arr));
            return i;
        }

        private void txtID_Hover(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
        }

        private void txtID_Changed(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();
            String sprice = "0";
            String tempid = "-99";
            String nme = "";
            Console.WriteLine("Cmae..................................................................................");

            try
            {
                String sql = "SELECT packid,packprice,packname FROM InvtEventPack WHERE packid = " + int.Parse(txtID.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempid = reader["packid"].ToString();
                        sprice = reader["packprice"].ToString();
                        nme = reader["packname"].ToString();
                    }
                    reader.Close();
                    con.Close();

                    txtPriceUp.Text = sprice;
                    txtNameUp.Text = nme;
                }
                catch (Exception)
                {

                }
            }
            catch (Exception)
            {

            }

            if (String.Equals(txtID.Text, tempid))
            {
                btnbrowse.Enabled = true;
                Insert.Enabled = true;
                getPreData();
                Console.WriteLine("CHECK OK .....................");
            }
            else
            {
                btnbrowse.Enabled = false;
                Insert.Enabled = false;
                clearAll();

            }
        }



        public void PicBoxControl()
        {
            String imgLoc = Browse();
            Console.WriteLine("Location Recheck :" + imgLoc);



            if (imgLoc != null || !String.Equals(imgLoc, ""))
            {

                Console.WriteLine("Check is NOT NULL");
                AssignObj(imgLoc);

            }
            else
            {
                Console.WriteLine("Error Detected");
            }
        }

        public void AssignObj(String picture)
        {
            if (picBx01.Image == null)
            {
                Console.WriteLine("PictureBox 01");

                picBx01.ImageLocation = picture;
                groupBox.Controls.Add(picBx01);
                getImage01 = Image.FromFile(picture);
                Console.WriteLine("picBx 1 Image Rslt : " + getImage01);
                Clear01.Visible = true;
            }
            else if (picBx02.Image == null)
            {
                picBx02.ImageLocation = picture;
                groupBox.Controls.Add(picBx02);
                getImage02 = Image.FromFile(picture);
                Console.WriteLine("picBx 2 Image Rslt : " + getImage02);
                Clear02.Visible = true;
            }
            else if (picBx03.Image == null)
            {
                picBx03.ImageLocation = picture;
                groupBox.Controls.Add(picBx02);
                getImage03 = Image.FromFile(picture);
                Console.WriteLine("picBx 3 Image Rslt : " + getImage03);
                Clear03.Visible = true;
            }
            else if (picBx04.Image == null)
            {
                picBx04.ImageLocation = picture;
                groupBox.Controls.Add(picBx04);
                getImage04 = Image.FromFile(picture);
                Console.WriteLine("picBx 4 Image Rslt : " + getImage04);
                Clear04.Visible = true;
            }
            else if (picBx05.Image == null)
            {
                picBx05.ImageLocation = picture;
                groupBox.Controls.Add(picBx05);
                getImage05 = Image.FromFile(picture);
                Console.WriteLine("picBx 5 Image Rslt : " + getImage05);
                Clear05.Visible = true;
            }
            else if (picBx06.Image == null)
            {
                picBx06.ImageLocation = picture;
                groupBox.Controls.Add(picBx06);
                getImage06 = Image.FromFile(picture);
                Console.WriteLine("picBx 6 Image Rslt : " + getImage06);
                Clear06.Visible = true;
            }
            else
            {
                MessageBox.Show("Maximum Ammount of Items Added", "Can not Add this Picture", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }


        private void insertTxtBoxData()
        {
            try
            {
                SqlConnection con = Connect.conn();
                String sql = "UPDATE InvtEventPack SET packname = @nwname, packprice = @nwprice WHERE packid = " + int.Parse(txtID.Text) + "";

                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.Add("@nwname", System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add("@nwprice", System.Data.SqlDbType.Real);

                cmd.Parameters["@nwname"].Value = txtNameUp.Text;
                cmd.Parameters["@nwprice"].Value = double.Parse(txtPriceUp.Text);


                int exec = cmd.ExecuteNonQuery();
                con.Close();
                if (exec != 1)
                {
                    MessageBox.Show("Please Contact Our Support Team", "Some Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Check that all the Fileds Before Update Your Data", "Wrong Data Inserted to the Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void Tmethod()
        {
            if (sup == null)
            {
                sup = new updateInventorySup();
            }

            sup.nwCnt(getImage01, getImage02, getImage03, getImage04, getImage05, getImage06, int.Parse(txtID.Text));
        }


        private void clearAll()
        {
            picBx01.Image = null;
            getImage01 = null;
            picBx01.Refresh();
            Clear01.Visible = false;
            checkBrowser();

            picBx02.Image = null;
            getImage02 = null;
            picBx02.Refresh();
            Clear02.Visible = false;
            checkBrowser();

            picBx03.Image = null;
            getImage03 = null;
            picBx03.Refresh();
            Clear03.Visible = false;
            checkBrowser();

            picBx04.Image = null;
            getImage04 = null;
            picBx04.Refresh();
            Clear04.Visible = false;
            checkBrowser();

            picBx05.Image = null;
            getImage05 = null;
            picBx05.Refresh();
            Clear05.Visible = false;
            checkBrowser();

            picBx06.Image = null;
            getImage06 = null;
            picBx06.Refresh();
            Clear06.Visible = false;
            checkBrowser();


        }

        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            if (picBx01.Image == null || picBx02.Image == null || picBx03.Image == null || picBx04.Image == null || picBx05.Image == null || picBx06.Image == null)
            {
                PicBoxControl();
            }
            else
            {
                MessageBox.Show("Maximum Number of Images Added (Maximum Number of Images are 6)", "Maximum Number of Images Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (!String.Equals(txtID.Text,"") && !String.Equals(txtNameUp.Text, "") && !String.Equals(txtPriceUp.Text, "")) {
                SqlConnection con = Connect.conn();
                String sql = "DELETE FROM InvtEventImages WHERE packid = " + int.Parse(txtID.Text) + "";
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);

                int execute = cmd.ExecuteNonQuery();
                con.Close();

                Thread thread = new Thread(new ThreadStart(this.Tmethod));
                thread.Start();
                insertTxtBoxData();


                thread.Join();

                if (sup.validate == true)
                {
                    MessageBox.Show("Successfully Updated", "Image Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    txtID.Text = "";
                    txtNameUp.Text = "";
                    txtPriceUp.Text = "";
                }
                else if (sup.validate == false)
                {
                    MessageBox.Show("Please Check that you added Images", "No Image Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("No Data Added to the Field or Fields. Please Double Check All The Fields", "Empty Fileds Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void hme_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;

            mainM.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            PackageMenu packageMenu = ObjectHolder.packMenu;
            this.Hide();
            packageMenu.Show();
            packageMenu.runDataGrid();
        }
    }
}
