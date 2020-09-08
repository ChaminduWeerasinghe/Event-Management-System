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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connect.conn();
            String sql = "SELECT un,pw FROM Users WHERE un ='" + txtun.Text + "' AND pw ='" + txtpw.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql,con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                String uname = "";
                String pword = "";
                while (reader.Read())
                {
                    uname = reader["un"].ToString();
                    pword = reader["pw"].ToString();
                }

                if (String.Equals(uname,txtun.Text) && String.Equals(pword,txtpw.Text))
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();

                }

                

            }
            else
            {

            }

            con.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
