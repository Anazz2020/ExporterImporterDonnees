namespace WindowsFormsApplication
{
    partial class FormExportVersCSV
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
            this.buttonExportToCsv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExportToCsv
            // 
            this.buttonExportToCsv.Location = new System.Drawing.Point(403, 67);
            this.buttonExportToCsv.Name = "buttonExportToCsv";
            this.buttonExportToCsv.Size = new System.Drawing.Size(176, 23);
            this.buttonExportToCsv.TabIndex = 0;
            this.buttonExportToCsv.Text = "Export to CSV";
            this.buttonExportToCsv.UseVisualStyleBackColor = true;
            this.buttonExportToCsv.Click += new System.EventHandler(this.buttonExportToCsv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormExportVersCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExportToCsv);
            this.Name = "FormExportVersCSV";
            this.Text = "FormExportVersCSV";
            this.Load += new System.EventHandler(this.FormExportVersCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExportToCsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}