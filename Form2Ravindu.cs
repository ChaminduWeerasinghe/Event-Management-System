
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
using System.Configuration;
using System.Text.RegularExpressions;

namespace InventorySystem
{



    public partial class Form2Ravindu : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=msi\sqlexpress;Initial Catalog=Inventory2;Integrated Security=True");

        public static string c26 = "";
        public static string c27 = "";
        public static string c28 = "";
        public static string c29 = "";
        public static string c22 = "";
        public static string c23 = "";
        public static string c24 = "";
        public static string c25 = "";
        public static string c16 = "";
        public static string c17 = "";
        public static string c18 = "";
        public static string c19 = "";
        public static string c1 = "";
        public static string c2 = "";
        public static string c3 = "";
        public static string c4 = "";
        public static string c5 = "";
        public static string c9 = "";
        public static string c10 = "";
        public static string c11 = "";
        public static string c12 = "";
        public static string c13 = "";
        public static string t1 = "";

        public static string r22 = "";
        public static string r23 = "";
        public static string r24 = "";
        public static string r25 = "";

        public Form2Ravindu()
        {
            InitializeComponent();
            FillCombo1();
        }

        void FillCombo1()
        {
            string que = "SELECT * from catering_Package";

            SqlCommand cmd = new SqlCommand(que, con);

            SqlDataReader rd;

            try
            {
                con.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    //special code
                    if (!comboBox1.Items.Contains(rd.GetString(1)))
                        comboBox1.Items.Add(rd.GetString(1));
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox13.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
               //     MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox17.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox13.Checked)
            {
                textBox17.Text = "";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (packageName.Text == "")
            {
                MessageBox.Show("Enter a package name.");
            }
            else if (!checkBox26.Checked && !checkBox27.Checked && !checkBox28.Checked && !checkBox29.Checked)
            {
                MessageBox.Show("Appertizer Coloumn Needs to be filled");
            }
            else if (!checkBox22.Checked && !checkBox23.Checked && !checkBox24.Checked && !checkBox25.Checked)
            {
                MessageBox.Show("At least One Rice type needs to be selected");
            }
            else if (!checkBox16.Checked && !checkBox16.Checked && !checkBox17.Checked && !checkBox18.Checked && !checkBox19.Checked)
            {
                MessageBox.Show("At least one curry need to be selected");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                MessageBox.Show("At least one devel needs to be selected");
            }
            else if (!checkBox9.Checked && !checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked)
            {
                MessageBox.Show("At least one dessert need to be selected");
            }
            else
            {
                c26 = textBox1.Text;
                c27 = textBox2.Text;
                c28 = textBox3.Text;
                c29 = textBox4.Text;
                c22 = textBox10.Text;
                c23 = textBox9.Text;
                c24 = textBox8.Text;
                c25 = textBox7.Text;
                c16 = textBox16.Text;
                c17 = textBox14.Text;
                c18 = textBox13.Text;
                c19 = textBox12.Text;
                c1 = textBox27.Text;
                c2 = textBox26.Text;
                c3 = textBox25.Text;
                c4 = textBox23.Text;
                c5 = textBox28.Text;
                c9 = textBox21.Text;
                c10 = textBox20.Text;
                c11 = textBox19.Text;
                c12 = textBox18.Text;
                c13 = textBox17.Text;

                this.Hide();
                Form3 obj = new Form3();
                obj.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox26.Checked && !checkBox27.Checked && !checkBox28.Checked && !checkBox29.Checked)
            {
                MessageBox.Show("Appertizer Coloumn Needs to be filled");
            }
            else if (!checkBox22.Checked && !checkBox23.Checked && !checkBox24.Checked && !checkBox25.Checked)
            {
                MessageBox.Show("At least One Rice type needs to be selected");
            }
            else if (!checkBox16.Checked && !checkBox16.Checked && !checkBox17.Checked && !checkBox18.Checked && !checkBox19.Checked)
            {
                MessageBox.Show("At leasr one curry need to be selected");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                MessageBox.Show("At least one devel needs to be selected");
            }
            else if (!checkBox9.Checked && !checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked)
            {
                MessageBox.Show("At least one dessert need to be selected");
            }
            else if (packageName.Text == "")
            {
                MessageBox.Show("Name needs to be filled..");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO catering_Package(package_Name) VALUES('" + packageName.Text + "');";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record successfully inserted");

                //Appertizer List

                if (checkBox26.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox28.Checked)// || checkBox27.Checked || checkBox28.Checked || checkBox29.Checked || checkBox30.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox28.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox29.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox28.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox28.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox28.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox28.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }

                //Rice List

                if (checkBox22.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox24.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox24.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox24.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox24.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox24.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }

                //NEED TO BE CHANGED
                if (checkBox22.Checked)
                {
                    r22 = checkBox22.Text;

                }
                if (checkBox23.Checked)
                {
                    r23 = checkBox23.Text;
                }
                if (checkBox24.Checked)
                {
                    r24 = checkBox24.Text;
                }
                if (checkBox25.Checked)
                {
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;

                }
                if (checkBox22.Checked && checkBox24.Checked)
                {
                    r22 = checkBox22.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox22.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox23.Checked && checkBox24.Checked)
                {
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox23.Checked && checkBox25.Checked)
                {
                    r23 = checkBox23.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox24.Checked && checkBox25.Checked)
                {
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }

                //Curry List

                if (checkBox16.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox18.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox18.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox18.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + " , " + checkBox18.Checked + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " ," + checkBox17.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }


                //Devel List


                if (checkBox1.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox16.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }


                //dessert list

                if (checkBox9.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                /*
                                if (checkBox21.Checked || checkBox22.Checked || checkBox23.Checked || checkBox24.Checked || checkBox25.Checked )
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox21.Text +" , "+checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox15.Checked) //&& checkBox16.Checked) || (checkBox15.Checked && checkBox18.Checked || checkBox19.Checked || checkBox20.Checked ||)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox15.Text+" , "+ checkBox16.Text + " , " + checkBox17.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + " , " + checkBox20.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }


                                if (checkBox16.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox16.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox17.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox17.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox18.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox18.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox19.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox19.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox20.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox20.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox1.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox1.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox2.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox2.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox3.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox3.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox4.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox4.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox5.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox5.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox6.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox6.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox9.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox9.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox10.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox10.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox11.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox11.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox12.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox12.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }

                                if (checkBox13.Checked)
                                {
                                    con.Open();
                                    SqlCommand cd = con.CreateCommand();
                                    cd.CommandType = CommandType.Text;
                                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox13.Text + "' WHERE package_Name = '" + packageName.Text + "';";
                                    cd.ExecuteNonQuery();
                                    con.Close();
                                }
                                */

                c26 = textBox1.Text;
                c27 = textBox2.Text;
                c28 = textBox3.Text;
                c29 = textBox4.Text;
                c22 = textBox10.Text;
                c23 = textBox9.Text;
                c24 = textBox8.Text;
                c25 = textBox7.Text;
                c16 = textBox16.Text;
                c17 = textBox14.Text;
                c18 = textBox13.Text;
                c19 = textBox12.Text;
                c1 = textBox27.Text;
                c2 = textBox26.Text;
                c3 = textBox25.Text;
                c4 = textBox23.Text;
                c5 = textBox28.Text;
                c9 = textBox21.Text;
                c10 = textBox20.Text;
                c11 = textBox19.Text;
                c12 = textBox18.Text;
                c13 = textBox17.Text;
                t1 = packageName.Text;

                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
                //obj.ShowDialog();

            }

            //HERE

            /*            string name = packageName.Text;
                        string appertizer = "";
                        string rice = "";
                        string curries = "";
                        string devels = "";
                        string dessert = "";

                        foreach (var checkedItem in this.Appetizer.CheckedItems)
                        {

                            appertizer += checkedItem.ToString() + ",";


                        }

                        foreach (var checkedItem in this.Rice.CheckedItems)
                        {
                            rice += checkedItem.ToString() + ",";
                        }

                        foreach (var checkedItem in this.Curries.CheckedItems)
                        {

                            curries += checkedItem.ToString() + ",";

                        }

                        foreach (var checkedItem in this.Devels.CheckedItems)
                        {
                            devels += checkedItem.ToString() + ",";

                        }

                        foreach (var checkedItem in this.Dessert.CheckedItems)
                        {
                            dessert += checkedItem.ToString() + ",";
                        }

                        appertizer = appertizer.TrimEnd(',');
                        rice = rice.TrimEnd(',');
                        curries = curries.TrimEnd(',');
                        devels = devels.TrimEnd(',');
                        dessert = dessert.TrimEnd(',');

                        con.Open();
                        SqlCommand cmd = new SqlCommand("appetizer_insert", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Appetizer", appertizer);
                        cmd.Parameters.AddWithValue("@Rice", rice);
                        cmd.Parameters.AddWithValue("@Curries", curries);
                        cmd.Parameters.AddWithValue("@Devels", devels);
                        cmd.Parameters.AddWithValue("@Dessert", dessert);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Insert Successfully");
            */
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Appetizer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*        private void button2_Click(object sender, EventArgs e)
                {

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM catering_Package WHERE package_Name = '" + packageName.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("record successfully deleted");
                }*/

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {

                string que = "SELECT * from cus_cat_package where name = '" + checkBox26.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
             //       MessageBox.Show("'" + textBox27.Text + "'");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox1.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (!checkBox26.Checked)
            {
                textBox1.Text = "";
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox27.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
              //      MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox2.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox27.Checked)
            {
                textBox2.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5Ravindu obj = new Form5Ravindu();
            obj.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox28.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
           //         MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox3.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox28.Checked)
            {
                textBox3.Text = "";
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox29.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
          //          MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox4.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox29.Checked)
            {
                textBox4.Text = "";
            }
        }

        /*

                private void checkBox21_CheckedChanged(object sender, EventArgs e)
                {
                    if (checkBox21.Checked)
                    {
                        string que = "SELECT * from cus_cat_package where name = '" + checkBox21.Text + "'";

                        SqlCommand cd = new SqlCommand(que, con);

                        SqlDataReader rd;

                        try
                        {
                            con.Open();
                            rd = cd.ExecuteReader();
                            MessageBox.Show("Deleted");

                            while (rd.Read())
                            {
                                double price = rd.GetDouble(1);
                                string t = price.ToString();
                                textBox11.Text = t;
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }*/

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox22.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
            //        MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox10.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox22.Checked)
            {
                textBox10.Text = "";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox23.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
             //       MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox9.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox23.Checked)
            {
                textBox9.Text = "";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox24.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
            //        MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox8.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox24.Checked)
            {
                textBox8.Text = "";
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox25.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
          //          MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox7.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox25.Checked)
            {
                textBox7.Text = "";
            }
        }

        /*     private void checkBox15_CheckedChanged(object sender, EventArgs e)
             {
                 if (checkBox16.Checked)
                 {
                     string que = "SELECT * from cus_cat_package where name = '" + checkBox16.Text + "'";

                     SqlCommand cd = new SqlCommand(que, con);

                     SqlDataReader rd;

                     try
                     {
                         con.Open();
                         rd = cd.ExecuteReader();
                         MessageBox.Show("Deleted");

                         while (rd.Read())
                         {
                             double price = rd.GetDouble(1);
                             string t = price.ToString();
                             textBox16.Text = t;
                         }

                         con.Close();
                     }

                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message);
                     }
                 }
                 else if (!checkBox.Checked)
                 {
                     textBox3.Text = "";
                 }
             }*/

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox16.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
         //           MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox16.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox16.Checked)
            {
                textBox16.Text = "";
            }
        }

        private void checkBox17_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox17.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
        //            MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox14.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox17.Checked)
            {
                textBox14.Text = "";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox18.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
        //            MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox13.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox18.Checked)
            {
                textBox13.Text = "";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox19.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
       //             MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox12.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox19.Checked)
            {
                textBox12.Text = "";
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox1.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
        //            MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox27.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox1.Checked)
            {
                textBox27.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox2.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
         //           MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox26.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox2.Checked)
            {
                textBox26.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox3.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
        //            MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox25.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox3.Checked)
            {
                textBox25.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox4.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
         //           MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox23.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox4.Checked)
            {
                textBox23.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox4.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
         //           MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox23.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox4.Checked)
            {
                textBox23.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox5.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
          //          MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox28.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox5.Checked)
            {
                textBox28.Text = "";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox9.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
          //          MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox21.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox9.Checked)
            {
                textBox21.Text = "";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox10.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
          //          MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox20.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox10.Checked)
            {
                textBox20.Text = "";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox11.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
        //            MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox19.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox11.Checked)
            {
                textBox19.Text = "";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox12.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
       //             MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox18.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBox12.Checked)
            {
                textBox18.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkBox26.Checked && !checkBox27.Checked && !checkBox28.Checked && !checkBox29.Checked)
            {
                MessageBox.Show("Appertizer Coloumn Needs to be filled");
            }
            else if (!checkBox22.Checked && !checkBox23.Checked && !checkBox24.Checked && !checkBox25.Checked)
            {
                MessageBox.Show("At least One Rice type needs to be selected");
            }
            else if (!checkBox16.Checked && !checkBox16.Checked && !checkBox17.Checked && !checkBox18.Checked && !checkBox19.Checked)
            {
                MessageBox.Show("At leasr one curry need to be selected");
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                MessageBox.Show("At least one devel needs to be selected");
            }
            else if (!checkBox9.Checked && !checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked)
            {
                MessageBox.Show("At least one dessert need to be selected");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Select a package first.");
            }
            else
            {

                //Appertizer List

                if (checkBox26.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox28.Checked)// || checkBox27.Checked || checkBox28.Checked || checkBox29.Checked || checkBox30.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox28.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox29.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox28.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox28.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox28.Text + " , " + checkBox29.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox28.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox28.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox27.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox27.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox26.Checked && checkBox27.Checked && checkBox28.Checked && checkBox29.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Appetizer = '" + checkBox26.Text + " , " + checkBox27.Text + " , " + checkBox28.Text + " , " + checkBox29.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }

                //Rice List

                if (checkBox22.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox24.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox25.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                else if (checkBox22.Checked && checkBox23.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox24.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox24.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox24.Text + " , " + checkBox25.Text + " ' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox24.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox23.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox22.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox23.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Rice = '" + checkBox2.Checked + " , " + checkBox23.Text + " , " + checkBox24.Text + " , " + checkBox25.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }


                //Curry List

                if (checkBox16.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox18.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox18.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox18.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + " , " + checkBox18.Checked + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox17.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox17.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox17.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked && checkBox19.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Curries = '" + checkBox16.Text + " ," + checkBox17.Text + " , " + checkBox18.Text + " , " + checkBox19.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }


                //Devel List


                if (checkBox1.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox16.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Devels = '" + checkBox1.Text + " , " + checkBox2.Text + " , " + checkBox3.Text + " , " + checkBox4.Text + " , " + checkBox5.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }

                //dessert list

                if (checkBox9.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked && checkBox13.Checked)
                {
                    con.Open();
                    SqlCommand cd = con.CreateCommand();
                    cd.CommandType = CommandType.Text;
                    cd.CommandText = "UPDATE catering_Package SET Dessert = '" + checkBox9.Text + " , " + checkBox10.Text + " , " + checkBox11.Text + " , " + checkBox12.Text + " , " + checkBox13.Text + "' WHERE package_Name = '" + comboBox1.Text + "';";
                    cd.ExecuteNonQuery();
                    con.Close();
                }

                if (checkBox22.Checked)
                {
                    r22 = checkBox22.Text;

                }
                if (checkBox23.Checked)
                {
                    r23 = checkBox23.Text;
                }
                if (checkBox24.Checked)
                {
                    r24 = checkBox24.Text;
                }
                if (checkBox25.Checked)
                {
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;

                }
                if (checkBox22.Checked && checkBox24.Checked)
                {
                    r22 = checkBox22.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox22.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox23.Checked && checkBox24.Checked)
                {
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox23.Checked && checkBox25.Checked)
                {
                    r23 = checkBox23.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox24.Checked && checkBox25.Checked)
                {
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }
                if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked && checkBox25.Checked)
                {
                    r22 = checkBox22.Text;
                    r23 = checkBox23.Text;
                    r24 = checkBox24.Text;
                    r25 = checkBox25.Text;
                }

                // comboBox1.Text = "";
                c26 = textBox1.Text;
                c27 = textBox2.Text;
                c28 = textBox3.Text;
                c29 = textBox4.Text;
                c22 = textBox10.Text;
                c23 = textBox9.Text;
                c24 = textBox8.Text;
                c25 = textBox7.Text;
                c16 = textBox16.Text;
                c17 = textBox14.Text;
                c18 = textBox13.Text;
                c19 = textBox12.Text;
                c1 = textBox27.Text;
                c2 = textBox26.Text;
                c3 = textBox25.Text;
                c4 = textBox23.Text;
                c5 = textBox28.Text;
                c9 = textBox21.Text;
                c10 = textBox20.Text;
                c11 = textBox19.Text;
                c12 = textBox18.Text;
                c13 = textBox17.Text;
                t1 = comboBox1.Text;

                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
            }

        }

        private void packageName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1Ravindu fm1 = new Form1Ravindu();
            fm1.Show();

        }

        ErrorProvider e1 = new ErrorProvider();
        bool isValidated;

        private void packageName_Validating(object sender, CancelEventArgs e)
        {

        }

        /*private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                string que = "SELECT * from cus_cat_package where name = '" + checkBox13.Text + "'";

                SqlCommand cd = new SqlCommand(que, con);

                SqlDataReader rd;

                try
                {
                    con.Open();
                    rd = cd.ExecuteReader();
                    MessageBox.Show("Deleted");

                    while (rd.Read())
                    {
                        double price = rd.GetDouble(1);
                        string t = price.ToString();
                        textBox17.Text = t;
                    }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }*/






    }
}


