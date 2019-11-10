namespace BanTraSua
{
    partial class in_HoaDon
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
            this.HoaDon_DataSet2 = new BanTraSua.HoaDon_DataSet2();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new BanTraSua.HoaDon_DataSet2TableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BanTraSua.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(579, 386);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // HoaDon_DataSet2
            // 
            this.HoaDon_DataSet2.DataSetName = "HoaDon_DataSet2";
            this.HoaDon_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.HoaDon_DataSet2;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // in_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "in_HoaDon";
            this.Text = "in_HoaDon";
            this.Load += new System.EventHandler(this.in_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private HoaDon_DataSet2 HoaDon_DataSet2;
        private HoaDon_DataSet2TableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}