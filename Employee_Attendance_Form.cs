using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.supportiveClasses;

namespace InventorySystem
{
    public partial class Employee_Attendance_Form : Form
    {
        //Must do the employee First name part. 
        Employee employee = new Employee();
        EmployeeImpl empI = new EmployeeImpl();

        public Employee_Attendance_Form()
        {
            InitializeComponent();
            showID();
        }

        private void Emp_att_add_Click(object sender, EventArgs e)
        {
            if (ID_combo.Text == "") 
            {
                MessageBox.Show("Select an Employee.");
            }
            else if (emp_att_status.Text == "")
            {
                MessageBox.Show("Select the Attendance Status.");
            }
            else if (emp_att_date.Text == "")
            {
                MessageBox.Show("Date field Cannot be empty. Select the date.");
            }
            else if (emp_att_chInTime.Text == "")
            {
                MessageBox.Show("Enter the Employee in time.");
            }
            else if (emp_att_chOutTime.Text == "")
            {
                MessageBox.Show("Enter the Employee out time.");
            }
            else if (ID_combo.Text == "" || emp_att_status.Text == "" || emp_att_date.Text == "" || emp_att_chInTime.Text == "" || emp_att_chOutTime.Text == "")
            {
                MessageBox.Show("Please Fill the required Fields.");
            }
            else
            { 
                employee.empId = ID_combo.Text;
                employee.empFName = fname_txt.Text;
                employee.status = emp_att_status.Text;
                employee.sDate = emp_att_date.Text;
                employee.inTime = emp_att_chInTime.Text;
                employee.outTime = emp_att_chOutTime.Text;

                bool isCorrect = empI.EmployeeAttendance(employee);

                if (isCorrect == true)
                {
                    MessageBox.Show("Attendance Record Has been Added Successfully.");
                    clearDet();
                }
                else
                {
                    MessageBox.Show("Error Occured.");
                }
            }
        }

        private void Emp_att_clear_Click(object sender, EventArgs e)
        {
            clearDet();
        }

        public void showID()
        {
            ArrayList arr = new ArrayList();
            arr = empI.GetEmployeeIDs();

            ID_combo.Items.Clear();

            foreach (string line in arr)
            {
                ID_combo.Items.Add(line);
            }
        }

        public void clearDet()
        {
            ID_combo.Text = "";
            fname_txt.Text = "";
            emp_att_status.Text = "";            
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

        private void ID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.empId = ID_combo.Text;
            string fname = empI.GetEmployeeNames(employee);
            fname_txt.Text = fname;
        }
    }
}
