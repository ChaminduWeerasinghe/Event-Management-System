namespace InventorySystem
{
    partial class EventPackageController
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPackID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPackName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStockCnt = new System.Windows.Forms.Label();
            this.txtStockCnt = new System.Windows.Forms.TextBox();
            this.lblPackPrice = new System.Windows.Forms.Label();
            this.txtPackPrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblPackID
            // 
            this.lblPackID.AutoSize = true;
            this.lblPackID.Location = new System.Drawing.Point(89, 265);
            this.lblPackID.Name = "lblPackID";
            this.lblPackID.Size = new System.Drawing.Size(64, 13);
            this.lblPackID.TabIndex = 1;
            this.lblPackID.Text = "Package ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(407, 265);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // lblPackName
            // 
            this.lblPackName.AutoSize = true;
            this.lblPackName.Location = new System.Drawing.Point(89, 323);
            this.lblPackName.Name = "lblPackName";
            this.lblPackName.Size = new System.Drawing.Size(81, 13);
            this.lblPackName.TabIndex = 1;
            this.lblPackName.Text = "Package Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(407, 316);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblStockCnt
            // 
            this.lblStockCnt.AutoSize = true;
            this.lblStockCnt.Location = new System.Drawing.Point(89, 401);
            this.lblStockCnt.Name = "lblStockCnt";
            this.lblStockCnt.Size = new System.Drawing.Size(66, 13);
            this.lblStockCnt.TabIndex = 1;
            this.lblStockCnt.Text = "Stock Count";
            // 
            // txtStockCnt
            // 
            this.txtStockCnt.Location = new System.Drawing.Point(407, 394);
            this.txtStockCnt.Name = "txtStockCnt";
            this.txtStockCnt.Size = new System.Drawing.Size(100, 20);
            this.txtStockCnt.TabIndex = 2;
            // 
            // lblPackPrice
            // 
            this.lblPackPrice.AutoSize = true;
            this.lblPackPrice.Location = new System.Drawing.Point(89, 363);
            this.lblPackPrice.Name = "lblPackPrice";
            this.lblPackPrice.Size = new System.Drawing.Size(77, 13);
            this.lblPackPrice.TabIndex = 1;
            this.lblPackPrice.Text = "Package Price";
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.Location = new System.Drawing.Point(407, 356);
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPackPrice.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 75);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(638, 132);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(602, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // EventPackageController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPackPrice);
            this.Controls.Add(this.txtStockCnt);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPackPrice);
            this.Controls.Add(this.lblStockCnt);
            this.Controls.Add(this.lblPackName);
            this.Controls.Add(this.lblPackID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventPackageController";
            this.Text = "EventPackageController";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPackID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPackName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStockCnt;
        private System.Windows.Forms.TextBox txtStockCnt;
        private System.Windows.Forms.Label lblPackPrice;
        private System.Windows.Forms.TextBox txtPackPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
    }
}