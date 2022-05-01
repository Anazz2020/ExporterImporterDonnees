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
    public partial class Form2ListeClient : Form
    {
        public Form2ListeClient()
        {
            InitializeComponent();
        }

        private void Form2ListeClient_Load(object sender, EventArgs e)
        {

            this.ListeClientTableAdapter.Fill(db_assureDataSet.ListeClient);
            this.reportViewer1.RefreshReport();
        }
    }
}
