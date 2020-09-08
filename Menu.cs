using System;
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
    public partial class Menu : Form
    {
        InventoryMenu invMenu;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if(invMenu == null)
            {
                invMenu = new InventoryMenu();
            }
            ObjectHolder.mainMenu = this;
            this.Hide();
            invMenu.Show();
        }

        private void Emp_Click(object sender, EventArgs e)
        {
            Employee_Management_Form emp = new Employee_Management_Form();
            //this.Hide();
            emp.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1R cusman = new Form1R();
            cusman.Show();
        }

        private void Payement_Click(object sender, EventArgs e)
        {
            Form1maura form1Maura = new Form1maura();
            form1Maura.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Event_Deco1 ED = new Event_Deco1();
            ED.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1Ravindu F1Y = new Form1Ravindu();
            F1Y.Show();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            finance.Show();
        }
    }
}
