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
    public partial class FormExporterDataFormTableToXml : Form
    {
        public FormExporterDataFormTableToXml()
        {
            InitializeComponent();
        }

        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Banque", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ds.WriteXml("Banque2020.xml");
            MessageBox.Show("Fichier bien crée");
        }
    }
}
