namespace InventorySystem
{
    partial class Employee_Leave_Form
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
            this.clear = new System.Windows.Forms.Button();
            this.Add_det = new System.Windows.Forms.Button();
            this.nDays_txt = new System.Windows.Forms.TextBox();
            this.res_txt = new System.Windows.Forms.TextBox();
            this.Leave_Combo = new System.Windows.Forms.ComboBox();
            this.eDate_picker = new System.Windows.Forms.DateTimePicker();
            this.sDate_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.hme_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID_combo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Orange;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(438, 410);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 50);
            this.clear.TabIndex = 55;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add_det
            // 
            this.Add_det.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_det.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_det.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Add_det.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_det.Location = new System.Drawing.Point(221, 410);
            this.Add_det.Name = "Add_det";
            this.Add_det.Size = new System.Drawing.Size(108, 50);
            this.Add_det.TabIndex = 54;
            this.Add_det.Text = "Add";
            this.Add_det.UseVisualStyleBackColor = false;
            this.Add_det.Click += new System.EventHandler(this.Add_det_Click);
            // 
            // nDays_txt
            // 
            this.nDays_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDays_txt.Location = new System.Drawing.Point(554, 339);
            this.nDays_txt.Name = "nDays_txt";
            this.nDays_txt.ReadOnly = true;
            this.nDays_txt.Size = new System.Drawing.Size(175, 24);
            this.nDays_txt.TabIndex = 52;
            this.nDays_txt.Validating += new System.ComponentModel.CancelEventHandler(this.NDays_txt_Validating);
            // 
            // res_txt
            // 
            this.res_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_txt.Location = new System.Drawing.Point(221, 339);
            this.res_txt.Name = "res_txt";
            this.res_txt.Size = new System.Drawing.Size(166, 24);
            this.res_txt.TabIndex = 50;
            // 
            // Leave_Combo
            // 
            this.Leave_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave_Combo.FormattingEnabled = true;
            this.Leave_Combo.Items.AddRange(new object[] {
            "Personal Leave",
            "Sick Leave"});
            this.Leave_Combo.Location = new System.Drawing.Point(221, 280);
            this.Leave_Combo.Name = "Leave_Combo";
            this.Leave_Combo.Size = new System.Drawing.Size(166, 26);
            this.Leave_Combo.TabIndex = 49;
            this.Leave_Combo.Validating += new System.ComponentModel.CancelEventHandler(this.Leave_Combo_Validating);
            // 
            // eDate_picker
            // 
            this.eDate_picker.CustomFormat = "MM/dd/yyyy";
            this.eDate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eDate_picker.Location = new System.Drawing.Point(554, 278);
            this.eDate_picker.Name = "eDate_picker";
            this.eDate_picker.Size = new System.Drawing.Size(175, 24);
            this.eDate_picker.TabIndex = 48;
            this.eDate_picker.ValueChanged += new System.EventHandler(this.EDate_picker_ValueChanged);
            this.eDate_picker.Validating += new System.ComponentModel.CancelEventHandler(this.EDate_picker_Validating);
            // 
            // sDate_picker
            // 
            this.sDate_picker.CustomFormat = "MM/dd/yyyy";
            this.sDate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sDate_picker.Location = new System.Drawing.Point(554, 225);
            this.sDate_picker.Name = "sDate_picker";
            this.sDate_picker.Size = new System.Drawing.Size(175, 24);
            this.sDate_picker.TabIndex = 47;
            this.sDate_picker.Validating += new System.ComponentModel.CancelEventHandler(this.SDate_picker_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "No Of Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Employee ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 40;
            this.label7.Text = "Leave Application";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.hme_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 129);
            this.panel1.TabIndex = 39;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.Location = new System.Drawing.Point(706, 93);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(83, 36);
            this.logout_btn.TabIndex = 36;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // hme_btn
            // 
            this.hme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.hme_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.hme_btn.FlatAppearance.BorderSize = 3;
            this.hme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hme_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hme_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.hme_btn.Location = new System.Drawing.Point(617, 93);
            this.hme_btn.Name = "hme_btn";
            this.hme_btn.Size = new System.Drawing.Size(83, 36);
            this.hme_btn.TabIndex = 35;
            this.hme_btn.Text = "Home";
            this.hme_btn.UseVisualStyleBackColor = false;
            this.hme_btn.Click += new System.EventHandler(this.Hme_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem.Properties.Resources.rbLONG;
            this.pictureBox2.Location = new System.Drawing.Point(199, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(406, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.RB;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ID_combo
            // 
            this.ID_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_combo.FormattingEnabled = true;
            this.ID_combo.Location = new System.Drawing.Point(221, 227);
            this.ID_combo.Name = "ID_combo";
            this.ID_combo.Size = new System.Drawing.Size(166, 26);
            this.ID_combo.TabIndex = 56;
            this.ID_combo.Validating += new System.ComponentModel.CancelEventHandler(this.ID_combo_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Employee_Leave_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.ID_combo);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Add_det);
            this.Controls.Add(this.nDays_txt);
            this.Controls.Add(this.res_txt);
            this.Controls.Add(this.Leave_Combo);
            this.Controls.Add(this.eDate_picker);
            this.Controls.Add(this.sDate_picker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Leave_Form";
            this.Text = "Employee_Leave_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Add_det;
        private System.Windows.Forms.TextBox nDays_txt;
        private System.Windows.Forms.TextBox res_txt;
        private System.Windows.Forms.ComboBox Leave_Combo;
        private System.Windows.Forms.DateTimePicker eDate_picker;
        private System.Windows.Forms.DateTimePicker sDate_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ID_combo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button hme_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}