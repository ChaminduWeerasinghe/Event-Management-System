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
    public partial class Employee_Details_Report : Form
    {
        public Employee_Details_Report()
        {
            InitializeComponent();
        }

        private void Employee_Details_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmployeeDetDS.Employee_Det' table. You can move, or remove it, as needed.
            this.Employee_DetTableAdapter.Fill(this.EmployeeDetDS.Employee_Det);

            this.reportViewer1.RefreshReport();
        }
    }
}
