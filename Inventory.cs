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
    public partial class packInsert : Form
    {
        int id;
        String name;
        double price;


        private byte[] Image01;
        private byte[] Image02;
        private byte[] Image03;
        private byte[] Image04;
        private byte[] Image05;
        private byte[] Image06;

        object packLoadObj;
        EventArgs packLoadArgs;

        public packInsert()
        {

            InitializeComponent();
            ObjectHolder.packinsert = this;

        }

        private void packInsert_Load(object sender, EventArgs e)
        {
            packLoadObj = sender;
            packLoadArgs = e;

            txtID.Text = Connect.AI("InvtEventPack", "packid").ToString();

            Clear01.Visible = false;
            Clear02.Visible = false;
            Clear03.Visible = false;
            Clear04.Visible = false;
            Clear05.Visible = false;
            Clear06.Visible = false;

            Image01 = null;
            Image02 = null;
            Image03 = null;
            Image04 = null;
            Image05 = null;
            Image06 = null;


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

        //check Image Objects Are Null
        public void AssignToVariables(PictureBox picture)
        {
            if (Image01 == null)
            {
                Image01 = convertToByte(picture);
                Console.WriteLine("Came to the Byte Stream 01");
            }
            else if (Image02 == null)
            {
                Image02 = convertToByte(picture);
                Console.WriteLine("Came to the Byte Stream 02");
            }
            else if (Image03 == null)
            {
                Image03 = convertToByte(picture);
            }
            else if (Image04 == null)
            {
                Image04 = convertToByte(picture);
            }
            else if (Image05 == null)
            {
                Image05 = convertToByte(picture);
            }
            else if (Image06 == null)
            {
                Image06 = convertToByte(picture);
            }
            else
            {

            }


        }

        //check Picture Boxes Are not null
        public void addImgDataControl()
        {

            if (picBx01.Image != null)
            {
                AssignToVariables(picBx01);
                picBx01.Image = null;
            }
            if (picBx02.Image != null)
            {
                AssignToVariables(picBx02);
                picBx02.Image = null;
            }
            if (picBx03.Image != null)
            {
                AssignToVariables(picBx03);
                picBx03.Image = null;
            }
            if (picBx04.Image != null)
            {
                AssignToVariables(picBx04);
                picBx04.Image = null;
            }
            if (picBx05.Image != null)
            {
                AssignToVariables(picBx05);
                picBx05.Image = null;
            }
            if (picBx06.Image != null)
            {
                AssignToVariables(picBx06);
                picBx06.Image = null;
            }


            ImageInsert();



        }

        public void ImageInsert()
        {
            SqlConnection con = Connect.conn();
            SqlCommand cmd;
            int execute = 0;
            con.Open();

            if (Image01 != null && Image02 != null && Image03 != null && Image04 != null && Image05 != null && Image06 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4,img5,img6) Values(@id,@img1,@img2,@img3,@img4,@img5,@img6)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img5", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img6", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;
                cmd.Parameters["@img5"].Value = Image05;
                cmd.Parameters["@img6"].Value = Image06;

                execute = cmd.ExecuteNonQuery();
            }
            else if (Image01 != null && Image02 != null && Image03 != null && Image04 != null && Image05 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4,img5) Values(@id,@img1,@img2,@img3,@img4,@img5)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img5", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;
                cmd.Parameters["@img5"].Value = Image05;

                execute = cmd.ExecuteNonQuery();
            }
            else if (Image01 != null && Image02 != null && Image03 != null && Image04 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3,img4) Values(@id,@img1,@img2,@img3,@img4)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img4", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;
                cmd.Parameters["@img4"].Value = Image04;

                execute = cmd.ExecuteNonQuery();
            }
            else if (Image01 != null && Image02 != null && Image03 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2,img3) Values(@id,@img1,@img2,@img3)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img3", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;
                cmd.Parameters["@img3"].Value = Image03;

                execute = cmd.ExecuteNonQuery();
            }
            else if (Image01 != null && Image02 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1,img2) Values(@id,@img1,@img2)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@img2", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;
                cmd.Parameters["@img2"].Value = Image02;

                execute = cmd.ExecuteNonQuery();
            }
            else if (Image01 != null)
            {
                String sql = "insert into InvtEventImages(packid,img1) Values(@id,@img1)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@img1", System.Data.SqlDbType.Image);

                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@img1"].Value = Image01;

                execute = cmd.ExecuteNonQuery();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Do you Want to Set Image as Blank ??", "Image is not Added", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {

                }
                else
                {
                    String sql = " delete from InvtEventPack where packid = " + int.Parse(txtID.Text) + "";
                    cmd = new SqlCommand(sql, con);

                    cmd.ExecuteNonQuery();


                    packInsert_Load(packLoadObj, packLoadArgs);
                }
            }


            if (execute == 1)
            {
                MessageBox.Show("Image Insert Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                packInsert_Load(packLoadObj, packLoadArgs);
            }
            con.Close();

        }



        public int addTxtBoxData()
        {
            try
            {
                SqlConnection con = Connect.conn();

                if (txtName.Text != null && txtPrice.Text != null)
                {
                    id = Connect.AI("InvtEventPack", "packid");
                    name = txtName.Text;
                    price = double.Parse(txtPrice.Text);


                    String qry = "Insert into InvtEventPack(packid,packprice,packname) VALUES(@id,@price,@name)";

                    con.Open();

                    SqlCommand cmd = new SqlCommand(qry, con);

                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Real);
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar);

                    cmd.Parameters["@id"].Value = id;
                    cmd.Parameters["@price"].Value = price;
                    cmd.Parameters["@name"].Value = name;

                    int status = cmd.ExecuteNonQuery();

                    con.Close();

                    return status;
                }
                else
                {
                    return -99;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Insert Correct Data to Fileds", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = null;
                txtPrice.Text = null;
                return -999;
            }

        }

        private void clearAll()
        {
            picBx01.Image = null;
            picBx02.Image = null;
            picBx03.Image = null;
            picBx04.Image = null;
            picBx05.Image = null;
            txtName.Text = null;
            txtPrice.Text = null;
        }

        public void AssignObj(String picture)
        {
            if (picBx01.Image == null)
            {
                Console.WriteLine("PictureBox 01");
                picBx01.ImageLocation = picture;
                groupBox.Controls.Add(picBx01);
                Clear01.Visible = true;
            }
            else if (picBx02.Image == null)
            {
                picBx02.ImageLocation = picture;
                groupBox.Controls.Add(picBx02);
                Clear02.Visible = true;
            }
            else if (picBx03.Image == null)
            {
                picBx03.ImageLocation = picture;
                groupBox.Controls.Add(picBx02);
                Clear03.Visible = true;
            }
            else if (picBx04.Image == null)
            {
                picBx04.ImageLocation = picture;
                groupBox.Controls.Add(picBx04);
                Clear04.Visible = true;
            }
            else if (picBx05.Image == null)
            {
                picBx05.ImageLocation = picture;
                groupBox.Controls.Add(picBx05);
                Clear05.Visible = true;
            }
            else if (picBx06.Image == null)
            {
                picBx06.ImageLocation = picture;
                groupBox.Controls.Add(picBx06);
                Clear06.Visible = true;
            }
            else
            {
                MessageBox.Show("Maximum Ammount of Items Added", "Can not Add this Picture", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void Clear01_Click(object sender, EventArgs e)
        {
            picBx01.Image = null;
            picBx01.Refresh();
            Clear01.Visible = false;
            checkBrowser();
        }

        private void Clear02_Click(object sender, EventArgs e)
        {
            picBx02.Image = null;
            picBx02.Refresh();
            Clear02.Visible = false;
            checkBrowser();
        }

        private void Clear03_Click(object sender, EventArgs e)
        {
            picBx03.Image = null;
            picBx03.Refresh();
            Clear03.Visible = false;
            checkBrowser();
        }

        private void Clear04_Click(object sender, EventArgs e)
        {
            picBx04.Image = null;
            picBx04.Refresh();
            Clear04.Visible = false;
            checkBrowser();
        }

        private void Clear05_Click(object sender, EventArgs e)
        {
            picBx05.Image = null;
            picBx05.Refresh();
            Clear05.Visible = false;
            checkBrowser();
        }

        private void Clear06_Click(object sender, EventArgs e)
        {
            picBx06.Image = null;
            picBx06.Refresh();
            Clear06.Visible = false;
            checkBrowser();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!String.Equals(txtName.Text, "") && !String.Equals(txtPrice.Text, "")) {
                if (addTxtBoxData() == 1)
                {
                    addImgDataControl();
                }
                else if (addTxtBoxData() == -99)
                {
                    MessageBox.Show("No Data Added to the Field or Fields. Please Double Check All The Fields", "Empty Fileds Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (addTxtBoxData() == -999)
                {

                }
                else
                {
                    MessageBox.Show("Please Check Database is Connected", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Data Added to the Field or Fields. Please Double Check All The Fields", "Empty Fileds Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if(picBx01.Image == null || picBx02.Image == null || picBx03.Image == null || picBx04.Image == null || picBx05.Image == null || picBx06.Image == null)
            {
                PicBoxControl();
                checkBrowser();

            }
            else
            {
                MessageBox.Show("Maximum Number of Images Added (Maximum Number of Images are 6)", "Maximum Number of Images Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            PackageMenu packageMenu = ObjectHolder.packMenu;
            this.Hide();
            packageMenu.Show();
            packageMenu.runDataGrid();
        }

        private void hme_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;
            this.Hide();
            mainM.Show();
            
        }
    }
}
