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
using InventorySystem.supportiveClasses;

namespace InventorySystem
{
    public partial class Employee_Details_Form : Form
    {
        bool nicVal = true;
        bool fnameVal = true;
        bool lnameVal = true;
        bool dobVal = true;
        bool genderVal = true;
        bool emailVal = true;
        bool addressVal = true;
        bool contactVal = true;
        bool recDateVal = true;
        bool bSalVal = true;
        bool otRateVal = true;
        private SqlConnection con = Connect.conn();
        Employee employee = new Employee();
        EmployeeImpl empI = new EmployeeImpl();

        public Employee_Details_Form()
        {
            InitializeComponent();
        }

        private void Employee_Details_Form_Load(object sender, EventArgs e)
        {
            DataTable dataTable = empI.selectEmployee();
            emp_list.DataSource = dataTable;
        }
        private void Nic_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(nic_txt.Text, "^([0-9]{9})(v|V)$") || nic_txt.Text.Length != 10)
            {
                
                errorProvider1.SetError(nic_txt, "9 Numbers and the 'V' Letter. Maximum Length is 10");
                nicVal = false;
            }
            else
            {
                nicVal = true;
                errorProvider1.SetError(nic_txt, null);
            }
        }

        private void Emp_fname_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(emp_fname_txt.Text, @"^[a-zA-Z]+$") || emp_fname_txt.Text == "")
            {
                errorProvider1.SetError(emp_fname_txt, "Letters Only. Cannot be Empty");
                fnameVal = false;
            }
            else
            {
                fnameVal = true;
                errorProvider1.SetError(emp_fname_txt, null);
            }
        }

        private void Emp_lname_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(emp_lname_txt.Text, @"^[a-zA-Z]+$") || emp_lname_txt.Text == "")
            {
                errorProvider1.SetError(emp_lname_txt, "Letters Only.");
                lnameVal = false;
            }
            else
            {
                lnameVal = true;
                errorProvider1.SetError(emp_lname_txt, null);
            }
        }

        private void Dob_picker_Validating(object sender, CancelEventArgs e)
        {
            if (dob_picker.Value == null)
            {
                errorProvider1.SetError(dob_picker, "Cannot be Empty.");
                dobVal = false;
            }
            else
            {
                dobVal = true;
                errorProvider1.SetError(dob_picker, null);
            }
        }

        private void Emp_gender_txt_Validating(object sender, CancelEventArgs e)
        {
            if (emp_gender_txt.Text == "")
            {
                errorProvider1.SetError(emp_gender_txt, "Cannot be Empty.");
                genderVal = false;
            }
            else
            {
                genderVal = true;
                errorProvider1.SetError(emp_gender_txt, null);
            }
        }

        private void Email_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(email_txt.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider1.SetError(email_txt, "Must be a Valid Email address.");
                emailVal = false;
            }
            else
            {
                emailVal = true;
                errorProvider1.SetError(email_txt, null);
            }
        }

        private void Address_txt_Validating(object sender, CancelEventArgs e)
        {
            if (address_txt.Text == "")
            {
                errorProvider1.SetError(address_txt, "Cannot Be Empty");
                addressVal = false;
            }
            else
            {
                addressVal = true;
                errorProvider1.SetError(address_txt, null);
            }
        }

        private void Emp_cnum_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(emp_cnum_txt.Text, "^[0-9]*$") || emp_cnum_txt.Text.Length != 10 || emp_cnum_txt.Text == "")
            {
                errorProvider1.SetError(emp_cnum_txt, "Number Only. Maximum length is 10");
                contactVal = false;
            }
            else
            {
                contactVal = true;
                errorProvider1.SetError(emp_cnum_txt, null);
            }
        }

        private void RecruitedDate_picker_Validating(object sender, CancelEventArgs e)
        {
            if (recruitedDate_picker.Value == null)
            { 
                errorProvider1.SetError(recruitedDate_picker, "Cannot be Empty.");
                recDateVal = false;
            }
            else
            {
                recDateVal = true;
                errorProvider1.SetError(recruitedDate_picker, null);
            }
        }

        private void BSal_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(bSal_txt.Text, "^[0-9]*$") || bSal_txt.Text == "")
            {
                errorProvider1.SetError(bSal_txt, "Numbers Only");
                bSalVal = false;
            }
            else
            {
                bSalVal = true;
                errorProvider1.SetError(bSal_txt, null);
            }
        }

        private void Ot_rate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(ot_rate_txt.Text, "^[0-9]*$") || ot_rate_txt.Text == "")
            {
                errorProvider1.SetError(ot_rate_txt, "Numbers Only.");
                otRateVal = false;
            }
            else
            {
                otRateVal = true;
                errorProvider1.SetError(ot_rate_txt, null);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if(nicVal == true && fnameVal == true && lnameVal == true && dobVal == true && genderVal == true && emailVal == true && addressVal == true && contactVal == true && recDateVal == true && bSalVal == true && otRateVal == true)
            {
                employee.nicNo = nic_txt.Text;
                employee.empFName = emp_fname_txt.Text;
                employee.empLName = emp_lname_txt.Text;
                employee.dob = dob_picker.Text;
                employee.empGender = emp_gender_txt.Text;
                employee.empEmail = email_txt.Text;
                employee.empAddress = address_txt.Text;
                employee.empContact = emp_cnum_txt.Text;
                employee.empRecruitedDate = recruitedDate_picker.Text;
                employee.basicSal = double.Parse(bSal_txt.Text);
                employee.otRate = double.Parse(ot_rate_txt.Text);

                bool isCorrect = empI.addEmployee(employee);

                if (isCorrect == true)
                {
                    MessageBox.Show("New Employee Has been Added Successfully");
                    clearDet();
                }
                else
                {
                    MessageBox.Show("Error Occured. Try again.");
                }

                DataTable dataTable = empI.selectEmployee();
                emp_list.DataSource = dataTable;
            }
            else {
                MessageBox.Show("Check '!' Fields & Solve them to Add the Employee Details");
            }
        }

        public void clearDet()
        {
            emp_id_txt.Text = "";
            emp_fname_txt.Text = "";
            emp_lname_txt.Text = "";
            emp_gender_txt.Text = "";
            emp_cnum_txt.Text = "";
            nic_txt.Text = "";
            email_txt.Text = "";
            address_txt.Text = "";
            bSal_txt.Text = "";
            ot_rate_txt.Text = "";
        }

        private void Btn_upd_Click(object sender, EventArgs e)
        {
            if (nicVal == true && fnameVal == true && lnameVal == true && dobVal == true && genderVal == true && emailVal == true && addressVal == true && contactVal == true && recDateVal == true && bSalVal == true && otRateVal == true)
            {              
                employee.empId = emp_id_txt.Text;
                employee.nicNo = nic_txt.Text;
                employee.empFName = emp_fname_txt.Text;
                employee.empLName = emp_lname_txt.Text;
                employee.dob = dob_picker.Text;
                employee.empGender = emp_gender_txt.Text;
                employee.empEmail = email_txt.Text;
                employee.empAddress = address_txt.Text;
                employee.empContact = emp_cnum_txt.Text;
                employee.empRecruitedDate = recruitedDate_picker.Text;
                employee.basicSal = double.Parse(bSal_txt.Text);
                employee.otRate = double.Parse(ot_rate_txt.Text);

                bool isCorrect = empI.updateEmployee(employee);

                if (isCorrect == true)
                {
                    MessageBox.Show("Record has been Updated.");
                    DataTable dataTable = empI.selectEmployee();
                    emp_list.DataSource = dataTable;
                    clearDet();
                }
                else
                {
                    MessageBox.Show("Error Occured.");
                }
            }
            else
            {
                MessageBox.Show("Check '!' Fields & Solve them to Update the Employee Details");
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            employee.empId = emp_id_txt.Text;

            bool isCorrect = empI.removeEmployee(employee);

            if (isCorrect == true)
            {
                MessageBox.Show("Record Has been Deleted.");
                DataTable dataTable = empI.selectEmployee();
                emp_list.DataSource = dataTable;
                clearDet();
            }
            else
            {
                MessageBox.Show("Error Occured.");
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            clearDet();
        }

        private void Emp_list_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowNo = e.RowIndex;

            emp_id_txt.Text = emp_list.Rows[rowNo].Cells[0].Value.ToString();
            nic_txt.Text = emp_list.Rows[rowNo].Cells[1].Value.ToString();
            emp_fname_txt.Text = emp_list.Rows[rowNo].Cells[2].Value.ToString();
            emp_lname_txt.Text = emp_list.Rows[rowNo].Cells[3].Value.ToString();
            dob_picker.Text = emp_list.Rows[rowNo].Cells[4].Value.ToString();
            emp_gender_txt.Text = emp_list.Rows[rowNo].Cells[5].Value.ToString();
            email_txt.Text = emp_list.Rows[rowNo].Cells[6].Value.ToString();
            address_txt.Text = emp_list.Rows[rowNo].Cells[7].Value.ToString();
            emp_cnum_txt.Text = emp_list.Rows[rowNo].Cells[8].Value.ToString();
            recruitedDate_picker.Text = emp_list.Rows[rowNo].Cells[9].Value.ToString();
            bSal_txt.Text = emp_list.Rows[rowNo].Cells[10].Value.ToString();
            ot_rate_txt.Text = emp_list.Rows[rowNo].Cells[11].Value.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = search_txt.Text;
            con.Open();
            DataTable dataTable = new DataTable();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Employee_Det where EmployeeID LIKE '%"+ keyword +"%' FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%'";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            sqlAdapter.Fill(dataTable);
            emp_list.DataSource = dataTable;
            con.Close();
        }

        private void Hme_btn_Click(object sender, EventArgs e)
        {
            Menu nMenu = new Menu();
            this.Hide();
            nMenu.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        
    }
}
