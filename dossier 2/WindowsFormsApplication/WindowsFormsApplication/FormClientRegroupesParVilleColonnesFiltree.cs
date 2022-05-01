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
    public partial class FormClientRegroupesParVilleColonnesFiltree : Form
    {
        public FormClientRegroupesParVilleColonnesFiltree()
        {
            InitializeComponent();
        }

        private void FormClientRegroupesParVilleColonnes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_assureDataSet.magasin'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.magasinTableAdapter.Fill(this.db_assureDataSet.magasin);
            // TODO: cette ligne de code charge les données dans la table 'db_assureDataSet.ville'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.villeTableAdapter.Fill(this.db_assureDataSet.ville);
            // TODO: cette ligne de code charge les données dans la table 'db_assureDataSet.ListeClient'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ListeClientTableAdapter.Fill(this.db_assureDataSet.ListeClient);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // afficher par ville :
            this.ListeClientTableAdapter.FillByVille(db_assureDataSet.ListeClient, this.comboBoxVille.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // afficher par magasin :
            this.ListeClientTableAdapter.FillByMagasin(db_assureDataSet.ListeClient, this.comboBoxMagasin.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
