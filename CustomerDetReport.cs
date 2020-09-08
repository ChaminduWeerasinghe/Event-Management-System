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
    public partial class CustomerDetReport : Form
    {
        public CustomerDetReport()
        {
            InitializeComponent();
        }

        private void CustomerDetReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'custDetDS.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.custDetDS.customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
