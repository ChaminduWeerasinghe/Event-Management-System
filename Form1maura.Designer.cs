namespace InventorySystem
{
    partial class Form1maura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new InventorySystem.InventoryDataSet();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAdv = new System.Windows.Forms.TextBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.InsertB = new System.Windows.Forms.Button();
            this.NextB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customerPaymentTableAdapter = new InventorySystem.InventoryDataSetTableAdapters.customerPaymentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comb1 = new System.Windows.Forms.ComboBox();
            this.comb2 = new System.Windows.Forms.ComboBox();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // txtInv
            // 
            this.txtInv.AutoSize = true;
            this.txtInv.Location = new System.Drawing.Point(896, 162);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(28, 13);
            this.txtInv.TabIndex = 1;
            this.txtInv.Text = "Invo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(628, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // customerPaymentBindingSource
            // 
            this.customerPaymentBindingSource.DataMember = "customerPayment";
            this.customerPaymentBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 251);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(221, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(162, 337);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtAdv
            // 
            this.txtAdv.Location = new System.Drawing.Point(162, 379);
            this.txtAdv.Name = "txtAdv";
            this.txtAdv.Size = new System.Drawing.Size(221, 20);
            this.txtAdv.TabIndex = 6;
            this.txtAdv.TextChanged += new System.EventHandler(this.txtAdv_TextChanged);
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(162, 423);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(221, 20);
            this.txtBal.TabIndex = 7;
            // 
            // InsertB
            // 
            this.InsertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertB.Location = new System.Drawing.Point(758, 641);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(75, 30);
            this.InsertB.TabIndex = 9;
            this.InsertB.Text = "Insert";
            this.InsertB.UseVisualStyleBackColor = true;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // NextB
            // 
            this.NextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextB.Location = new System.Drawing.Point(864, 641);
            this.NextB.Name = "NextB";
            this.NextB.Size = new System.Drawing.Size(75, 30);
            this.NextB.TabIndex = 10;
            this.NextB.Text = "Next";
            this.NextB.UseVisualStyleBackColor = true;
            this.NextB.Click += new System.EventHandler(this.NextB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Month";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(913, 24);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(26, 13);
            this.Time.TabIndex = 12;
            this.Time.Text = "time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(821, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(182, 658);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(51, 16);
            this.Date.TabIndex = 14;
            this.Date.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customerPaymentTableAdapter
            // 
            this.customerPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(50, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Package Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Package Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(50, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Advance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Balance Payment";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::InventorySystem.Properties.Resources.rbLONG;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem.Properties.Resources.RB;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // comb1
            // 
            this.comb1.FormattingEnabled = true;
            this.comb1.Items.AddRange(new object[] {
            "Wedding",
            "BirthdayParty",
            "Gettogether",
            "Dj Party"});
            this.comb1.Location = new System.Drawing.Point(440, 294);
            this.comb1.Name = "comb1";
            this.comb1.Size = new System.Drawing.Size(172, 21);
            this.comb1.TabIndex = 23;
            this.comb1.TextChanged += new System.EventHandler(this.txtTyp_TextChanged);
            // 
            // comb2
            // 
            this.comb2.FormattingEnabled = true;
            this.comb2.Items.AddRange(new object[] {
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
            this.comb2.Location = new System.Drawing.Point(283, 481);
            this.comb2.Name = "comb2";
            this.comb2.Size = new System.Drawing.Size(170, 21);
            this.comb2.TabIndex = 24;
            this.comb2.SelectedValueChanged += new System.EventHandler(this.comb2_SelectedValueChanged);
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(166, 299);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(217, 20);
            this.txtTyp.TabIndex = 25;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(126, 482);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(134, 20);
            this.txtMonth.TabIndex = 26;
            // 
            // Form1maura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventorySystem.Properties.Resources.orange_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.comb2);
            this.Controls.Add(this.comb1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextB);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.txtAdv);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtInv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1maura";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtInv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAdv;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.Button NextB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource customerPaymentBindingSource;
        private InventoryDataSetTableAdapters.customerPaymentTableAdapter customerPaymentTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comb1;
        private System.Windows.Forms.ComboBox comb2;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.TextBox txtMonth;
    }
}

