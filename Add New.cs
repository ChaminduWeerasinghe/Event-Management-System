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
using System.Text.RegularExpressions;
using InventorySystem.supportiveClasses;

namespace InventorySystem
//namespace ITP_Project
{
    public partial class Add_New : Form
    {
        public Add_New()
        {
            InitializeComponent();
        }
        //SqlConnection con= new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=WeddingCreation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = Connect.conn();

        String cid, Cname, Caddress, Ctelephone, Cmobile, Cemail, Cnic, Cgender;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^\d{10}$").Success;
        }

        private void Add_New_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1R fm = new Form1R();
            fm.Show();
        }

        private void Add_New_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            submitEntry();
        }


        public void submitEntry()
        {

            if (name.Text == "" || address.Text == "" || nic.Text == "" || telephone.Text == "" || mobile.Text == "" || email.Text == "" || (male.Checked == false && female.Checked == false))
            {
                MessageBox.Show("Enter full details");
            }
            else if (IsValidEmail(email.Text) == false)
            {
                MessageBox.Show("Invalide Email");
            }
            else if (IsPhoneNumber(mobile.Text) != true)
            {
                MessageBox.Show("Invalide Mobile Number");
            }
            else if (IsPhoneNumber(telephone.Text) != true)
            {
                MessageBox.Show("Invalide Telephone Number");
            }
            else
            {



                try
                {
                    if (male.Checked == true)
                    {
                        Cgender = "male";

                    }
                    else if (female.Checked == true)
                    {
                        Cgender = "female";
                    }

                    con.Open();
                    String sql = "Insert into customer  (Name,Address,Gender,NIC,Telephone,Mobile,Email) values('" + name.Text + "','" + address.Text + "','" + Cgender + "','" + nic.Text + "','" + telephone.Text + "','" + mobile.Text + "','" + email.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Data Submitted");
                    clear();
                    this.Hide();
                    Form1R fm = new Form1R();
                    fm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }




            }


        }


        public void clear()
        {
            name.Text = "";
            address.Text = "";
            nic.Text = "";
            telephone.Text = "";
            mobile.Text = "";
            email.Text = "";
            male.Checked = false;
            female.Checked = false;
        }
    }
}
