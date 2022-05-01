using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication
{
    public partial class FormExportDataFromDataSetToXML : Form
    {
        public FormExportDataFromDataSetToXML()
        {
            InitializeComponent();
        }
        
        DataTable dt; 

        private void button1_Click(object sender, EventArgs e)
        {

            // avec la base de données :

            // sans base de données :

            DataSet ds = new DataSet();

            dt = new DataTable();

            dt.Columns.Add(new DataColumn("cin", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Genre", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Nom", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("numero_magasin", Type.GetType("System.Int32")));

            AjouterLigne("cin 10", "Homme", "Ali", 1111);
            AjouterLigne("cin 11", "Homme", "Allal", 2222);
            AjouterLigne("cin 12", "Homme", "Foad", 3333);
            AjouterLigne("cin 13", "Homme", "Rachid", 4444);

            ds.Tables.Add(dt);
            ds.Tables[0].TableName="Client";

            ds.WriteXml("Client2020.xml");
            MessageBox.Show("Fichier crée avec succées");
        }

        private void AjouterLigne(string cin, string genre, string nom , int magasin)
        {
            DataRow dr;
            dr = dt.NewRow();
            dr["cin"] = cin;
            dr["Genre"] = genre;
            dr["Nom"] = nom;
            dr["numero_magasin"] = magasin;

            dt.Rows.Add(dr);
        }

        private void FormExportDataFromDataSetToXML_Load(object sender, EventArgs e)
        {

        } 
    }
}
