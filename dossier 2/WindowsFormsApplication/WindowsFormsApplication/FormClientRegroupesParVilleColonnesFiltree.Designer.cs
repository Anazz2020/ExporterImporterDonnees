namespace WindowsFormsApplication
{
    partial class FormClientRegroupesParVilleColonnesFiltree
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListeClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_assureDataSet = new WindowsFormsApplication.db_assureDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListeClientTableAdapter = new WindowsFormsApplication.db_assureDataSetTableAdapters.ListeClientTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMagasin = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new WindowsFormsApplication.db_assureDataSetTableAdapters.villeTableAdapter();
            this.magasinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magasinTableAdapter = new WindowsFormsApplication.db_assureDataSetTableAdapters.magasinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListeClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_assureDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magasinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeClientBindingSource
            // 
            this.ListeClientBindingSource.DataMember = "ListeClient";
            this.ListeClientBindingSource.DataSource = this.db_assureDataSet;
            // 
            // db_assureDataSet
            // 
            this.db_assureDataSet.DataSetName = "db_assureDataSet";
            this.db_assureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.ListeClientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication.ReportListeClientGroupesColonnesParMagasin.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(902, 388);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListeClientTableAdapter
            // 
            this.ListeClientTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxMagasin);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(451, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher client par magasin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chosir magasin :";
            // 
            // comboBoxMagasin
            // 
            this.comboBoxMagasin.DataSource = this.magasinBindingSource;
            this.comboBoxMagasin.DisplayMember = "libelle_magasin";
            this.comboBoxMagasin.FormattingEnabled = true;
            this.comboBoxMagasin.Location = new System.Drawing.Point(128, 24);
            this.comboBoxMagasin.Name = "comboBoxMagasin";
            this.comboBoxMagasin.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMagasin.TabIndex = 5;
            this.comboBoxMagasin.ValueMember = "libelle_magasin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Afficher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxVille);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher client par ville :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chosir une ville";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DataSource = this.villeBindingSource;
            this.comboBoxVille.DisplayMember = "Ville";
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(128, 24);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(165, 21);
            this.comboBoxVille.TabIndex = 5;
            this.comboBoxVille.ValueMember = "Ville";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "ville";
            this.villeBindingSource.DataSource = this.db_assureDataSet;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // magasinBindingSource
            // 
            this.magasinBindingSource.DataMember = "magasin";
            this.magasinBindingSource.DataSource = this.db_assureDataSet;
            // 
            // magasinTableAdapter
            // 
            this.magasinTableAdapter.ClearBeforeFill = true;
            // 
            // FormClientRegroupesParVilleColonnesFiltree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormClientRegroupesParVilleColonnesFiltree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientRegroupesParVilleColonnes filtrage";
            this.Load += new System.EventHandler(this.FormClientRegroupesParVilleColonnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_assureDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magasinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListeClientBindingSource;
        private db_assureDataSet db_assureDataSet;
        private db_assureDataSetTableAdapters.ListeClientTableAdapter ListeClientTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMagasin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private db_assureDataSetTableAdapters.villeTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource magasinBindingSource;
        private db_assureDataSetTableAdapters.magasinTableAdapter magasinTableAdapter;
    }
}