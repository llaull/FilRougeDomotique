namespace domotiqueControle
{
    partial class rapport24h
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
            this._24hBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domotiqueDataSet = new domotiqueControle.domotiqueDataSet();
            this._24hTableAdapter = new domotiqueControle.domotiqueDataSetTableAdapters._24hTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this._24hBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domotiqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // _24hBindingSource
            // 
            this._24hBindingSource.DataMember = "24h";
            this._24hBindingSource.DataSource = this.domotiqueDataSet;
            // 
            // domotiqueDataSet
            // 
            this.domotiqueDataSet.DataSetName = "domotiqueDataSet";
            this.domotiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _24hTableAdapter
            // 
            this._24hTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "report24h";
            reportDataSource1.Value = this._24hBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "domotiqueControle.report24h.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(644, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // rapport24h
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rapport24h";
            this.Text = "rapport";
            this.Load += new System.EventHandler(this.rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this._24hBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domotiqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource _24hBindingSource;
        private domotiqueDataSet domotiqueDataSet;
        private domotiqueDataSetTableAdapters._24hTableAdapter _24hTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}