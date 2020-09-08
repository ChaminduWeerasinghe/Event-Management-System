using System;
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
    public partial class Employee_Management_Form : Form
    {
        public Employee_Management_Form()
        {
            InitializeComponent();
        }

        private void Btn_emp_det_Click(object sender, EventArgs e)
        {
            Employee_Details_Form empDet = new Employee_Details_Form();
            empDet.Show();
        }

        private void Btn_emp_sal_Click(object sender, EventArgs e)
        {
            Employee_Salary_Form empSal = new Employee_Salary_Form();
            empSal.Show();
        }

        private void Btn_emp_att_Click(object sender, EventArgs e)
        {
            Employee_Attendance_Form empAtt = new Employee_Attendance_Form();
            empAtt.Show();
        }

        private void Btn_emp_leave_Click(object sender, EventArgs e)
        {
            Employee_Leave_Form empleave = new Employee_Leave_Form();
            empleave.Show();
        }

        private void Btn_emp_report_Click(object sender, EventArgs e)
        {
            Employee_Report empRep = new Employee_Report();
            empRep.Show();
        }
    }
}
