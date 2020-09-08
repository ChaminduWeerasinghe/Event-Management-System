namespace InventorySystem
{
    partial class Login
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
            this.btnSignin = new System.Windows.Forms.Button();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.linklbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(127, 251);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(75, 23);
            this.btnSignin.TabIndex = 0;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Location = new System.Drawing.Point(70, 93);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(61, 13);
            this.lblUN.TabIndex = 1;
            this.lblUN.Text = "Username :";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(70, 168);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(59, 13);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password :";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(185, 93);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(100, 20);
            this.txtun.TabIndex = 2;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(185, 161);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(100, 20);
            this.txtpw.TabIndex = 2;
            // 
            // linklbl
            // 
            this.linklbl.AutoSize = true;
            this.linklbl.Location = new System.Drawing.Point(141, 300);
            this.linklbl.Name = "linklbl";
            this.linklbl.Size = new System.Drawing.Size(40, 13);
            this.linklbl.TabIndex = 3;
            this.linklbl.TabStop = true;
            this.linklbl.Text = "Signup";
            this.linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 336);
            this.Controls.Add(this.linklbl);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.btnSignin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.LinkLabel linklbl;
    }
}