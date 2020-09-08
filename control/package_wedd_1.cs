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
using System.IO;
using InventorySystem.supportiveClasses;
using System.Collections;

namespace InventorySystem.control
{
    public partial class package_wedd_1 : UserControl
    {
        private int packageid;
        private String packagename;
        private Double packageprice;
        private InsertPackage insertpack;
        private String cus_name_combo;

        public package_wedd_1()
        {
            InitializeComponent();
            showID();
        }

        private int imageNumber = 2;

        Customer customer = new Customer();
        CustomerImpl cusI = new CustomerImpl();

        private void LoadNextImage()
        {
            try
            {
                SqlConnection con = Connect.conn();

                String sql = " select p.packid, p.packname,p.packprice,I.img2,I.img3,I.img4,I.img5,I.img6 from InvtEventPack p,InvtEventImages I where I.packid = p.packid";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("dt");
                da.Fill(dt);

                if (dt != null)
                {

                    if (imageNumber == 5)
                    {
                        imageNumber = 2;
                    }

                    packageid = int.Parse(dt.Rows[0]["packid"].ToString());
                    packagename = dt.Rows[0]["packname"].ToString();
                    packageprice = double.Parse(dt.Rows[0]["packprice"].ToString());
                    Console.WriteLine("Packid is :"+packageid);
                    byte[] data = (byte[])dt.Rows[0]["img"+imageNumber];
                    MemoryStream ms = new MemoryStream(data);
                    slidePic.Image = Image.FromStream(ms);
                }
                pakagename.Text = packagename;

                con.Open();
            }
            catch(Exception)
            {

            }

            
            imageNumber++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
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


        private void ID_combo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            customer.cusName = ID_combo.Text;
            cus_name_combo = ID_combo.Text;
            int cusId = cusI.GetCustomerIDs(customer);

            fname_txt.Text = cusId.ToString();
        }



        private void trigger()
        {
            if(insertpack == null)
            {
                insertpack = new InsertPackage();
            }

            insertpack.InsertEvent(packageid,packagename,packageprice,int.Parse(fname_txt.Text.ToString()));

            if(insertpack.val == true)
            {
                //messagebox successfull
                MessageBox.Show("Package successfully inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Package insert unsuccessfull", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            if (cus_name_combo != null)
            {
                trigger();
            }
            else
            {
                MessageBox.Show("Please Select Customer Before Order the pakage", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
