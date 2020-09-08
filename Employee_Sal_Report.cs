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
    public partial class Employee_Sal_Report : Form
    {
        public Employee_Sal_Report()
        {
            InitializeComponent();
        }

        private void Employee_Sal_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmpSalDS.DataTable1' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.EmpSalDS.DataTable1,comboBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
