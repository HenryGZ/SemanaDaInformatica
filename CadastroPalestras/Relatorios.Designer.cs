namespace CadastroPalestras
{
    partial class Relatorios
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
            this.dBPalestrasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPalestrasDataSet = new CadastroPalestras.DBPalestrasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.palestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palestrasTableAdapter = new CadastroPalestras.DBPalestrasDataSetTableAdapters.PalestrasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBPalestrasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPalestrasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palestrasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBPalestrasDataSetBindingSource
            // 
            this.dBPalestrasDataSetBindingSource.DataSource = this.dBPalestrasDataSet;
            this.dBPalestrasDataSetBindingSource.Position = 0;
            // 
            // dBPalestrasDataSet
            // 
            this.dBPalestrasDataSet.DataSetName = "DBPalestrasDataSet";
            this.dBPalestrasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.palestrasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CadastroPalestras.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // palestrasBindingSource
            // 
            this.palestrasBindingSource.DataMember = "Palestras";
            this.palestrasBindingSource.DataSource = this.dBPalestrasDataSetBindingSource;
            // 
            // palestrasTableAdapter
            // 
            this.palestrasTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Relatórios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBPalestrasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPalestrasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palestrasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dBPalestrasDataSetBindingSource;
        private DBPalestrasDataSet dBPalestrasDataSet;
        private System.Windows.Forms.BindingSource palestrasBindingSource;
        private DBPalestrasDataSetTableAdapters.PalestrasTableAdapter palestrasTableAdapter;
    }
}