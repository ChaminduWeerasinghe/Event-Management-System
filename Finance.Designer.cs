namespace InventorySystem
{
    partial class Finance
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
            this.lblWater = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblelect = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.lblother = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdt = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lbltot = new System.Windows.Forms.Label();
            this.txttot = new System.Windows.Forms.Label();
            this.lblcatr = new System.Windows.Forms.Label();
            this.lblempsal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwater = new System.Windows.Forms.TextBox();
            this.txtother = new System.Windows.Forms.TextBox();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.txtelect = new System.Windows.Forms.TextBox();
            this.txtcatr = new System.Windows.Forms.TextBox();
            this.txtempsal = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.Location = new System.Drawing.Point(46, 136);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(88, 24);
            this.lblWater.TabIndex = 0;
            this.lblWater.Text = "Water Bill";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGrid.Location = new System.Drawing.Point(345, 136);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(443, 186);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Column
            // 
            this.Column.HeaderText = "Sale";
            this.Column.Name = "Column";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expences";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Profit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // lblelect
            // 
            this.lblelect.AutoSize = true;
            this.lblelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelect.Location = new System.Drawing.Point(46, 173);
            this.lblelect.Name = "lblelect";
            this.lblelect.Size = new System.Drawing.Size(118, 24);
            this.lblelect.TabIndex = 0;
            this.lblelect.Text = "Electricity Bill";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.Location = new System.Drawing.Point(46, 283);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(42, 24);
            this.lbltax.TabIndex = 2;
            this.lbltax.Text = "Tax";
            // 
            // lblother
            // 
            this.lblother.AutoSize = true;
            this.lblother.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblother.Location = new System.Drawing.Point(46, 321);
            this.lblother.Name = "lblother";
            this.lblother.Size = new System.Drawing.Size(57, 24);
            this.lblother.TabIndex = 3;
            this.lblother.Text = "Other";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(107, 394);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 33);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdt
            // 
            this.btnupdt.BackColor = System.Drawing.Color.BlueViolet;
            this.btnupdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdt.Location = new System.Drawing.Point(427, 393);
            this.btnupdt.Name = "btnupdt";
            this.btnupdt.Size = new System.Drawing.Size(109, 34);
            this.btnupdt.TabIndex = 9;
            this.btnupdt.Text = "UPDATE";
            this.btnupdt.UseVisualStyleBackColor = false;
            this.btnupdt.Click += new System.EventHandler(this.btnupdt_Click_1);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.BlueViolet;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(589, 394);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(99, 34);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "DELETE";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lbltot
            // 
            this.lbltot.AutoSize = true;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.Location = new System.Drawing.Point(46, 361);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(51, 24);
            this.lbltot.TabIndex = 13;
            this.lbltot.Text = "Total";
            // 
            // txttot
            // 
            this.txttot.AutoSize = true;
            this.txttot.BackColor = System.Drawing.Color.LightSlateGray;
            this.txttot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttot.Location = new System.Drawing.Point(228, 361);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(45, 24);
            this.txttot.TabIndex = 13;
            this.txttot.Text = "0.00";
            // 
            // lblcatr
            // 
            this.lblcatr.AutoSize = true;
            this.lblcatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatr.Location = new System.Drawing.Point(46, 212);
            this.lblcatr.Name = "lblcatr";
            this.lblcatr.Size = new System.Drawing.Size(80, 24);
            this.lblcatr.TabIndex = 14;
            this.lblcatr.Text = "Catering";
            // 
            // lblempsal
            // 
            this.lblempsal.AutoSize = true;
            this.lblempsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempsal.Location = new System.Drawing.Point(46, 246);
            this.lblempsal.Name = "lblempsal";
            this.lblempsal.Size = new System.Drawing.Size(152, 24);
            this.lblempsal.TabIndex = 16;
            this.lblempsal.Text = "Employee Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cash Flow";
            // 
            // txtwater
            // 
            this.txtwater.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtwater.Location = new System.Drawing.Point(221, 136);
            this.txtwater.Name = "txtwater";
            this.txtwater.Size = new System.Drawing.Size(100, 20);
            this.txtwater.TabIndex = 20;
            this.txtwater.TextChanged += new System.EventHandler(this.txtwater_TextChanged);
            // 
            // txtother
            // 
            this.txtother.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtother.Location = new System.Drawing.Point(222, 321);
            this.txtother.Name = "txtother";
            this.txtother.Size = new System.Drawing.Size(99, 20);
            this.txtother.TabIndex = 21;
            this.txtother.TextChanged += new System.EventHandler(this.txtother_TextChanged);
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Blue;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 433);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(800, 17);
            this.panelfooter.TabIndex = 22;
            // 
            // txtelect
            // 
            this.txtelect.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtelect.Location = new System.Drawing.Point(222, 173);
            this.txtelect.Name = "txtelect";
            this.txtelect.Size = new System.Drawing.Size(100, 20);
            this.txtelect.TabIndex = 23;
            this.txtelect.TextChanged += new System.EventHandler(this.txtelect_TextChanged);
            // 
            // txtcatr
            // 
            this.txtcatr.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtcatr.Location = new System.Drawing.Point(221, 212);
            this.txtcatr.Name = "txtcatr";
            this.txtcatr.Size = new System.Drawing.Size(100, 20);
            this.txtcatr.TabIndex = 24;
            this.txtcatr.TextChanged += new System.EventHandler(this.txtcatr_TextChanged);
            // 
            // txtempsal
            // 
            this.txtempsal.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtempsal.Location = new System.Drawing.Point(221, 246);
            this.txtempsal.Name = "txtempsal";
            this.txtempsal.Size = new System.Drawing.Size(101, 20);
            this.txtempsal.TabIndex = 25;
            this.txtempsal.TextChanged += new System.EventHandler(this.txtempsal_TextChanged);
            // 
            // txttax
            // 
            this.txttax.BackColor = System.Drawing.Color.LightSlateGray;
            this.txttax.Location = new System.Drawing.Point(222, 283);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(100, 20);
            this.txttax.TabIndex = 26;
            this.txttax.TextChanged += new System.EventHandler(this.txttax_TextChanged);
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.txtempsal);
            this.Controls.Add(this.txtcatr);
            this.Controls.Add(this.txtelect);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.txtother);
            this.Controls.Add(this.txtwater);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblempsal);
            this.Controls.Add(this.lblcatr);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.lbltot);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdt);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblother);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblelect);
            this.Controls.Add(this.lblWater);
            this.Name = "Finance";
            this.Text = "Finance";
            this.Load += new System.EventHandler(this.Finance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblelect;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Label lblother;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdt;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label txttot;
        private System.Windows.Forms.Label lblcatr;
        private System.Windows.Forms.Label lblempsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtwater;
        private System.Windows.Forms.TextBox txtother;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.TextBox txtelect;
        private System.Windows.Forms.TextBox txtcatr;
        private System.Windows.Forms.TextBox txtempsal;
        private System.Windows.Forms.TextBox txttax;
    }
}