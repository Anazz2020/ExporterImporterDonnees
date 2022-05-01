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
    public partial class FormRechercherCheque : Form
    {
        public FormRechercherCheque()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString());


        // fonction qui verifie si une chaine de caractére est commencé par le mot : and 
        // si oui alors il faut supprimer and et retourne uniquement la chaine apres and pour eviter que where devient : where and nomColonne=?
        private string GetQuery(string str)
        {
            string resultat ;
            if (str.Length > 0)
            {
                string s = str.Substring(0, 2);
                if (s == "OR")
                {
                    //MessageBox.Show(str.Substring(3, 24-3));
                    resultat = str.Substring(3, str.Length-3);
                }
                else
                {
                    resultat = str;
                }
            }
            else
            {
                resultat="";
            }
                return " where " + resultat;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //afficher :


            string query = " SELECT C.numero_cheque, C.date_emission, C.cin , C.montant, M.libelle_motif, C.code_banque, Mg.libelle_magasin " +
                           " FROM Cheque AS C INNER JOIN magasin AS Mg ON C.numero_magasin = Mg.numero_magasin " +
                           "                  INNER JOIN MotifsRejet AS M ON C.code_motif = M.code_motif ";
            string where =String.Empty;

            if (this.checkBoxDateEmission.Checked)
                where += " C.date_emission='" + this.dateTimePicker1.Value.Date + "' ";
            if (this.checkBoxMnt.Checked)
                where += "OR C.montant=" + this.textBoxMnt.Text + " ";
            if (this.checkBoxMotif.Checked)
                where += "OR M.libelle_motif='" + this.comboBoxMotif.Text + "' ";
            if (this.checkBoxCin.Checked)
                where += "OR C.cin='" + this.textBoxCin.Text + "' ";
            if (this.checkBoxBanque.Checked)
                where += "OR C.code_banque='" + this.comboBoxBnq.Text + "' ";
            if (this.checkBoxMagasin.Checked)
                where += "OR Mg.libelle_magasin='" + this.comboBoxMagasin.Text + "' ";

            if (where.Length>0)
            query +=  GetQuery(where);

            SqlCommand cmd = new SqlCommand(query, cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "cheque");

            this.dataGridView1.DataSource = ds.Tables["cheque"];


            }

        private DataTable MotifsRejet()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MotifsRejet", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "MotifsRejet");
            return ds.Tables["MotifsRejet"];
        }

        private DataTable banque()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Banque", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Banque");
            return ds.Tables["Banque"];
        }

        private DataTable magasin()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM magasin", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "magasin");
            return ds.Tables["magasin"];
        }

        

        private void FormRechercherCheque_Load(object sender, EventArgs e)
        {
            // liste motif rejet :
            this.comboBoxMotif.DataSource = MotifsRejet();
            this.comboBoxMotif.DisplayMember = "libelle_motif";
            this.comboBoxMotif.ValueMember = "libelle_motif";

            // liste banque :
            this.comboBoxBnq.DataSource = banque();
            this.comboBoxBnq.DisplayMember = "code_banque";
            this.comboBoxBnq.ValueMember = "code_banque";

            // liste magasin :
            this.comboBoxMagasin.DataSource = magasin();
            this.comboBoxMagasin.DisplayMember = "libelle_magasin";
            this.comboBoxMagasin.ValueMember = "libelle_magasin";


        }
    }
}
