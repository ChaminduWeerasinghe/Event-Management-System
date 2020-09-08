/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form3Ravindu : Form
    {
        public Form3Ravindu()
        {
            InitializeComponent();
        }
    }
}*/

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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=msi\sqlexpress;Initial Catalog=Inventory2;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        /*        void FillCombo1()
                {
                    string que = "SELECT * from cus_cat_package";

                    SqlCommand cmd = new SqlCommand(que, con);

                    SqlDataReader rd;

                    try
                    {
                        con.Open();
                        rd = cmd.ExecuteReader();
                        MessageBox.Show("Deleted");

                        while (rd.Read())
                        {
                            comboBox1.Items.Add(rd.GetString(2));
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                void FillCombo2()
                {
                    string que = "SELECT * from cus_cat_package";

                    SqlCommand cmd = new SqlCommand(que, con);

                    SqlDataReader rd;

                    try
                    {
                        con.Open();
                        rd = cmd.ExecuteReader();
                        MessageBox.Show("Deleted");

                        while (rd.Read())
                        {
                            comboBox2.Items.Add(rd.GetString(2));
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                      void FillCombo()
                      {
                          con.Open();
                          SqlCommand cmd = con.CreateCommand();
                          cmd.CommandType = CommandType.Text;
                          cmd.CommandText = "SELECT ";
                          cmd.ExecuteNonQuery();
                          con.Close();

                          MessageBox.Show("record successfully deleted");
                      }

                private void label1_Click(object sender, EventArgs e)
                {

                }

                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {
                    string que = "SELECT * from cus_cat_package where name = '" + comboBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(que, con);

                    SqlDataReader rd;

                    try
                    {
                        con.Open();
                        rd = cmd.ExecuteReader();
                        MessageBox.Show("Deleted");

                        while (rd.Read())
                        {
                            string price = rd.GetDouble(1).ToString();
                            textBox4.Text = price;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
                {
                    string que = "SELECT * from cus_cat_package where name = '" + comboBox2.Text + "'";

                    SqlCommand cmd = new SqlCommand(que, con);

                    SqlDataReader rd;

                    try
                    {
                        con.Open();
                        rd = cmd.ExecuteReader();
                        MessageBox.Show("Deleted");

                        while (rd.Read())
                        {
                            string price = rd.GetDouble(1).ToString();
                            textBox5.Text = price;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }*/

        public float platePrice()
        {
            string s1 = Form2Ravindu.c1;
            string s2 = Form2Ravindu.c2;
            string s3 = Form2Ravindu.c3;
            string s4 = Form2Ravindu.c4;
            string s5 = Form2Ravindu.c5;
            string s9 = Form2Ravindu.c9;
            string s10 = Form2Ravindu.c10;
            string s11 = Form2Ravindu.c11;
            string s12 = Form2Ravindu.c12;
            string s13 = Form2Ravindu.c13;
            string s16 = Form2Ravindu.c16;
            string s17 = Form2Ravindu.c17;
            string s18 = Form2Ravindu.c18;
            string s19 = Form2Ravindu.c19;
            string s22 = Form2Ravindu.c22;
            string s23 = Form2Ravindu.c23;
            string s24 = Form2Ravindu.c24;
            string s25 = Form2Ravindu.c25;
            string s26 = Form2Ravindu.c26;
            string s27 = Form2Ravindu.c27;
            string s28 = Form2Ravindu.c28;
            string s29 = Form2Ravindu.c29;

            float i1, i2, i3, i4, i5, i9, i10, i11, i12, i19, i18, i17, i16, i13, i22, i23, i24, i25, i26, i27, i28, i29;

            /*           i1 = float.Parse(s1);
                       i2 = float.Parse(s2);
                       i3 = float.Parse(s3);
                       i4 = float.Parse(s4);
                       i5 = float.Parse(s5);
                       i9 = float.Parse(s9);
                       i10 = float.Parse(s10);
                       i11 = float.Parse(s11);
                       i12 = float.Parse(s12);
                       i13 = float.Parse(s13);
                       i16 = float.Parse(s16);
                       i17 = float.Parse(s17);
                       i18 = float.Parse(s18);
                       i19 = float.Parse(s19);
                       i22 = float.Parse(s22);
                       i23 = float.Parse(s23);
                       i24 = float.Parse(s24);
                       i25 = float.Parse(s25);
                       i26= float.Parse(s26);
                       i27 = float.Parse(s27);
                       i28 = float.Parse(s28);
                       i29 = float.Parse(s29);
                       */
            float avg, f1 = 0, f2 = 0, a = 0, r = 0, dv = 0, c = 0, de = 0;
            //  string n1 = textBox4.Text;
            //  string n2 = textBox5.Text;
            // f1 = float.Parse(n1);

            if (Form2Ravindu.c26 != "")
            {
                i26 = float.Parse(s26);
                a = i26;
            }
            if (Form2Ravindu.c27 != "")
            {
                i27 = float.Parse(s27);
                a = i27;
            }
            if (Form2Ravindu.c28 != "")// || checkBox27.Checked || checkBox28.Checked || checkBox29.Checked || checkBox30.Checked)
            {
                i28 = float.Parse(s28);
                a = i28;
            }
            if (Form2Ravindu.c29 != "")
            {
                i29 = float.Parse(s29);
                a = i29;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c27 != "")
            {
                i26 = float.Parse(s26);
                i27 = float.Parse(s27);
                a = i26 + i27;

            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c28 != "")
            {
                i26 = float.Parse(s26);
                i28 = float.Parse(s28);
                a = i26 + i28;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c29 != "")
            {
                i26 = float.Parse(s26);
                i29 = float.Parse(s29);
                a = i26 + i29;
            }
            if (Form2Ravindu.c27 != "" && Form2Ravindu.c28 != "")
            {
                i27 = float.Parse(s27);
                i28 = float.Parse(s28);
                a = i27 + i28;
            }
            if (Form2Ravindu.c27 != "" && Form2Ravindu.c29 != "")
            {
                i27 = float.Parse(s27);
                i29 = float.Parse(s29);
                a = i27 + i29;
            }
            if (Form2Ravindu.c28 != "" && Form2Ravindu.c29 != "")
            {
                i28 = float.Parse(s28);
                i29 = float.Parse(s29);
                a = i28 + i29;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c27 != "" && Form2Ravindu.c28 != "")
            {
                i26 = float.Parse(s26);
                i27 = float.Parse(s27);
                i28 = float.Parse(s28);
                a = i26 + i27 + i28;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c27 != "" && Form2Ravindu.c29 != "")
            {
                i26 = float.Parse(s26);
                i27 = float.Parse(s27);
                i29 = float.Parse(s29);
                a = i26 + i27 + i29;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c28 != "" && Form2Ravindu.c29 != "")
            {
                i26 = float.Parse(s26);
                i28 = float.Parse(s28);
                i29 = float.Parse(s29);
                a = i26 + i28 + i29;
            }
            if (Form2Ravindu.c27 != "" && Form2Ravindu.c28 != "" && Form2Ravindu.c29 != "")
            {
                i27 = float.Parse(s27);
                i28 = float.Parse(s28);
                i29 = float.Parse(s29);
                a = i28 + i27 + i29;
            }
            if (Form2Ravindu.c26 != "" && Form2Ravindu.c27 != "" && Form2Ravindu.c28 != "" && Form2Ravindu.c29 != "")
            {
                i26 = float.Parse(s26);
                i27 = float.Parse(s27);
                i28 = float.Parse(s28);
                i29 = float.Parse(s29);
                a = i28 + i26 + i27 + i29;
            }

            //Rice List

            if (Form2Ravindu.c22 != "")
            {
                i22 = float.Parse(s22);
                r = i22;
            }
            if (Form2Ravindu.c23 != "")
            {
                i23 = float.Parse(s23);
                r = i23;
            }
            if (Form2Ravindu.c24 != "")
            {
                i24 = float.Parse(s24);
                r = i24;
            }
            if (Form2Ravindu.c25 != "")
            {
                i25 = float.Parse(s25);
                r = i25;
            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c23 != "")
            {
                i22 = float.Parse(s22);
                i23 = float.Parse(s23);
                r = i22 + i23;

            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c24 != "")
            {
                i22 = float.Parse(s22);
                i24 = float.Parse(s24);
                r = i22 + i24;

            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c25 != "")
            {
                i22 = float.Parse(s22);
                i25 = float.Parse(s25);
                r = i22 + i25;

            }
            if (Form2Ravindu.c24 != "" && Form2Ravindu.c23 != "")
            {
                i24 = float.Parse(s24);
                i23 = float.Parse(s23);
                r = i24 + i23;

            }
            if (Form2Ravindu.c25 != "" && Form2Ravindu.c23 != "")
            {
                i25 = float.Parse(s25);
                i23 = float.Parse(s23);
                r = i25 + i23;

            }
            if (Form2Ravindu.c24 != "" && Form2Ravindu.c25 != "")
            {
                i24 = float.Parse(s24);
                i25 = float.Parse(s25);
                r = i24 + i25;

            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c23 != "" && Form2Ravindu.c24 != "")
            {
                i22 = float.Parse(s22);
                i23 = float.Parse(s23);
                i24 = float.Parse(s24);
                r = i22 + i23 + i24;
            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c23 != "" && Form2Ravindu.c25 != "")
            {
                i22 = float.Parse(s22);
                i23 = float.Parse(s23);
                i25 = float.Parse(s25);
                r = i22 + i23 + i25;
            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c25 != "" && Form2Ravindu.c24 != "")
            {
                i22 = float.Parse(s22);
                i25 = float.Parse(s25);
                i24 = float.Parse(s24);
                r = i22 + i25 + i24;
            }
            if (Form2Ravindu.c25 != "" && Form2Ravindu.c23 != "" && Form2Ravindu.c24 != "")
            {
                i25 = float.Parse(s25);
                i23 = float.Parse(s23);
                i24 = float.Parse(s24);
                r = i25 + i23 + i24;
            }
            if (Form2Ravindu.c22 != "" && Form2Ravindu.c23 != "" && Form2Ravindu.c24 != "" && Form2Ravindu.c25 != "")
            {
                i22 = float.Parse(s22);
                i23 = float.Parse(s23);
                i24 = float.Parse(s24);
                i25 = float.Parse(s25);
                r = i22 + i23 + i24 + i25;
            }

            //Curry List

            if (Form2Ravindu.c16 != "")
            {
                i16 = float.Parse(s16);
                c = i16;
            }
            if (Form2Ravindu.c17 != "")
            {
                i17 = float.Parse(s17);
                c = i17;
            }
            if (Form2Ravindu.c18 != "")
            {
                i18 = float.Parse(s18);
                c = i18;
            }
            if (Form2Ravindu.c19 != "")
            {
                i19 = float.Parse(s19);
                c = i19;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c17 != "")
            {
                i16 = float.Parse(s16);
                i17 = float.Parse(s17);
                c = i16 + i17;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c18 != "")
            {
                i16 = float.Parse(s16);
                i18 = float.Parse(s18);
                c = i16 + i18;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c19 != "")
            {
                i16 = float.Parse(s16);
                i19 = float.Parse(s19);
                c = i16 + i19;
            }
            if (Form2Ravindu.c17 != "" && Form2Ravindu.c18 != "")
            {
                i18 = float.Parse(s18);
                i17 = float.Parse(s17);
                c = i18 + i17;
            }
            if (Form2Ravindu.c19 != "" && Form2Ravindu.c17 != "")
            {
                i19 = float.Parse(s19);
                i17 = float.Parse(s17);
                c = i19 + i17;
            }
            if (Form2Ravindu.c18 != "" && Form2Ravindu.c19 != "")
            {
                i18 = float.Parse(s18);
                i19 = float.Parse(s19);
                c = i18 + i19;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c17 != "" && Form2Ravindu.c18 != "")
            {
                i16 = float.Parse(s16);
                i17 = float.Parse(s17);
                i18 = float.Parse(s18);
                c = i16 + i17 + i18;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c17 != "" && Form2Ravindu.c19 != "")
            {
                i16 = float.Parse(s16);
                i17 = float.Parse(s17);
                i19 = float.Parse(s19);
                c = i16 + i17 + i19;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c19 != "" && Form2Ravindu.c18 != "")
            {
                i16 = float.Parse(s16);
                i19 = float.Parse(s19);
                i18 = float.Parse(s18);
                c = i16 + i19 + i18;
            }
            if (Form2Ravindu.c19 != "" && Form2Ravindu.c17 != "" && Form2Ravindu.c18 != "")
            {
                i19 = float.Parse(s19);
                i17 = float.Parse(s17);
                i18 = float.Parse(s18);
                c = i19 + i17 + i18;
            }
            if (Form2Ravindu.c16 != "" && Form2Ravindu.c17 != "" && Form2Ravindu.c18 != "" && Form2Ravindu.c19 != "")
            {
                i16 = float.Parse(s16);
                i17 = float.Parse(s17);
                i18 = float.Parse(s18);
                i19 = float.Parse(s19);
                c = i16 + i17 + i18 + i19;
            }


            //Devel List


            if (Form2Ravindu.c1 != "")
            {
                i1 = float.Parse(s1);
                dv = i1;
            }
            if (Form2Ravindu.c1 != "")
            {
                i2 = float.Parse(s2);
                dv = i2;
            }
            if (Form2Ravindu.c1 != "")
            {
                i3 = float.Parse(s3);
                dv = i3;
            }
            if (Form2Ravindu.c4 != "")
            {
                i4 = float.Parse(s4);
                dv = i4;
            }
            if (Form2Ravindu.c5 != "")
            {
                i5 = float.Parse(s5);
                dv = i5;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                dv = i1 + i2;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c3 != "")
            {
                i1 = float.Parse(s1);
                i3 = float.Parse(s3);
                dv = i1 + i3;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c4 != "")
            {
                i1 = float.Parse(s1);
                i4 = float.Parse(s4);
                dv = i1 + i4;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c5 != "")
            {
                i1 = float.Parse(s1);
                i5 = float.Parse(s5);
                dv = i1 + i5;
            }
            if (Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "")
            {
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                dv = i2 + i3;
            }
            if (Form2Ravindu.c4 != "" && Form2Ravindu.c2 != "")
            {
                i4 = float.Parse(s4);
                i2 = float.Parse(s2);
                dv = i4 + i2;
            }
            if (Form2Ravindu.c5 != "" && Form2Ravindu.c2 != "")
            {
                i5 = float.Parse(s5);
                i2 = float.Parse(s2);
                dv = i5 + i2;
            }
            if (Form2Ravindu.c3 != "" && Form2Ravindu.c4 != "")
            {
                i3 = float.Parse(s3);
                i4 = float.Parse(s4);
                dv = i3 + i4;
            }
            if (Form2Ravindu.c3 != "" && Form2Ravindu.c5 != "")
            {
                i3 = float.Parse(s3);
                i5 = float.Parse(s5);
                dv = i3 + i5;
            }
            if (Form2Ravindu.c4 != "" && Form2Ravindu.c5 != "")
            {
                i4 = float.Parse(s4);
                i5 = float.Parse(s5);
                dv = i4 + i5;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                dv = i1 + i2 + i3;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c4 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i4 = float.Parse(s4);
                dv = i1 + i2 + i4;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c5 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i5 = float.Parse(s5);
                dv = i1 + i2 + i5;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c4 != "" && Form2Ravindu.c3 != "")
            {
                i1 = float.Parse(s1);
                i4 = float.Parse(s4);
                i3 = float.Parse(s3);
                dv = i1 + i4 + i3;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c5 != "" && Form2Ravindu.c3 != "")
            {
                i1 = float.Parse(s1);
                i5 = float.Parse(s5);
                i3 = float.Parse(s3);
                dv = i1 + i5 + i3;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c4 != "" && Form2Ravindu.c5 != "")
            {
                i1 = float.Parse(s1);
                i4 = float.Parse(s4);
                i5 = float.Parse(s5);
                dv = i1 + i4 + i5;
            }
            if (Form2Ravindu.c4 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "")
            {
                i4 = float.Parse(s4);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                dv = i4 + i2 + i3;
            }
            if (Form2Ravindu.c5 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "")
            {
                i5 = float.Parse(s5);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                dv = i5 + i2 + i3;
            }
            if (Form2Ravindu.c2 != "" && Form2Ravindu.c4 != "" && Form2Ravindu.c5 != "")
            {
                i4 = float.Parse(s4);
                i2 = float.Parse(s2);
                i5 = float.Parse(s5);
                dv = i4 + i2 + i5;
            }
            if (Form2Ravindu.c4 != "" && Form2Ravindu.c5 != "" && Form2Ravindu.c3 != "")
            {
                i5 = float.Parse(s5);
                i4 = float.Parse(s4);
                i3 = float.Parse(s3);
                dv = i5 + i4 + i3;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "" && Form2Ravindu.c4 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                i4 = float.Parse(s4);
                dv = i1 + i2 + i3 + i4;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "" && Form2Ravindu.c5 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                i5 = float.Parse(s5);
                dv = i1 + i2 + i3 + i5;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c5 != "" && Form2Ravindu.c4 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i5 = float.Parse(s5);
                i4 = float.Parse(s4);
                dv = i1 + i2 + i5 + i4;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c5 != "" && Form2Ravindu.c3 != "" && Form2Ravindu.c4 != "")
            {
                i1 = float.Parse(s1);
                i5 = float.Parse(s5);
                i3 = float.Parse(s3);
                i4 = float.Parse(s4);
                dv = i1 + i5 + i3 + i4;
            }
            if (Form2Ravindu.c5 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "" && Form2Ravindu.c4 != "")
            {
                i5 = float.Parse(s5);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                i4 = float.Parse(s4);
                dv = i5 + i2 + i3 + i4;
            }
            if (Form2Ravindu.c1 != "" && Form2Ravindu.c2 != "" && Form2Ravindu.c3 != "" && Form2Ravindu.c4 != "" && Form2Ravindu.c5 != "")
            {
                i1 = float.Parse(s1);
                i2 = float.Parse(s2);
                i3 = float.Parse(s3);
                i4 = float.Parse(s4);
                i5 = float.Parse(s5);
                dv = i1 + i2 + i3 + i4 + i5;
            }


            //dessert list

            if (Form2Ravindu.c9 != "")
            {
                i9 = float.Parse(s9);
                de = i9;
            }
            if (Form2Ravindu.c10 != "")
            {
                i10 = float.Parse(s10);
                de = i10;
            }
            if (Form2Ravindu.c11 != "")
            {
                i11 = float.Parse(s11);
                de = i11;
            }
            if (Form2Ravindu.c12 != "")
            {
                i12 = float.Parse(s12);
                de = i12;
            }
            if (Form2Ravindu.c13 != "")
            {
                i13 = float.Parse(s13);
                de = i13;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                de = i9 + i10;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c11 != "")
            {
                i9 = float.Parse(s9);
                i11 = float.Parse(s11);
                de = i9 + i11;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c12 != "")
            {
                i9 = float.Parse(s9);
                i12 = float.Parse(s12);
                de = i9 + i12;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i13 = float.Parse(s13);
                de = i9 + i13;
            }
            if (Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "")
            {
                i11 = float.Parse(s11);
                i10 = float.Parse(s10);
                de = i11 + i10;
            }
            if (Form2Ravindu.c12 != "" && Form2Ravindu.c10 != "")
            {
                i12 = float.Parse(s12);
                i10 = float.Parse(s10);
                de = i12 + i10;
            }
            if (Form2Ravindu.c13 != "" && Form2Ravindu.c10 != "")
            {
                i13 = float.Parse(s13);
                i10 = float.Parse(s10);
                de = i13 + i10;
            }
            if (Form2Ravindu.c11 != "" && Form2Ravindu.c12 != "")
            {
                i11 = float.Parse(s11);
                i12 = float.Parse(s12);
                de = i11 + i12;
            }
            if (Form2Ravindu.c11 != "" && Form2Ravindu.c13 != "")
            {
                i11 = float.Parse(s11);
                i13 = float.Parse(s13);
                de = i11 + i13;
            }
            if (Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i12 = float.Parse(s12);
                i13 = float.Parse(s13);
                de = i12 + i13;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i11 = float.Parse(s11);
                de = i9 + i10 + i11;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c12 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i12 = float.Parse(s12);
                de = i9 + i10 + i12;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i13 = float.Parse(s13);
                de = i9 + i10 + i13;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c11 != "")
            {
                i9 = float.Parse(s9);
                i12 = float.Parse(s12);
                i11 = float.Parse(s11);
                de = i9 + i12 + i11;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c13 != "" && Form2Ravindu.c11 != "")
            {
                i9 = float.Parse(s9);
                i13 = float.Parse(s13);
                i11 = float.Parse(s11);
                de = i9 + i13 + i11;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i12 = float.Parse(s12);
                i13 = float.Parse(s13);
                de = i9 + i12 + i12;
            }
            if (Form2Ravindu.c12 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "")
            {
                i12 = float.Parse(s12);
                i10 = float.Parse(s10);
                i11 = float.Parse(s11);
                de = i12 + i10 + i11;
            }
            if (Form2Ravindu.c13 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "")
            {
                i13 = float.Parse(s13);
                i10 = float.Parse(s10);
                i11 = float.Parse(s11);
                de = i13 + i10 + i11;
            }
            if (Form2Ravindu.c13 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c12 != "")
            {
                i12 = float.Parse(s12);
                i10 = float.Parse(s10);
                i13 = float.Parse(s13);
                de = i12 + i10 + i13;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "" && Form2Ravindu.c12 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i11 = float.Parse(s11);
                i12 = float.Parse(s12);
                de = i9 + i10 + i11 + i12;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i11 = float.Parse(s11);
                i13 = float.Parse(s13);
                de = i9 + i10 + i11 + i13;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i13 = float.Parse(s13);
                i12 = float.Parse(s12);
                de = i9 + i10 + i13 + i12;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c11 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i11 = float.Parse(s11);
                i13 = float.Parse(s13);
                i12 = float.Parse(s12);
                de = i9 + i11 + i13 + i12;
            }
            if (Form2Ravindu.c11 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i11 = float.Parse(s11);
                i10 = float.Parse(s10);
                i13 = float.Parse(s13);
                i12 = float.Parse(s12);
                de = i11 + i10 + i13 + i12;
            }
            if (Form2Ravindu.c9 != "" && Form2Ravindu.c10 != "" && Form2Ravindu.c11 != "" && Form2Ravindu.c12 != "" && Form2Ravindu.c13 != "")
            {
                i9 = float.Parse(s9);
                i10 = float.Parse(s10);
                i13 = float.Parse(s13);
                i12 = float.Parse(s12);
                i11 = float.Parse(s11);
                de = i9 + i10 + i11 + i13 + i12;
            }

            //there is a problem in here inserting only one value
            float f4 = r / 2;
            float f3 = a + f4 + c + dv + de;

            // f2 = float.Parse(n2);
            /*
            if (f1 == 0)
            {
                return f2 + f3;
            }
            else if (f2 == 0)
            {
                return f1 + f3;
            }
            else
            {*/
            //  return avg =  ((f1 + f2) / 2) + f3;
            return f3;
            //}
        }

        public float pkgPrize()
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            float f1 = float.Parse(s1);
            float f2 = float.Parse(s2);

            return f1 * f2;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float n1 = platePrice();
            string s1 = n1.ToString();

            textBox2.Text = s1;

            float f1 = pkgPrize();
            string s2 = f1.ToString();

            textBox3.Text = s2;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            if (Form2Ravindu.r22 != "")
            {
                textBox8.Text = Form2Ravindu.r22;
                if (textBox8.Text != "")
                {

                    string que = "SELECT * from cus_cat_package where name = '" + textBox8.Text + "'";

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
                            textBox4.Text = t;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox8.Text == "")
                {
                    textBox4.Text = "";
                }
            }
            if (Form2Ravindu.r23 != "")
            {
                textBox9.Text = Form2Ravindu.r23;
                if (textBox9.Text != "")
                {

                    string que = "SELECT * from cus_cat_package where name = '" + textBox9.Text + "'";

                    SqlCommand cd = new SqlCommand(que, con);

                    SqlDataReader rd;

                    try
                    {
                        con.Open();
                        rd = cd.ExecuteReader();
                        //  MessageBox.Show("Deleted");

                        while (rd.Read())
                        {
                            double price = rd.GetDouble(1);
                            string t = price.ToString();
                            textBox5.Text = t;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox9.Text == "")
                {
                    textBox5.Text = "";
                }
            }
            if (Form2Ravindu.r24 != "")
            {
                textBox10.Text = Form2Ravindu.r24;
                if (textBox10.Text != "")
                {

                    string que = "SELECT * from cus_cat_package where name = '" + textBox10.Text + "'";

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
                            textBox6.Text = t;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox10.Text == "")
                {
                    textBox6.Text = "";
                }
            }
            if (Form2Ravindu.r25 != "")
            {
                textBox11.Text = Form2Ravindu.r25;
                if (textBox11.Text != "")
                {

                    string que = "SELECT * from cus_cat_package where name = '" + textBox9.Text + "'";

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
                            textBox7.Text = t;
                        }

                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (textBox11.Text == "")
                {
                    textBox7.Text = "";
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1Ravindu fm1 = new Form1Ravindu();
            fm1.Show();
        }

        ErrorProvider e1 = new ErrorProvider();
        bool isValidated;

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox8.Text, @"^([A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^$"))
            {
                e1.SetError(textBox8, "Enter Letters.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox8, null);
            }
        }

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

        private void Form3_Load_1(object sender, EventArgs e)
        {


                if (Form2Ravindu.r22 != "")
                {
                    textBox8.Text = Form2Ravindu.r22;
                    if (textBox8.Text != "")
                    {

                        string que = "SELECT * from cus_cat_package where name = '" + textBox8.Text + "'";

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
                                textBox4.Text = t;
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (textBox8.Text == "")
                    {
                        textBox4.Text = "";
                    }
                }
                if (Form2Ravindu.r23 != "")
                {
                    textBox9.Text = Form2Ravindu.r23;
                    if (textBox9.Text != "")
                    {

                        string que = "SELECT * from cus_cat_package where name = '" + textBox9.Text + "'";

                        SqlCommand cd = new SqlCommand(que, con);

                        SqlDataReader rd;

                        try
                        {
                            con.Open();
                            rd = cd.ExecuteReader();
                            //  MessageBox.Show("Deleted");

                            while (rd.Read())
                            {
                                double price = rd.GetDouble(1);
                                string t = price.ToString();
                                textBox5.Text = t;
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (textBox9.Text == "")
                    {
                        textBox5.Text = "";
                    }
                }
                if (Form2Ravindu.r24 != "")
                {
                    textBox10.Text = Form2Ravindu.r24;
                    if (textBox10.Text != "")
                    {

                        string que = "SELECT * from cus_cat_package where name = '" + textBox10.Text + "'";

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
                                textBox6.Text = t;
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (textBox10.Text == "")
                    {
                        textBox6.Text = "";
                    }
                }
                if (Form2Ravindu.r25 != "")
                {
                    textBox11.Text = Form2Ravindu.r25;
                    if (textBox11.Text != "")
                    {

                        string que = "SELECT * from cus_cat_package where name = '" + textBox9.Text + "'";

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
                                textBox7.Text = t;
                            }

                            con.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (textBox11.Text == "")
                    {
                        textBox7.Text = "";
                    }
                }
            }

        private void button2_Click_1(object sender, EventArgs e)
        {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE catering_Package SET package_price = " + textBox3.Text + " WHERE package_Name = '" + Form2Ravindu.t1 + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated the package price");
            
        }



        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox9.Text, @"^([A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^$"))
            {
                e1.SetError(textBox9, "Enter Letters.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox9, null);
            }
        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox10.Text, @"^([A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^$"))
            {
                e1.SetError(textBox10, "Enter Letters.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox10, null);
            }
        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox11.Text, @"^([A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^$"))
            {
                e1.SetError(textBox11, "Enter Letters.");
                isValidated = false;
            }
            else
            {
                isValidated = true;
                e1.SetError(textBox11, null);
            }
        }
    }
    }

