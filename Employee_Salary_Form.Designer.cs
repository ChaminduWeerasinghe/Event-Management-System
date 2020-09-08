namespace InventorySystem
{
    partial class Employee_Salary_Form
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.Add_Det = new System.Windows.Forms.Button();
            this.tSal_txt = new System.Windows.Forms.TextBox();
            this.nEvent_txt = new System.Windows.Forms.TextBox();
            this.eRate_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSal_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hme_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_combo = new System.Windows.Forms.ComboBox();
            this.month_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "Employee Salary";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Orange;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(451, 422);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(106, 47);
            this.clear.TabIndex = 34;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add_Det
            // 
            this.Add_Det.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_Det.FlatAppearance.BorderSize = 0;
            this.Add_Det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Det.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Det.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Det.Location = new System.Drawing.Point(246, 422);
            this.Add_Det.Name = "Add_Det";
            this.Add_Det.Size = new System.Drawing.Size(106, 47);
            this.Add_Det.TabIndex = 33;
            this.Add_Det.Text = "Add";
            this.Add_Det.UseVisualStyleBackColor = false;
            this.Add_Det.Click += new System.EventHandler(this.Add_Det_Click);
            // 
            // tSal_txt
            // 
            this.tSal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSal_txt.Location = new System.Drawing.Point(182, 145);
            this.tSal_txt.Name = "tSal_txt";
            this.tSal_txt.ReadOnly = true;
            this.tSal_txt.Size = new System.Drawing.Size(149, 24);
            this.tSal_txt.TabIndex = 32;
            // 
            // nEvent_txt
            // 
            this.nEvent_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nEvent_txt.Location = new System.Drawing.Point(214, 107);
            this.nEvent_txt.Name = "nEvent_txt";
            this.nEvent_txt.Size = new System.Drawing.Size(117, 24);
            this.nEvent_txt.TabIndex = 31;
            this.nEvent_txt.TextChanged += new System.EventHandler(this.NEvent_txt_TextChanged);
            this.nEvent_txt.Validating += new System.ComponentModel.CancelEventHandler(this.NEvent_txt_Validating);
            // 
            // eRate_txt
            // 
            this.eRate_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eRate_txt.Location = new System.Drawing.Point(182, 69);
            this.eRate_txt.Name = "eRate_txt";
            this.eRate_txt.ReadOnly = true;
            this.eRate_txt.Size = new System.Drawing.Size(149, 24);
            this.eRate_txt.TabIndex = 30;
            this.eRate_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Number of OT Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "OT Rate";
            // 
            // bSal_txt
            // 
            this.bSal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSal_txt.Location = new System.Drawing.Point(182, 31);
            this.bSal_txt.Name = "bSal_txt";
            this.bSal_txt.ReadOnly = true;
            this.bSal_txt.Size = new System.Drawing.Size(149, 24);
            this.bSal_txt.TabIndex = 26;
            this.bSal_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Employee ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.hme_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 129);
            this.panel1.TabIndex = 20;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.Location = new System.Drawing.Point(707, 93);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(83, 36);
            this.logout_btn.TabIndex = 44;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem.Properties.Resources.rbLONG;
            this.pictureBox2.Location = new System.Drawing.Point(199, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // hme_btn
            // 
            this.hme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.hme_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.hme_btn.FlatAppearance.BorderSize = 3;
            this.hme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hme_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hme_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.hme_btn.Location = new System.Drawing.Point(618, 93);
            this.hme_btn.Name = "hme_btn";
            this.hme_btn.Size = new System.Drawing.Size(83, 36);
            this.hme_btn.TabIndex = 43;
            this.hme_btn.Text = "Home";
            this.hme_btn.UseVisualStyleBackColor = false;
            this.hme_btn.Click += new System.EventHandler(this.Hme_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ID_combo
            // 
            this.ID_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_combo.FormattingEnabled = true;
            this.ID_combo.Location = new System.Drawing.Point(183, 29);
            this.ID_combo.Name = "ID_combo";
            this.ID_combo.Size = new System.Drawing.Size(149, 26);
            this.ID_combo.TabIndex = 37;
            this.ID_combo.SelectedIndexChanged += new System.EventHandler(this.ID_combo_SelectedIndexChanged);
            this.ID_combo.Validating += new System.ComponentModel.CancelEventHandler(this.ID_combo_Validating);
            // 
            // month_combo
            // 
            this.month_combo.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_combo.FormattingEnabled = true;
            this.month_combo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_combo.Location = new System.Drawing.Point(183, 148);
            this.month_combo.Name = "month_combo";
            this.month_combo.Size = new System.Drawing.Size(149, 26);
            this.month_combo.TabIndex = 38;
            this.month_combo.Validating += new System.ComponentModel.CancelEventHandler(this.Month_combo_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "First Name";
            // 
            // fname_txt
            // 
            this.fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.Location = new System.Drawing.Point(183, 89);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.ReadOnly = true;
            this.fname_txt.Size = new System.Drawing.Size(149, 24);
            this.fname_txt.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fname_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ID_combo);
            this.panel2.Controls.Add(this.month_combo);
            this.panel2.Location = new System.Drawing.Point(37, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 200);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bSal_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tSal_txt);
            this.panel3.Controls.Add(this.eRate_txt);
            this.panel3.Controls.Add(this.nEvent_txt);
            this.panel3.Location = new System.Drawing.Point(424, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 200);
            this.panel3.TabIndex = 42;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Employee_Salary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Add_Det);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Salary_Form";
            this.Text = "Employee_Salary_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Add_Det;
        private System.Windows.Forms.TextBox tSal_txt;
        private System.Windows.Forms.TextBox nEvent_txt;
        private System.Windows.Forms.TextBox eRate_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bSal_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ID_combo;
        private System.Windows.Forms.ComboBox month_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button hme_btn;
    }
}