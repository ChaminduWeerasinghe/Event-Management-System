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
    public partial class Employee_Attendance_Report : Form
    {
        public Employee_Attendance_Report()
        {
            InitializeComponent();
        }

        private void Employee_Attendance_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmpAttDS.Employee_Att' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Employee_AttTableAdapter.Fill(this.EmpAttDS.Employee_Att,dateTimePicker1.Text,dateTimePicker2.Text,comboBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
