using InventorySystem.control;
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
    public partial class Event_Deco1 : Form
    {
        int pw;
        bool hided;


        public Event_Deco1()
        {
            InitializeComponent();

            pw = pt.Width;
            hided = true;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bttnPropertes_Click(object sender, EventArgs e)
        {

        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {

        }

        private void bttnHelp_Click_1(object sender, EventArgs e)
        {

        }

       
        private void bttnMain_Click(object sender, EventArgs e)
        {

        }



        private void Animation_Tick_1(object sender, EventArgs e)
        {
            if (hided)
            {
                pt.Width = pt.Width + 250;
                if (pt.Width >= pw)
                {
                    Animation.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                pt.Width = pt.Width - 20;
                if (pt.Width <= 0)
                {
                    Animation.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void anim_start(object sender, EventArgs e)
        {
            Animation.Start();
        }
        private void anim_stop(object sender, EventArgs e)
        {

            if (pt.Width > pw)
            {
                Animation.Stop();
                hided = false;
                this.Refresh();
            }


        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            item_wedd1.BringToFront();
        }

        private void bunifuThinButton210_Click_1(object sender, EventArgs e)
        {
            selected_items1.BringToFront();
            item_wedd1.SendToBack();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            package_Deco_11.BringToFront();
        }

     
    }
}
