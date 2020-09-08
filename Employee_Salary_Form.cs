using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.supportiveClasses;

namespace InventorySystem
{
    public partial class Employee_Salary_Form : Form
    {
        bool otdaysVal = true;
        bool empIDVal = true;
        bool mntVal = true;
        Employee employee = new Employee();
        EmployeeImpl empI = new EmployeeImpl();
        public Employee_Salary_Form()
        {
            InitializeComponent();
            showID();
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

        private void NEvent_txt_TextChanged(object sender, EventArgs e)
        {
            double bSal = 0;
            double otRt = 0;
            int nEvent = 0;
            double calT = 0;
            double total = 0;
            double etf = 0;
            try
            {
                bSal = double.Parse(bSal_txt.Text);
                otRt = double.Parse(eRate_txt.Text);
            }
            catch (Exception)
            {
                
            }
            if (Int32.TryParse(nEvent_txt.Text, out nEvent))
            {
                calT = bSal + (nEvent * otRt);
            }
            etf = (calT * 8) / 100;
            employee.etf = etf;
            total = calT - etf;

            tSal_txt.Text = total.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clearDet();
        }

        private void NEvent_txt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(nEvent_txt.Text, "^[0-9]*$") || nEvent_txt.Text == "")
            {
                MessageBox.Show("Error Occured in OT Days field.");
                errorProvider1.SetError(nEvent_txt, "Only Numbers and cannot be Empty.");
                otdaysVal = false;
            }
            else
            {
                otdaysVal = true;
                errorProvider1.SetError(nEvent_txt, null);
            }
        }

        private void ID_combo_Validating(object sender, CancelEventArgs e)
        {
            if (ID_combo.Text == "")
            {
                MessageBox.Show("Error Occured in Employee ID field.");
                errorProvider1.SetError(ID_combo, "Employee ID cannot be empty");
                empIDVal = false;
            }
            else
            {
                empIDVal = true;
                errorProvider1.SetError(ID_combo, null);
            }
        }

        private void Month_combo_Validating(object sender, CancelEventArgs e)
        {
            if (month_combo.Text == "")
            {
                MessageBox.Show("Error Occured in Month Field");
                errorProvider1.SetError(month_combo, "Select a month");
                mntVal = false;

            }
            else
            {
                mntVal = true;
                errorProvider1.SetError(month_combo, null);
            }
        }

        private void Add_Det_Click(object sender, EventArgs e)
        {
            if (empIDVal == true && mntVal == true && otdaysVal == true)
            {
                employee.empId = ID_combo.Text;
                employee.empFName = fname_txt.Text;
                employee.month = month_combo.Text;
                employee.noOfEvets = int.Parse(nEvent_txt.Text);
                employee.empSalary = double.Parse(tSal_txt.Text);

                bool isCorrect = empI.EmployeeSalary(employee);
                if (isCorrect == true)
                {
                    MessageBox.Show("Salary Record has been added successfully.");
                    clearDet();
                }
                else
                {
                    MessageBox.Show("Error Occured.");
                }
            }
            else
            {
                MessageBox.Show("Check '!' Fields & Solve them and try again.");
            }
        }
        public void clearDet()
        {
            ID_combo.Text = "";
            fname_txt.Text = "";
            bSal_txt.Text = "";
            eRate_txt.Text = "";
            month_combo.Text = "";
            nEvent_txt.Text = "";
            tSal_txt.Text = "";
        }

        private void ID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee.empId = ID_combo.Text;
            string fname = empI.GetEmployeeNames(employee);
            double bSal = empI.GetEmployeeBasicSal(employee);
            double otR = empI.GetEmployeeOTRate(employee);

            fname_txt.Text = fname;
            bSal_txt.Text = bSal.ToString() + ".00";
            eRate_txt.Text = otR.ToString() + ".00";
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
