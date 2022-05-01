namespace WindowsFormsApplication
{
    partial class FormHistogrammeNombreClientParVille
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
            this.db_assureDataSet = new WindowsFormsApplication.db_assureDataSet();
            this.NombreClientParVilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreClientParVilleTableAdapter = new WindowsFormsApplication.db_assureDataSetTableAdapters.NombreClientParVilleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_assureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreClientParVilleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NombreClientParVilleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication.Report1HistogrammeNombreClientParVillerdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_assureDataSet
            // 
            this.db_assureDataSet.DataSetName = "db_assureDataSet";
            this.db_assureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NombreClientParVilleBindingSource
            // 
            this.NombreClientParVilleBindingSource.DataMember = "NombreClientParVille";
            this.NombreClientParVilleBindingSource.DataSource = this.db_assureDataSet;
            // 
            // NombreClientParVilleTableAdapter
            // 
            this.NombreClientParVilleTableAdapter.ClearBeforeFill = true;
            // 
            // FormHistogrammeNombreClientParVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 426);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormHistogrammeNombreClientParVille";
            this.Text = "FormHistogrammeNombreClientParVille";
            this.Load += new System.EventHandler(this.FormHistogrammeNombreClientParVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_assureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreClientParVilleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NombreClientParVilleBindingSource;
        private db_assureDataSet db_assureDataSet;
        private db_assureDataSetTableAdapters.NombreClientParVilleTableAdapter NombreClientParVilleTableAdapter;
    }
}