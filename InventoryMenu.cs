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
    public partial class InventoryMenu : Form
    {
        private EventForm eventForm;
        private PackageMenu packMenu;
        public InventoryMenu()
        {
            InitializeComponent();
        }

    

        private void btnPackage_Click_1(object sender, EventArgs e)
        {
            if (packMenu == null)
            {
                packMenu = new PackageMenu();
            }
            ObjectHolder.inventoryMainMenu = this;
            this.Hide();
            packMenu.Show();
        }

        private void btnSell_Click_1(object sender, EventArgs e)
        {
            if (eventForm == null)
            {
                eventForm = new EventForm();
            }
            ObjectHolder.inventoryMainMenu = this;
            this.Hide();
            eventForm.Show();
        }

        private void InventoryMenu_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;

            mainM.Show();
            this.Hide();
        }

        private void hme_btn_Click(object sender, EventArgs e)
        {
            Menu mainM = ObjectHolder.mainMenu;

            mainM.Show();
            this.Hide();
        }
    }
}
