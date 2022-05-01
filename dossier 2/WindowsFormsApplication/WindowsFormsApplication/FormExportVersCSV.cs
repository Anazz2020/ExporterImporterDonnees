using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
namespace WindowsFormsApplication
{
    public partial class FormExportVersCSV : Form
    {
        public FormExportVersCSV()
        {
            InitializeComponent();
        }



        private void FormExportVersCSV_Load(object sender, EventArgs e)
        {
            DataTable dt = UtilitaireExportCSV.createDataTable();
            //MessageBox.Show(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
        }

        private void buttonExportToCsv_Click(object sender, EventArgs e)
        {
           
               
                    DataTable dt = UtilitaireExportCSV.createDataTable(); // c'est une classe <<<<<< static >>>>> réalisé dans le projet
                    string fileName = saveFileDialog1.FileName; // chemin de sauvegarde 
                    dt.ExportToCSV("Client.CSV"); // le fichier est enregistrer dans le dossier racine de l'application / bin / debug
                    MessageBox.Show("Fichier crée avec succées");

              






            }
        }
    }

