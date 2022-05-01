using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Configuration;
namespace WindowsFormsApplication
{
    public partial class FormGridClient : Form
    {
        public FormGridClient()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

        SqlCommand cmd;
        SqlDataAdapter da;
        SqlCommandBuilder cmbbuild;
        DataSet ds;
        DataTable dt_clients;
        int position = -1;

        private void FormGridClient_Load(object sender, EventArgs e)
        {
             cmd = new SqlCommand("SELECT * FROM CLIENT", cn);
             da = new SqlDataAdapter(cmd);
             ds = new DataSet();
             da.Fill(ds, "dt_clients");
             dt_clients = new DataTable();
            dt_clients=ds.Tables["dt_clients"];
            this.dataGridView1.DataSource = dt_clients;

        }

        private void rechecher(string codecli)
        {
            string s = "";
            for (int i = 0; i <= dt_clients.Rows.Count - 1; i++)
            {
                //s = dt_clients.Rows[i].ItemArray[0].ToString();
                //MessageBox.Show(s);
                //TrimEnd() permet d'enlever les espaces :
                if (dt_clients.Rows[i].ItemArray[0].ToString().TrimEnd().TrimStart() == codecli.ToString())
                {
                    position = i;
                    break;
                }
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // ajouter :
           
            cmbbuild = new SqlCommandBuilder(da);
            da.Update(dt_clients);
            dt_clients.Clear();
            da.Fill(dt_clients);

            MessageBox.Show("Bien ajouter");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Modifier :
            cmbbuild = new SqlCommandBuilder(da);
            da.Update(dt_clients);
            dt_clients.Clear();
            da.Fill(dt_clients);

            MessageBox.Show("Bien modifier");
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Vider
            
            this.dataGridView1.DataSource = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //charger données :
            FormGridClient_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // supprimer :

           // dt_clients.Rows[this.dataGridView1.CurrentRow.Index].Delete();
            this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);

            cmbbuild = new SqlCommandBuilder(da);
            da.Update(dt_clients);
            dt_clients.Clear();
            da.Fill(dt_clients);

            MessageBox.Show("Bien supprimer");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // importer space name Microsoft.VisualBasic pour travailler avec Interaction
            string response = Microsoft.VisualBasic.Interaction.InputBox("Saisir cin client à rechercher puis cliquez sur OK !", "Rechercher client par son numéro");

            if (!String.IsNullOrEmpty(response))
            {
                rechecher(response);
                if (position != -1)
                {
                    this.dataGridView1.Rows[position].Selected = true;
                }
            }

        }


        

        


    }
}
