using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApplication
{
    public partial class FormImporterDataFromXMLtoDataGridView : Form
    {
        public FormImporterDataFromXMLtoDataGridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// le chemin du fichier xmlFile et par defaut : dossier racine de l'application / BIN / DEBUG
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Client.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

       
    }
}
