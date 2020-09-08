namespace InventorySystem.control
{
    partial class package_wedd_1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pakagename = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.fname_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ID_combo = new System.Windows.Forms.ComboBox();
            this.circularButton1 = new InventorySystem.supportiveClasses.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pakagename
            // 
            this.pakagename.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pakagename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pakagename.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pakagename.ForeColor = System.Drawing.Color.White;
            this.pakagename.HintForeColor = System.Drawing.Color.Empty;
            this.pakagename.HintText = "";
            this.pakagename.isPassword = false;
            this.pakagename.LineFocusedColor = System.Drawing.Color.Blue;
            this.pakagename.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(138)))), ((int)(((byte)(48)))));
            this.pakagename.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pakagename.LineThickness = 4;
            this.pakagename.Location = new System.Drawing.Point(440, 6);
            this.pakagename.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pakagename.Name = "pakagename";
            this.pakagename.Size = new System.Drawing.Size(568, 47);
            this.pakagename.TabIndex = 0;
            this.pakagename.Text = "bunifuMaterialTextbox1";
            this.pakagename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slidePic
            // 
            this.slidePic.Image = global::InventorySystem.Properties.Resources.RB;
            this.slidePic.Location = new System.Drawing.Point(79, 186);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(802, 535);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePic.TabIndex = 1;
            this.slidePic.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(171)))), ((int)(((byte)(68)))));
            this.bunifuImageButton1.Image = global::InventorySystem.Properties.Resources.kisspng_brand_logo_black_and_white_triangle_arrow_symbol_5a76c6d1df2c13_8388288415177335859141;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(13, 24);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // fname_txt
            // 
            this.fname_txt.AutoSize = true;
            this.fname_txt.BackColor = System.Drawing.Color.White;
            this.fname_txt.ForeColor = System.Drawing.Color.Black;
            this.fname_txt.Location = new System.Drawing.Point(1284, 122);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(36, 13);
            this.fname_txt.TabIndex = 12;
            this.fname_txt.Text = "CusID";
            // 
            // ID_combo
            // 
            this.ID_combo.FormattingEnabled = true;
            this.ID_combo.Location = new System.Drawing.Point(1287, 169);
            this.ID_combo.Name = "ID_combo";
            this.ID_combo.Size = new System.Drawing.Size(172, 21);
            this.ID_combo.TabIndex = 13;
            this.ID_combo.SelectedIndexChanged += new System.EventHandler(this.ID_combo_SelectedIndexChanged_1);
            // 
            // circularButton1
            // 
            this.circularButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.circularButton1.AllowDrop = true;
            this.circularButton1.Location = new System.Drawing.Point(1101, 403);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(75, 23);
            this.circularButton1.TabIndex = 14;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // package_wedd_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.ID_combo);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.slidePic);
            this.Controls.Add(this.pakagename);
            this.Name = "package_wedd_1";
            this.Size = new System.Drawing.Size(1489, 816);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox pakagename;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel fname_txt;
        private System.Windows.Forms.ComboBox ID_combo;
        private supportiveClasses.CircularButton circularButton1;
    }
}
