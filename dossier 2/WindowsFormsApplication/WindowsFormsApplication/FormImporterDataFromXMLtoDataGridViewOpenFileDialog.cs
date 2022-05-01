using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormImporterDataFromXMLtoDataGridViewOpenFileDialog : Form
    {
        public FormImporterDataFromXMLtoDataGridViewOpenFileDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             // parcourir le chemin du fichier par le controle OpenFileDialogue : (Le chemin du fichier est dans le dossier racine de l'application / BIN / DEBUG )
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckPathExists = true;
            dlg.CheckFileExists = true;
            openFileDialog1.Filter = "XML|*.XML|BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            openFileDialog1.FilterIndex = 1;

            dlg.ShowDialog();
            //MessageBox.Show(fileName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {


                string fileName;
                fileName = dlg.FileName;

                System.Xml.XmlReader xmlFile;
                xmlFile = System.Xml.XmlReader.Create(fileName, new System.Xml.XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                this.dataGridView1.DataSource = ds.Tables[0];

            }
        }
        }
    }

