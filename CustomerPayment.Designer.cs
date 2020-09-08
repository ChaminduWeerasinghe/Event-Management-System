//namespace WindowsFormsApp1
//{
//    partial class CustomerPayment
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPayment));
//            this.dataGrid = new System.Windows.Forms.DataGridView();
//            this.txtId = new System.Windows.Forms.TextBox();
//            this.cuID = new System.Windows.Forms.Label();
//            this.View = new System.Windows.Forms.Button();
//            this.btnDelete = new System.Windows.Forms.Button();
//            this.txtUpdate = new System.Windows.Forms.Button();
//            this.Back = new System.Windows.Forms.Button();
//            this.label1 = new System.Windows.Forms.Label();
//            this.txt1 = new System.Windows.Forms.TextBox();
//            this.txt5 = new System.Windows.Forms.TextBox();
//            this.txt4 = new System.Windows.Forms.TextBox();
//            this.txt3 = new System.Windows.Forms.TextBox();
//            this.txt2 = new System.Windows.Forms.TextBox();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.Print = new System.Windows.Forms.Button();
//            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
//            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
//            this.EventType = new System.Windows.Forms.Label();
//            this.EventPrice = new System.Windows.Forms.Label();
//            this.Advance = new System.Windows.Forms.Label();
//            this.label5 = new System.Windows.Forms.Label();
//            this.Month = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGrid
//            // 
//            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
//            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
//            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlText;
//            this.dataGrid.Location = new System.Drawing.Point(97, 167);
//            this.dataGrid.Name = "dataGrid";
//            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dataGrid.Size = new System.Drawing.Size(639, 88);
//            this.dataGrid.TabIndex = 0;
//            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
//            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick_1);
//            // 
//            // txtId
//            // 
//            this.txtId.Location = new System.Drawing.Point(178, 110);
//            this.txtId.Name = "txtId";
//            this.txtId.Size = new System.Drawing.Size(205, 20);
//            this.txtId.TabIndex = 1;
//            // 
//            // cuID
//            // 
//            this.cuID.AutoSize = true;
//            this.cuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cuID.Location = new System.Drawing.Point(17, 112);
//            this.cuID.Name = "cuID";
//            this.cuID.Size = new System.Drawing.Size(146, 16);
//            this.cuID.TabIndex = 2;
//            this.cuID.Text = "Insert Customer ID:";
//            // 
//            // View
//            // 
//            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.View.Location = new System.Drawing.Point(420, 104);
//            this.View.Name = "View";
//            this.View.Size = new System.Drawing.Size(92, 30);
//            this.View.TabIndex = 3;
//            this.View.Text = "View Details";
//            this.View.UseVisualStyleBackColor = true;
//            this.View.Click += new System.EventHandler(this.View_Click);
//            // 
//            // btnDelete
//            // 
//            this.btnDelete.Location = new System.Drawing.Point(633, 447);
//            this.btnDelete.Name = "btnDelete";
//            this.btnDelete.Size = new System.Drawing.Size(89, 31);
//            this.btnDelete.TabIndex = 4;
//            this.btnDelete.Text = "Delete";
//            this.btnDelete.UseVisualStyleBackColor = true;
//            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//            // 
//            // txtUpdate
//            // 
//            this.txtUpdate.Location = new System.Drawing.Point(539, 447);
//            this.txtUpdate.Name = "txtUpdate";
//            this.txtUpdate.Size = new System.Drawing.Size(88, 31);
//            this.txtUpdate.TabIndex = 5;
//            this.txtUpdate.Text = "Update";
//            this.txtUpdate.UseVisualStyleBackColor = true;
//            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
//            // 
//            // Back
//            // 
//            this.Back.Location = new System.Drawing.Point(450, 447);
//            this.Back.Name = "Back";
//            this.Back.Size = new System.Drawing.Size(83, 31);
//            this.Back.TabIndex = 6;
//            this.Back.Text = "Back";
//            this.Back.UseVisualStyleBackColor = true;
//            this.Back.Click += new System.EventHandler(this.Back_Click);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.Gold;
//            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
//            this.label1.Location = new System.Drawing.Point(304, 26);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(241, 57);
//            this.label1.TabIndex = 26;
//            this.label1.Text = "Royal Blooms";
//            // 
//            // txt1
//            // 
//            this.txt1.Location = new System.Drawing.Point(97, 314);
//            this.txt1.Name = "txt1";
//            this.txt1.Size = new System.Drawing.Size(198, 20);
//            this.txt1.TabIndex = 27;
//            // 
//            // txt5
//            // 
//            this.txt5.Location = new System.Drawing.Point(314, 352);
//            this.txt5.Name = "txt5";
//            this.txt5.Size = new System.Drawing.Size(198, 20);
//            this.txt5.TabIndex = 28;
//            // 
//            // txt4
//            // 
//            this.txt4.Location = new System.Drawing.Point(97, 352);
//            this.txt4.Name = "txt4";
//            this.txt4.Size = new System.Drawing.Size(198, 20);
//            this.txt4.TabIndex = 29;
//            // 
//            // txt3
//            // 
//            this.txt3.Location = new System.Drawing.Point(538, 314);
//            this.txt3.Name = "txt3";
//            this.txt3.Size = new System.Drawing.Size(198, 20);
//            this.txt3.TabIndex = 30;
//            // 
//            // txt2
//            // 
//            this.txt2.Location = new System.Drawing.Point(315, 314);
//            this.txt2.Name = "txt2";
//            this.txt2.Size = new System.Drawing.Size(198, 20);
//            this.txt2.TabIndex = 31;
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.net;
//            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(104, 87);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox1.TabIndex = 32;
//            this.pictureBox1.TabStop = false;
//            // 
//            // Print
//            // 
//            this.Print.Location = new System.Drawing.Point(728, 447);
//            this.Print.Name = "Print";
//            this.Print.Size = new System.Drawing.Size(88, 31);
//            this.Print.TabIndex = 34;
//            this.Print.Text = "Print Bill";
//            this.Print.UseVisualStyleBackColor = true;
//            this.Print.Click += new System.EventHandler(this.Print_Click);
//            // 
//            // printDocument1
//            // 
//            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
//            // 
//            // printPreviewDialog1
//            // 
//            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
//            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
//            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
//            this.printPreviewDialog1.Document = this.printDocument1;
//            this.printPreviewDialog1.Enabled = true;
//            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
//            this.printPreviewDialog1.Name = "printPreviewDialog1";
//            this.printPreviewDialog1.Visible = false;
//            // 
//            // EventType
//            // 
//            this.EventType.AutoSize = true;
//            this.EventType.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.EventType.Location = new System.Drawing.Point(94, 298);
//            this.EventType.Name = "EventType";
//            this.EventType.Size = new System.Drawing.Size(67, 13);
//            this.EventType.TabIndex = 35;
//            this.EventType.Text = "EventType";
//            // 
//            // EventPrice
//            // 
//            this.EventPrice.AutoSize = true;
//            this.EventPrice.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.EventPrice.Location = new System.Drawing.Point(312, 298);
//            this.EventPrice.Name = "EventPrice";
//            this.EventPrice.Size = new System.Drawing.Size(71, 13);
//            this.EventPrice.TabIndex = 36;
//            this.EventPrice.Text = "EventPrice";
//            // 
//            // Advance
//            // 
//            this.Advance.AutoSize = true;
//            this.Advance.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Advance.Location = new System.Drawing.Point(536, 298);
//            this.Advance.Name = "Advance";
//            this.Advance.Size = new System.Drawing.Size(54, 13);
//            this.Advance.TabIndex = 37;
//            this.Advance.Text = "Advance";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label5.Location = new System.Drawing.Point(94, 337);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(106, 13);
//            this.label5.TabIndex = 38;
//            this.label5.Text = "Balance Payment";
//            // 
//            // Month
//            // 
//            this.Month.AutoSize = true;
//            this.Month.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Month.Location = new System.Drawing.Point(312, 337);
//            this.Month.Name = "Month";
//            this.Month.Size = new System.Drawing.Size(45, 13);
//            this.Month.TabIndex = 39;
//            this.Month.Text = "Month";
//            // 
//            // CustomerPayment
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.RoyalBlue;
//            this.ClientSize = new System.Drawing.Size(828, 490);
//            this.Controls.Add(this.Month);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.Advance);
//            this.Controls.Add(this.EventPrice);
//            this.Controls.Add(this.EventType);
//            this.Controls.Add(this.Print);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.txt2);
//            this.Controls.Add(this.txt3);
//            this.Controls.Add(this.txt4);
//            this.Controls.Add(this.txt5);
//            this.Controls.Add(this.txt1);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.Back);
//            this.Controls.Add(this.txtUpdate);
//            this.Controls.Add(this.btnDelete);
//            this.Controls.Add(this.View);
//            this.Controls.Add(this.cuID);
//            this.Controls.Add(this.txtId);
//            this.Controls.Add(this.dataGrid);
//            this.Name = "CustomerPayment";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "CustomerPayment";
//            this.Load += new System.EventHandler(this.CustomerPayment_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.DataGridView dataGrid;
//        private System.Windows.Forms.TextBox txtId;
//        private System.Windows.Forms.Label cuID;
//        private System.Windows.Forms.Button View;
//        private System.Windows.Forms.Button btnDelete;
//        private System.Windows.Forms.Button txtUpdate;
//        private System.Windows.Forms.Button Back;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox txt1;
//        private System.Windows.Forms.TextBox txt5;
//        private System.Windows.Forms.TextBox txt4;
//        private System.Windows.Forms.TextBox txt3;
//        private System.Windows.Forms.TextBox txt2;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.Button Print;
//        private System.Drawing.Printing.PrintDocument printDocument1;
//        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
//        private System.Windows.Forms.Label EventType;
//        private System.Windows.Forms.Label EventPrice;
//        private System.Windows.Forms.Label Advance;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label Month;
//    }
//}