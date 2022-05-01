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
    public partial class FormHistogrammeNombreClientParVille : Form
    {
        public FormHistogrammeNombreClientParVille()
        {
            InitializeComponent();
        }

        private void FormHistogrammeNombreClientParVille_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db_assureDataSet.NombreClientParVille'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.NombreClientParVilleTableAdapter.Fill(this.db_assureDataSet.NombreClientParVille);

            this.reportViewer1.RefreshReport();
        }
    }
}
