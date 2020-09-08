namespace InventorySystem
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.denyDataGrid = new System.Windows.Forms.DataGridView();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnRequest1 = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.stockCnt = new System.Windows.Forms.Label();
            this.lblItemNo2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtItemNo2 = new System.Windows.Forms.TextBox();
            this.txtStockCnt2 = new System.Windows.Forms.TextBox();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hme_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnRequest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblInventoryItems = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.denyDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // denyDataGrid
            // 
            this.denyDataGrid.AllowUserToAddRows = false;
            this.denyDataGrid.AllowUserToDeleteRows = false;
            this.denyDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.denyDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(129)))));
            this.denyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.denyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.denyDataGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.denyDataGrid.Location = new System.Drawing.Point(287, 45);
            this.denyDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.denyDataGrid.MultiSelect = false;
            this.denyDataGrid.Name = "denyDataGrid";
            this.denyDataGrid.ReadOnly = true;
            this.denyDataGrid.RowHeadersWidth = 70;
            this.denyDataGrid.Size = new System.Drawing.Size(903, 284);
            this.denyDataGrid.TabIndex = 0;
            this.denyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(13, 72);
            this.lblItemNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(54, 16);
            this.lblItemNo.TabIndex = 2;
            this.lblItemNo.Text = "Item No";
            this.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemNo.Click += new System.EventHandler(this.lblItemNo_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(13, 162);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(13, 118);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 16);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(137, 154);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRequest1
            // 
            this.btnRequest1.Location = new System.Drawing.Point(89, 394);
            this.btnRequest1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest1.Name = "btnRequest1";
            this.btnRequest1.Size = new System.Drawing.Size(121, 28);
            this.btnRequest1.TabIndex = 4;
            this.btnRequest1.Text = "Send Request";
            this.btnRequest1.UseVisualStyleBackColor = true;
            this.btnRequest1.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(137, 114);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(132, 22);
            this.txtItemName.TabIndex = 3;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemNo
            // 
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Location = new System.Drawing.Point(137, 72);
            this.txtItemNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.ReadOnly = true;
            this.txtItemNo.Size = new System.Drawing.Size(132, 22);
            this.txtItemNo.TabIndex = 3;
            this.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNo.TextChanged += new System.EventHandler(this.txtItemNo_TextChanged);
            // 
            // stockCnt
            // 
            this.stockCnt.AutoSize = true;
            this.stockCnt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCnt.Location = new System.Drawing.Point(604, 162);
            this.stockCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockCnt.Name = "stockCnt";
            this.stockCnt.Size = new System.Drawing.Size(77, 16);
            this.stockCnt.TabIndex = 1;
            this.stockCnt.Text = "Stock Count";
            this.stockCnt.UseWaitCursor = true;
            // 
            // lblItemNo2
            // 
            this.lblItemNo2.AutoSize = true;
            this.lblItemNo2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo2.Location = new System.Drawing.Point(604, 78);
            this.lblItemNo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemNo2.Name = "lblItemNo2";
            this.lblItemNo2.Size = new System.Drawing.Size(54, 16);
            this.lblItemNo2.TabIndex = 2;
            this.lblItemNo2.Text = "Item No";
            this.lblItemNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemNo2.UseWaitCursor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(604, 132);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Item Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.UseWaitCursor = true;
            // 
            // lblItemName2
            // 
            this.lblItemName2.AutoSize = true;
            this.lblItemName2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName2.ForeColor = System.Drawing.Color.Black;
            this.lblItemName2.Location = new System.Drawing.Point(604, 102);
            this.lblItemName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(73, 16);
            this.lblItemName2.TabIndex = 2;
            this.lblItemName2.Text = "Item Name";
            this.lblItemName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemName2.UseWaitCursor = true;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName2.Location = new System.Drawing.Point(775, 102);
            this.txtName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(132, 22);
            this.txtName2.TabIndex = 3;
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName2.UseWaitCursor = true;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice2.Location = new System.Drawing.Point(775, 132);
            this.txtPrice2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(132, 22);
            this.txtPrice2.TabIndex = 3;
            this.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice2.UseWaitCursor = true;
            // 
            // txtItemNo2
            // 
            this.txtItemNo2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo2.Location = new System.Drawing.Point(775, 72);
            this.txtItemNo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemNo2.Name = "txtItemNo2";
            this.txtItemNo2.ReadOnly = true;
            this.txtItemNo2.Size = new System.Drawing.Size(132, 22);
            this.txtItemNo2.TabIndex = 3;
            this.txtItemNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtItemNo2.UseWaitCursor = true;
            this.txtItemNo2.TextChanged += new System.EventHandler(this.txtItemNo2_TextChanged);
            this.txtItemNo2.MouseHover += new System.EventHandler(this.txtItemNo2_MouseHover);
            // 
            // txtStockCnt2
            // 
            this.txtStockCnt2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCnt2.Location = new System.Drawing.Point(775, 162);
            this.txtStockCnt2.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockCnt2.Name = "txtStockCnt2";
            this.txtStockCnt2.Size = new System.Drawing.Size(132, 22);
            this.txtStockCnt2.TabIndex = 3;
            this.txtStockCnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStockCnt2.UseWaitCursor = true;
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(129)))));
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.InventoryDataGrid.Location = new System.Drawing.Point(62, 78);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.Size = new System.Drawing.Size(444, 254);
            this.InventoryDataGrid.TabIndex = 5;
            this.InventoryDataGrid.UseWaitCursor = true;
            this.InventoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(598, 191);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(102, 31);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert Item";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.UseWaitCursor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(598, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.UseWaitCursor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(598, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.UseWaitCursor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picBx
            // 
            this.picBx.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picBx.Location = new System.Drawing.Point(775, 197);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(132, 109);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx.TabIndex = 7;
            this.picBx.TabStop = false;
            this.picBx.UseWaitCursor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(808, 245);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.UseWaitCursor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.hme_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 129);
            this.panel1.TabIndex = 23;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(9)))));
            this.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.FlatAppearance.BorderSize = 3;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.Goldenrod;
            this.logout_btn.Location = new System.Drawing.Point(1338, 90);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(83, 36);
            this.logout_btn.TabIndex = 38;
            this.logout_btn.Text = "<Back";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem.Properties.Resources.rbLONG;
            this.pictureBox2.Location = new System.Drawing.Point(514, 3);
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
            this.hme_btn.Location = new System.Drawing.Point(1249, 90);
            this.hme_btn.Name = "hme_btn";
            this.hme_btn.Size = new System.Drawing.Size(83, 36);
            this.hme_btn.TabIndex = 37;
            this.hme_btn.Text = "Home";
            this.hme_btn.UseVisualStyleBackColor = false;
            this.hme_btn.Click += new System.EventHandler(this.hme_btn_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::InventorySystem.Properties.Resources.orange_light;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1433, 923);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.btnRequest);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.bunifuGradientPanel1.Controls.Add(this.denyDataGrid);
            this.bunifuGradientPanel1.Controls.Add(this.lblItemNo);
            this.bunifuGradientPanel1.Controls.Add(this.lblQuantity);
            this.bunifuGradientPanel1.Controls.Add(this.lblItemName);
            this.bunifuGradientPanel1.Controls.Add(this.txtQuantity);
            this.bunifuGradientPanel1.Controls.Add(this.txtItemName);
            this.bunifuGradientPanel1.Controls.Add(this.txtItemNo);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(59, 134);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1241, 355);
            this.bunifuGradientPanel1.TabIndex = 25;
            // 
            // btnRequest
            // 
            this.btnRequest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRequest.BorderRadius = 0;
            this.btnRequest.ButtonText = "Send Request";
            this.btnRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequest.DisabledColor = System.Drawing.Color.Gray;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRequest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRequest.Iconimage")));
            this.btnRequest.Iconimage_right = null;
            this.btnRequest.Iconimage_right_Selected = null;
            this.btnRequest.Iconimage_Selected = null;
            this.btnRequest.IconMarginLeft = 0;
            this.btnRequest.IconMarginRight = 0;
            this.btnRequest.IconRightVisible = true;
            this.btnRequest.IconRightZoom = 0D;
            this.btnRequest.IconVisible = true;
            this.btnRequest.IconZoom = 90D;
            this.btnRequest.IsTab = false;
            this.btnRequest.Location = new System.Drawing.Point(97, 205);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRequest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRequest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRequest.selected = false;
            this.btnRequest.Size = new System.Drawing.Size(132, 53);
            this.btnRequest.TabIndex = 16;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Textcolor = System.Drawing.Color.White;
            this.btnRequest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 6;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(1239, 37);
            this.bunifuMaterialTextbox1.TabIndex = 14;
            this.bunifuMaterialTextbox1.Text = "Needed Items";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lblInventoryItems);
            this.bunifuGradientPanel2.Controls.Add(this.InventoryDataGrid);
            this.bunifuGradientPanel2.Controls.Add(this.stockCnt);
            this.bunifuGradientPanel2.Controls.Add(this.btnBrowse);
            this.bunifuGradientPanel2.Controls.Add(this.lblItemNo2);
            this.bunifuGradientPanel2.Controls.Add(this.picBx);
            this.bunifuGradientPanel2.Controls.Add(this.lblPrice);
            this.bunifuGradientPanel2.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel2.Controls.Add(this.lblItemName2);
            this.bunifuGradientPanel2.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel2.Controls.Add(this.txtName2);
            this.bunifuGradientPanel2.Controls.Add(this.btnInsert);
            this.bunifuGradientPanel2.Controls.Add(this.txtPrice2);
            this.bunifuGradientPanel2.Controls.Add(this.txtStockCnt2);
            this.bunifuGradientPanel2.Controls.Add(this.txtItemNo2);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(59, 524);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1240, 377);
            this.bunifuGradientPanel2.TabIndex = 26;
            // 
            // lblInventoryItems
            // 
            this.lblInventoryItems.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblInventoryItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventoryItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryItems.ForeColor = System.Drawing.Color.Black;
            this.lblInventoryItems.HintForeColor = System.Drawing.Color.Empty;
            this.lblInventoryItems.HintText = "";
            this.lblInventoryItems.isPassword = false;
            this.lblInventoryItems.LineFocusedColor = System.Drawing.Color.Blue;
            this.lblInventoryItems.LineIdleColor = System.Drawing.Color.Black;
            this.lblInventoryItems.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lblInventoryItems.LineThickness = 6;
            this.lblInventoryItems.Location = new System.Drawing.Point(0, 0);
            this.lblInventoryItems.Margin = new System.Windows.Forms.Padding(4);
            this.lblInventoryItems.Name = "lblInventoryItems";
            this.lblInventoryItems.Size = new System.Drawing.Size(1240, 37);
            this.lblInventoryItems.TabIndex = 15;
            this.lblInventoryItems.Text = "Inventory Items";
            this.lblInventoryItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblInventoryItems.UseWaitCursor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 923);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRequest1);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventForm";
            this.Text = "InventoryEvent";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.denyDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView denyDataGrid;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnRequest1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label stockCnt;
        private System.Windows.Forms.Label lblItemNo2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtItemNo2;
        private System.Windows.Forms.TextBox txtStockCnt2;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button hme_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRequest;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lblInventoryItems;
    }
}

