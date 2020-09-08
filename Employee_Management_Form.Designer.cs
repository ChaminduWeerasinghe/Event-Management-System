namespace InventorySystem
{
    partial class Employee_Management_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Emp_Mng = new System.Windows.Forms.Label();
            this.btn_emp_sal = new InventorySystem.supportiveClasses.CircularButton();
            this.btn_emp_det = new InventorySystem.supportiveClasses.CircularButton();
            this.btn_emp_report = new InventorySystem.supportiveClasses.CircularButton();
            this.btn_emp_leave = new InventorySystem.supportiveClasses.CircularButton();
            this.btn_emp_att = new InventorySystem.supportiveClasses.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 92);
            this.panel1.TabIndex = 20;
            // 
            // Emp_Mng
            // 
            this.Emp_Mng.AutoSize = true;
            this.Emp_Mng.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Mng.Location = new System.Drawing.Point(220, 94);
            this.Emp_Mng.Name = "Emp_Mng";
            this.Emp_Mng.Size = new System.Drawing.Size(293, 35);
            this.Emp_Mng.TabIndex = 19;
            this.Emp_Mng.Text = "Employee Management";
            // 
            // btn_emp_sal
            // 
            this.btn_emp_sal.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_emp_sal.FlatAppearance.BorderSize = 0;
            this.btn_emp_sal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_sal.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btn_emp_sal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emp_sal.Location = new System.Drawing.Point(450, 232);
            this.btn_emp_sal.Name = "btn_emp_sal";
            this.btn_emp_sal.Size = new System.Drawing.Size(92, 80);
            this.btn_emp_sal.TabIndex = 21;
            this.btn_emp_sal.Text = "Employee Salary";
            this.btn_emp_sal.UseVisualStyleBackColor = false;
            this.btn_emp_sal.Click += new System.EventHandler(this.Btn_emp_sal_Click);
            // 
            // btn_emp_det
            // 
            this.btn_emp_det.BackColor = System.Drawing.Color.Crimson;
            this.btn_emp_det.FlatAppearance.BorderSize = 0;
            this.btn_emp_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_det.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btn_emp_det.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emp_det.Location = new System.Drawing.Point(320, 145);
            this.btn_emp_det.Name = "btn_emp_det";
            this.btn_emp_det.Size = new System.Drawing.Size(92, 80);
            this.btn_emp_det.TabIndex = 22;
            this.btn_emp_det.Text = "Employee Details";
            this.btn_emp_det.UseVisualStyleBackColor = false;
            this.btn_emp_det.Click += new System.EventHandler(this.Btn_emp_det_Click);
            // 
            // btn_emp_report
            // 
            this.btn_emp_report.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_emp_report.FlatAppearance.BorderSize = 0;
            this.btn_emp_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_report.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btn_emp_report.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emp_report.Location = new System.Drawing.Point(187, 232);
            this.btn_emp_report.Name = "btn_emp_report";
            this.btn_emp_report.Size = new System.Drawing.Size(92, 80);
            this.btn_emp_report.TabIndex = 23;
            this.btn_emp_report.Text = "Reports";
            this.btn_emp_report.UseVisualStyleBackColor = false;
            this.btn_emp_report.Click += new System.EventHandler(this.Btn_emp_report_Click);
            // 
            // btn_emp_leave
            // 
            this.btn_emp_leave.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_emp_leave.FlatAppearance.BorderSize = 0;
            this.btn_emp_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_leave.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btn_emp_leave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emp_leave.Location = new System.Drawing.Point(226, 364);
            this.btn_emp_leave.Name = "btn_emp_leave";
            this.btn_emp_leave.Size = new System.Drawing.Size(92, 80);
            this.btn_emp_leave.TabIndex = 24;
            this.btn_emp_leave.Text = "Leave Application";
            this.btn_emp_leave.UseVisualStyleBackColor = false;
            this.btn_emp_leave.Click += new System.EventHandler(this.Btn_emp_leave_Click);
            // 
            // btn_emp_att
            // 
            this.btn_emp_att.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_emp_att.FlatAppearance.BorderSize = 0;
            this.btn_emp_att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_att.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.btn_emp_att.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_emp_att.Location = new System.Drawing.Point(421, 364);
            this.btn_emp_att.Name = "btn_emp_att";
            this.btn_emp_att.Size = new System.Drawing.Size(92, 80);
            this.btn_emp_att.TabIndex = 25;
            this.btn_emp_att.Text = "Attendance";
            this.btn_emp_att.UseVisualStyleBackColor = false;
            this.btn_emp_att.Click += new System.EventHandler(this.Btn_emp_att_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.emp_img;
            this.pictureBox1.Location = new System.Drawing.Point(309, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_emp_att);
            this.Controls.Add(this.btn_emp_leave);
            this.Controls.Add(this.btn_emp_report);
            this.Controls.Add(this.btn_emp_det);
            this.Controls.Add(this.btn_emp_sal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Emp_Mng);
            this.Name = "Employee_Management_Form";
            this.Text = "Employee_Management_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Emp_Mng;
        private supportiveClasses.CircularButton btn_emp_sal;
        private supportiveClasses.CircularButton btn_emp_det;
        private supportiveClasses.CircularButton btn_emp_report;
        private supportiveClasses.CircularButton btn_emp_leave;
        private supportiveClasses.CircularButton btn_emp_att;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}