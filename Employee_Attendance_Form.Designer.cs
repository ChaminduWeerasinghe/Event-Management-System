namespace InventorySystem
{

    partial class Employee_Attendance_Form
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
            this.label6 = new System.Windows.Forms.Label();
            this.emp_att_clear = new System.Windows.Forms.Button();
            this.emp_att_add = new System.Windows.Forms.Button();
            this.emp_att_chOutTime = new System.Windows.Forms.DateTimePicker();
            this.emp_att_chInTime = new System.Windows.Forms.DateTimePicker();
            this.emp_att_date = new System.Windows.Forms.DateTimePicker();
            this.emp_att_chOutTime_lbl = new System.Windows.Forms.Label();
            this.emp_att_chInTime_lbl = new System.Windows.Forms.Label();
            this.emp_att_date_lbl = new System.Windows.Forms.Label();
            this.emp_att_status = new System.Windows.Forms.ComboBox();
            this.emp_att_name_lbl = new System.Windows.Forms.Label();
            this.emp_att_status_lbl = new System.Windows.Forms.Label();
            this.emp_att_id_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hme_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.ID_combo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Manage Attendance";
            // 
            // emp_att_clear
            // 
            this.emp_att_clear.BackColor = System.Drawing.Color.Orange;
            this.emp_att_clear.FlatAppearance.BorderSize = 0;
            this.emp_att_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_att_clear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_att_clear.Location = new System.Drawing.Point(477, 397);
            this.emp_att_clear.Name = "emp_att_clear";
            this.emp_att_clear.Size = new System.Drawing.Size(108, 50);
            this.emp_att_clear.TabIndex = 33;
            this.emp_att_clear.Text = "Clear";
            this.emp_att_clear.UseVisualStyleBackColor = false;
            this.emp_att_clear.Click += new System.EventHandler(this.Emp_att_clear_Click);
            // 
            // emp_att_add
            // 
            this.emp_att_add.BackColor = System.Drawing.Color.LimeGreen;
            this.emp_att_add.FlatAppearance.BorderSize = 0;
            this.emp_att_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_att_add.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_att_add.Location = new System.Drawing.Point(221, 397);
            this.emp_att_add.Name = "emp_att_add";
            this.emp_att_add.Size = new System.Drawing.Size(108, 50);
            this.emp_att_add.TabIndex = 32;
            this.emp_att_add.Text = "Add";
            this.emp_att_add.UseVisualStyleBackColor = false;
            this.emp_att_add.Click += new System.EventHandler(this.Emp_att_add_Click);
            // 
            // emp_att_chOutTime
            // 
            this.emp_att_chOutTime.CustomFormat = "hh:mm:ss tt";
            this.emp_att_chOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_chOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.emp_att_chOutTime.Location = new System.Drawing.Point(591, 337);
            this.emp_att_chOutTime.Name = "emp_att_chOutTime";
            this.emp_att_chOutTime.Size = new System.Drawing.Size(151, 24);
            this.emp_att_chOutTime.TabIndex = 31;
            // 
            // emp_att_chInTime
            // 
            this.emp_att_chInTime.CustomFormat = "hh:mm:ss tt";
            this.emp_att_chInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_chInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.emp_att_chInTime.Location = new System.Drawing.Point(591, 277);
            this.emp_att_chInTime.Name = "emp_att_chInTime";
            this.emp_att_chInTime.Size = new System.Drawing.Size(151, 24);
            this.emp_att_chInTime.TabIndex = 30;
            this.emp_att_chInTime.Value = new System.DateTime(2019, 6, 28, 23, 1, 0, 0);
            // 
            // emp_att_date
            // 
            this.emp_att_date.CustomFormat = "MM/dd/yyyy";
            this.emp_att_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.emp_att_date.Location = new System.Drawing.Point(591, 220);
            this.emp_att_date.Name = "emp_att_date";
            this.emp_att_date.Size = new System.Drawing.Size(151, 24);
            this.emp_att_date.TabIndex = 29;
            // 
            // emp_att_chOutTime_lbl
            // 
            this.emp_att_chOutTime_lbl.AutoSize = true;
            this.emp_att_chOutTime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_chOutTime_lbl.Location = new System.Drawing.Point(473, 337);
            this.emp_att_chOutTime_lbl.Name = "emp_att_chOutTime_lbl";
            this.emp_att_chOutTime_lbl.Size = new System.Drawing.Size(81, 20);
            this.emp_att_chOutTime_lbl.TabIndex = 28;
            this.emp_att_chOutTime_lbl.Text = "Out Time";
            // 
            // emp_att_chInTime_lbl
            // 
            this.emp_att_chInTime_lbl.AutoSize = true;
            this.emp_att_chInTime_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_chInTime_lbl.Location = new System.Drawing.Point(473, 277);
            this.emp_att_chInTime_lbl.Name = "emp_att_chInTime_lbl";
            this.emp_att_chInTime_lbl.Size = new System.Drawing.Size(68, 20);
            this.emp_att_chInTime_lbl.TabIndex = 27;
            this.emp_att_chInTime_lbl.Text = "In Time";
            // 
            // emp_att_date_lbl
            // 
            this.emp_att_date_lbl.AutoSize = true;
            this.emp_att_date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_date_lbl.Location = new System.Drawing.Point(473, 220);
            this.emp_att_date_lbl.Name = "emp_att_date_lbl";
            this.emp_att_date_lbl.Size = new System.Drawing.Size(48, 20);
            this.emp_att_date_lbl.TabIndex = 26;
            this.emp_att_date_lbl.Text = "Date";
            // 
            // emp_att_status
            // 
            this.emp_att_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_status.FormattingEnabled = true;
            this.emp_att_status.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.emp_att_status.Location = new System.Drawing.Point(221, 331);
            this.emp_att_status.Name = "emp_att_status";
            this.emp_att_status.Size = new System.Drawing.Size(157, 26);
            this.emp_att_status.TabIndex = 25;
            // 
            // emp_att_name_lbl
            // 
            this.emp_att_name_lbl.AutoSize = true;
            this.emp_att_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_name_lbl.Location = new System.Drawing.Point(70, 277);
            this.emp_att_name_lbl.Name = "emp_att_name_lbl";
            this.emp_att_name_lbl.Size = new System.Drawing.Size(96, 20);
            this.emp_att_name_lbl.TabIndex = 22;
            this.emp_att_name_lbl.Text = "First Name";
            // 
            // emp_att_status_lbl
            // 
            this.emp_att_status_lbl.AutoSize = true;
            this.emp_att_status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_status_lbl.Location = new System.Drawing.Point(70, 337);
            this.emp_att_status_lbl.Name = "emp_att_status_lbl";
            this.emp_att_status_lbl.Size = new System.Drawing.Size(102, 20);
            this.emp_att_status_lbl.TabIndex = 21;
            this.emp_att_status_lbl.Text = "Attendance";
            // 
            // emp_att_id_lbl
            // 
            this.emp_att_id_lbl.AutoSize = true;
            this.emp_att_id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_att_id_lbl.Location = new System.Drawing.Point(70, 220);
            this.emp_att_id_lbl.Name = "emp_att_id_lbl";
            this.emp_att_id_lbl.Size = new System.Drawing.Size(111, 20);
            this.emp_att_id_lbl.TabIndex = 20;
            this.emp_att_id_lbl.Text = "Employee ID";
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
            this.panel1.TabIndex = 19;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.Location = new System.Drawing.Point(708, 93);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(83, 36);
            this.logout_btn.TabIndex = 38;
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
            this.pictureBox2.TabIndex = 2;
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
            this.hme_btn.Location = new System.Drawing.Point(619, 93);
            this.hme_btn.Name = "hme_btn";
            this.hme_btn.Size = new System.Drawing.Size(83, 36);
            this.hme_btn.TabIndex = 37;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fname_txt
            // 
            this.fname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.Location = new System.Drawing.Point(221, 275);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(157, 24);
            this.fname_txt.TabIndex = 35;
            // 
            // ID_combo
            // 
            this.ID_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_combo.FormattingEnabled = true;
            this.ID_combo.Location = new System.Drawing.Point(221, 218);
            this.ID_combo.Name = "ID_combo";
            this.ID_combo.Size = new System.Drawing.Size(157, 26);
            this.ID_combo.TabIndex = 36;
            this.ID_combo.SelectedIndexChanged += new System.EventHandler(this.ID_combo_SelectedIndexChanged);
            // 
            // Employee_Attendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.ID_combo);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emp_att_clear);
            this.Controls.Add(this.emp_att_add);
            this.Controls.Add(this.emp_att_chOutTime);
            this.Controls.Add(this.emp_att_chInTime);
            this.Controls.Add(this.emp_att_date);
            this.Controls.Add(this.emp_att_chOutTime_lbl);
            this.Controls.Add(this.emp_att_chInTime_lbl);
            this.Controls.Add(this.emp_att_date_lbl);
            this.Controls.Add(this.emp_att_status);
            this.Controls.Add(this.emp_att_name_lbl);
            this.Controls.Add(this.emp_att_status_lbl);
            this.Controls.Add(this.emp_att_id_lbl);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_Attendance_Form";
            this.Text = "Employee_Attendance_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button emp_att_clear;
        private System.Windows.Forms.Button emp_att_add;
        private System.Windows.Forms.DateTimePicker emp_att_chOutTime;
        private System.Windows.Forms.DateTimePicker emp_att_chInTime;
        private System.Windows.Forms.DateTimePicker emp_att_date;
        private System.Windows.Forms.Label emp_att_chOutTime_lbl;
        private System.Windows.Forms.Label emp_att_chInTime_lbl;
        private System.Windows.Forms.Label emp_att_date_lbl;
        private System.Windows.Forms.ComboBox emp_att_status;
        private System.Windows.Forms.Label emp_att_name_lbl;
        private System.Windows.Forms.Label emp_att_status_lbl;
        private System.Windows.Forms.Label emp_att_id_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.ComboBox ID_combo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button hme_btn;
    }
}