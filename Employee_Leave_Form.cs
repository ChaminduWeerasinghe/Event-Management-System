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
    

    public partial class Employee_Leave_Form : Form
    {

        bool empIdVal = true;
        bool lTypeVal = true;
        bool sDateVal = true;
        bool eDateVal = true;
        bool nDaysVal = true;
        Employee employee = new Employee();
        EmployeeImpl empI = new EmployeeImpl();

        public Employee_Leave_Form()
        {
            InitializeComponent();
            showID();
        }

        private void Add_det_Click(object sender, EventArgs e)
        {
            if (empIdVal == true && lTypeVal == true && sDateVal == true && eDateVal == true && nDaysVal == true) 
            {
                employee.empId = ID_combo.Text;
                employee.leaveType = Leave_Combo.Text;
                employee.reason = res_txt.Text;
                employee.sDate = sDate_picker.Text;
                employee.eDate = eDate_picker.Text;
                employee.noOfDays = int.Parse(nDays_txt.Text);

                bool isCorrect = empI.EmployeeLeave(employee);

                if (isCorrect == true)
                {
                    MessageBox.Show("Leave Record has been added Successfully.");
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


        private void EDate_picker_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(sDate_picker.Text);
            DateTime d2 = DateTime.Parse(eDate_picker.Text);

            TimeSpan t = d2 - d1;
            double days = t.TotalDays;

            nDays_txt.Text = days.ToString();
        }


        private void Clear_Click(object sender, EventArgs e)
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
            Leave_Combo.Text = "";
            res_txt.Text = "";
            nDays_txt.Text = "";
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

        private void ID_combo_Validating(object sender, CancelEventArgs e)
        {
            if (ID_combo.Text == "")
            {
                
                errorProvider1.SetError(ID_combo, "Employee ID cannot be empty");
                empIdVal = false;
            }
            else
            {
                empIdVal = true;
                errorProvider1.SetError(ID_combo, null);
            }
        }

        private void Leave_Combo_Validating(object sender, CancelEventArgs e)
        {
            if(Leave_Combo.Text == "")
            {
                
                errorProvider1.SetError(Leave_Combo, "Letters Only. Leave type cannot be Empty.");
                lTypeVal = false;
            }
            else
            {
                lTypeVal = true;
                errorProvider1.SetError(Leave_Combo, null);
            }
        }

        private void SDate_picker_Validating(object sender, CancelEventArgs e)
        {
            if(sDate_picker.Value == null)
            {
                
                errorProvider1.SetError(sDate_picker, "Field Cannot be Empty");
                sDateVal = false;
            }
            else
            {
                sDateVal = true;
                errorProvider1.SetError(sDate_picker, null);
            }
        }

        private void EDate_picker_Validating(object sender, CancelEventArgs e)
        {
            if (eDate_picker.Value == null)
            {
                
                errorProvider1.SetError(eDate_picker, "Field Cannot be Empty");
                eDateVal = false;
            }
            else
            {
                eDateVal = true;
                errorProvider1.SetError(eDate_picker, null);
            }
        }

        private void NDays_txt_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(nDays_txt.Text, "^[0-9]*$") || nDays_txt.Text == "")
            {
                
                errorProvider1.SetError(nDays_txt, "Numbers Only, Field Cannot be Empty");
                nDaysVal = false;
            }
            else
            {
                nDaysVal = true;
                errorProvider1.SetError(nDays_txt, null);
            }
        }
    }
}
