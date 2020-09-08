using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form1Ravindu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi\sqlexpress;Initial Catalog=Inventory2;Integrated Security=True");

        public Form1Ravindu()
        {
            InitializeComponent();
        }
        ErrorProvider e1 = new ErrorProvider();
        bool isValidated;

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                e1.SetError(textBox1, "Enter a valid number.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox1, null);
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                e1.SetError(textBox2, "Enter a valid number.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox2, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox3.Text, @"^\d+$"))
            {
                e1.SetError(textBox3, "Enter a valid number.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox3, null);
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox4.Text, @"^\d+$"))
            {
                e1.SetError(textBox4, "Enter a valid number.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox4, null);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catering_Package(package_Name,Appetizer,Rice,Curries,Devels,Dessert) VALUES('" + checkBox1.Text + "','Soup,Buns,Chicken Devel','Red Rice,White Rice,Fried Rice','Dhal Curry,Beans Curry,Chicken Curry','Chicken Devel','Watalappan,Ice Cream')";
                cmd.ExecuteNonQuery();
                con.Close();

              //  MessageBox.Show("Data Insert Successfully");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catering_Package(package_Name,Appetizer,Rice,Curries,Devels,Dessert) VALUES('" + checkBox2.Text + "','Soup,Buns,Cashew,Chicken Devel','Mixed Rice,White Rice,Fried Rice','Potato Curry,Dhal Curry,Beans Curry,Chicken Curry','Chicken Devel,Cashew Devel,','Watalappan,Ice Cream,Fruit Salad')";
                cmd.ExecuteNonQuery();
                con.Close();

             //   MessageBox.Show("Data Insert Successfully");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catering_Package(package_Name,Appetizer,Rice,Curries,Devels,Dessert) VALUES('" + checkBox3.Text + "','Soup,Buns,Cashew,Chicken Devel','Mixed Rice,White Rice,Fried Rice','Potato Curry,Dhal Curry,Beans Curry,Chicken Curry','Chicken Devel,Cashew Devel,','Watalappan,Ice Cream,Fruit Salad')";
                cmd.ExecuteNonQuery();
                con.Close();

             //   MessageBox.Show("Data Insert Successfully");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catering_Package(package_Name,Appetizer,Rice,Curries,Devels,Dessert) VALUES('" + checkBox4.Text + "','Soup,Buns,Cashew,Chicken Devel,Develled Potatoes','Mixed Rice,Fried Rice,Nasigoreng Rice,Biriyani Rice','Potato Curry,Dhal Curry,Beans Curry,Chicken Curry,Pork Curry,Beef Curry,Egg Curry','Chicken Devel,Mutton Devel,Beef Devel,Sausageaus,Cashew Devel','Watalappan,Ice Cream,Fruit Salad,Ice Cream,Brownies,Chocalate Fountain')";
                cmd.ExecuteNonQuery();
                con.Close();

             //   MessageBox.Show("Data Insert Successfully");
            }
        }



        //changed need to upgrade


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("You need to at least select one check box and enter a price");


            }

            if (checkBox1.Checked && textBox1.Text != "")
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE catering_Package SET package_price = '" + textBox1.Text + "' WHERE package_Name = 'Economy'"; //
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");
                textBox1.Text = "";

            }
            else if (checkBox1.Checked && textBox3.Text == "")
            {
                MessageBox.Show("Enter a price for '" + checkBox1.Text + "'.");
            }


            if (checkBox2.Checked && textBox2.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE catering_Package SET package_price = " + textBox2.Text + " WHERE package_Name = 'Regular'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");
                textBox2.Text = "";

            }
            else if (checkBox2.Checked && textBox3.Text == "")
            {
                MessageBox.Show("Enter a price for '" + checkBox2.Text + "'.");
            }


            if (checkBox3.Checked && textBox3.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE catering_Package SET package_price = " + textBox3.Text + " WHERE package_Name = 'DeLuxe'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");
                textBox3.Text = "";
            }
            else if (checkBox3.Checked && textBox3.Text == "")
            {
                MessageBox.Show("Enter a price for '" + checkBox3.Text + "'.");
            }

            if (checkBox4.Checked && textBox4.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE catering_Package SET package_price = " + textBox4.Text + " WHERE package_Name = 'Premium'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");
                textBox4.Text = "";
            }
            else if (checkBox4.Checked && textBox4.Text == "")
            {
                MessageBox.Show("Enter a price for '" + checkBox4.Text + "'.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Ravindu obj = new Form2Ravindu();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5Ravindu obj = new Form5Ravindu();
            obj.ShowDialog();
        }
    }
}
