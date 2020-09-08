namespace InventorySystem
{
    partial class Employee_Details_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeeDetDS = new InventorySystem.EmployeeDetDS();
            this.Employee_DetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employee_DetTableAdapter = new InventorySystem.EmployeeDetDSTableAdapters.Employee_DetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Employee_DetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InventorySystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmployeeDetDS
            // 
            this.EmployeeDetDS.DataSetName = "EmployeeDetDS";
            this.EmployeeDetDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employee_DetBindingSource
            // 
            this.Employee_DetBindingSource.DataMember = "Employee_Det";
            this.Employee_DetBindingSource.DataSource = this.EmployeeDetDS;
            // 
            // Employee_DetTableAdapter
            // 
            this.Employee_DetTableAdapter.ClearBeforeFill = true;
            // 
            // Employee_Details_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Employee_Details_Report";
            this.Text = "Employee_Details_Report";
            this.Load += new System.EventHandler(this.Employee_Details_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_DetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Employee_DetBindingSource;
        private EmployeeDetDS EmployeeDetDS;
        private EmployeeDetDSTableAdapters.Employee_DetTableAdapter Employee_DetTableAdapter;
    }
}