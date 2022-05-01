namespace WindowsFormsApplication
{
    partial class FormRechercherCheque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxDateEmission = new System.Windows.Forms.CheckBox();
            this.checkBoxMnt = new System.Windows.Forms.CheckBox();
            this.checkBoxMotif = new System.Windows.Forms.CheckBox();
            this.checkBoxBanque = new System.Windows.Forms.CheckBox();
            this.checkBoxCin = new System.Windows.Forms.CheckBox();
            this.checkBoxMagasin = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxMnt = new System.Windows.Forms.TextBox();
            this.textBoxCin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.comboBoxBnq = new System.Windows.Forms.ComboBox();
            this.comboBoxMagasin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxDateEmission
            // 
            this.checkBoxDateEmission.AutoSize = true;
            this.checkBoxDateEmission.Location = new System.Drawing.Point(59, 24);
            this.checkBoxDateEmission.Name = "checkBoxDateEmission";
            this.checkBoxDateEmission.Size = new System.Drawing.Size(92, 17);
            this.checkBoxDateEmission.TabIndex = 1;
            this.checkBoxDateEmission.Text = "Date émission";
            this.checkBoxDateEmission.UseVisualStyleBackColor = true;
            // 
            // checkBoxMnt
            // 
            this.checkBoxMnt.AutoSize = true;
            this.checkBoxMnt.Location = new System.Drawing.Point(59, 51);
            this.checkBoxMnt.Name = "checkBoxMnt";
            this.checkBoxMnt.Size = new System.Drawing.Size(65, 17);
            this.checkBoxMnt.TabIndex = 2;
            this.checkBoxMnt.Text = "Montant";
            this.checkBoxMnt.UseVisualStyleBackColor = true;
            // 
            // checkBoxMotif
            // 
            this.checkBoxMotif.AutoSize = true;
            this.checkBoxMotif.Location = new System.Drawing.Point(59, 80);
            this.checkBoxMotif.Name = "checkBoxMotif";
            this.checkBoxMotif.Size = new System.Drawing.Size(72, 17);
            this.checkBoxMotif.TabIndex = 4;
            this.checkBoxMotif.Text = "Motif rejet";
            this.checkBoxMotif.UseVisualStyleBackColor = true;
            // 
            // checkBoxBanque
            // 
            this.checkBoxBanque.AutoSize = true;
            this.checkBoxBanque.Location = new System.Drawing.Point(59, 141);
            this.checkBoxBanque.Name = "checkBoxBanque";
            this.checkBoxBanque.Size = new System.Drawing.Size(63, 17);
            this.checkBoxBanque.TabIndex = 3;
            this.checkBoxBanque.Text = "Banque";
            this.checkBoxBanque.UseVisualStyleBackColor = true;
            // 
            // checkBoxCin
            // 
            this.checkBoxCin.AutoSize = true;
            this.checkBoxCin.Location = new System.Drawing.Point(59, 110);
            this.checkBoxCin.Name = "checkBoxCin";
            this.checkBoxCin.Size = new System.Drawing.Size(41, 17);
            this.checkBoxCin.TabIndex = 5;
            this.checkBoxCin.Text = "Cin";
            this.checkBoxCin.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagasin
            // 
            this.checkBoxMagasin.AutoSize = true;
            this.checkBoxMagasin.Location = new System.Drawing.Point(59, 168);
            this.checkBoxMagasin.Name = "checkBoxMagasin";
            this.checkBoxMagasin.Size = new System.Drawing.Size(66, 17);
            this.checkBoxMagasin.TabIndex = 6;
            this.checkBoxMagasin.Text = "Magasin";
            this.checkBoxMagasin.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxMnt
            // 
            this.textBoxMnt.Location = new System.Drawing.Point(179, 51);
            this.textBoxMnt.Name = "textBoxMnt";
            this.textBoxMnt.Size = new System.Drawing.Size(200, 20);
            this.textBoxMnt.TabIndex = 8;
            // 
            // textBoxCin
            // 
            this.textBoxCin.Location = new System.Drawing.Point(179, 110);
            this.textBoxCin.Name = "textBoxCin";
            this.textBoxCin.Size = new System.Drawing.Size(200, 20);
            this.textBoxCin.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(179, 80);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMotif.TabIndex = 14;
            // 
            // comboBoxBnq
            // 
            this.comboBoxBnq.FormattingEnabled = true;
            this.comboBoxBnq.Location = new System.Drawing.Point(179, 141);
            this.comboBoxBnq.Name = "comboBoxBnq";
            this.comboBoxBnq.Size = new System.Drawing.Size(200, 21);
            this.comboBoxBnq.TabIndex = 15;
            // 
            // comboBoxMagasin
            // 
            this.comboBoxMagasin.FormattingEnabled = true;
            this.comboBoxMagasin.Location = new System.Drawing.Point(179, 168);
            this.comboBoxMagasin.Name = "comboBoxMagasin";
            this.comboBoxMagasin.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMagasin.TabIndex = 16;
            // 
            // FormRechercherCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 416);
            this.Controls.Add(this.comboBoxMagasin);
            this.Controls.Add(this.comboBoxBnq);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCin);
            this.Controls.Add(this.textBoxMnt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxMagasin);
            this.Controls.Add(this.checkBoxCin);
            this.Controls.Add(this.checkBoxMotif);
            this.Controls.Add(this.checkBoxBanque);
            this.Controls.Add(this.checkBoxMnt);
            this.Controls.Add(this.checkBoxDateEmission);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRechercherCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRechercherCheque";
            this.Load += new System.EventHandler(this.FormRechercherCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxDateEmission;
        private System.Windows.Forms.CheckBox checkBoxMnt;
        private System.Windows.Forms.CheckBox checkBoxMotif;
        private System.Windows.Forms.CheckBox checkBoxBanque;
        private System.Windows.Forms.CheckBox checkBoxCin;
        private System.Windows.Forms.CheckBox checkBoxMagasin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxMnt;
        private System.Windows.Forms.TextBox textBoxCin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.ComboBox comboBoxBnq;
        private System.Windows.Forms.ComboBox comboBoxMagasin;
    }
}