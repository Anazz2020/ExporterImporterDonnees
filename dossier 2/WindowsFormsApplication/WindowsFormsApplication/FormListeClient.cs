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
    public partial class FormListeClient : Form
    {
        public FormListeClient()
        {
            InitializeComponent();
        }

        private void FormListeClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_assureDataSet.ListeClient'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ListeClientTableAdapter.Fill(this.db_assureDataSet.ListeClient);
            this.reportViewer1.RefreshReport();
        }
    }
}
