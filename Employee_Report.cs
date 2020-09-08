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
    public partial class Employee_Report : Form
    {
        public Employee_Report()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Details_Report edREp = new Employee_Details_Report();
            edREp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Sal_Report empSal = new Employee_Sal_Report();
            empSal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Attendance_Report empAttRep = new Employee_Attendance_Report();
            empAttRep.Show();
        }
    }
}
