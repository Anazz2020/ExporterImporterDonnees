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
    public partial class FormDeconnecteClient : Form
    {
        public FormDeconnecteClient()
        {
            InitializeComponent();
        }

      private  SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        
        //Uniquement déclarations des objets sans intantiation ni chargement
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataRow dr;
        private SqlCommandBuilder cmdBuild;
        private int RowNumber=0;
        private int position = -1;
        
        //Déclaration de l'objet DataTable :
        private DataTable dt;


        // 1 : chargement des données dans l'objet dt :
        private DataTable charger()
        {
            cmd = new SqlCommand("SELECT * FROM Client", cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "MajClient");
            dt = ds.Tables["MajClient"];
            return dt;
        }

        // 2 : afficher les donées :
        private void afficher(int index)
        {
            this.textBox1.Text = dt.Rows[index].ItemArray[0].ToString();
           if( dt.Rows[index].ItemArray[1].ToString() == "Homme")
           {
           this.radioButton1.Checked = true;
           }
            else
           {
               this.radioButton2.Checked = true;
           }
           this.textBox2.Text = dt.Rows[index].ItemArray[2].ToString();
           this.textBox3.Text = dt.Rows[index].ItemArray[3].ToString();
           this.textBox4.Text = dt.Rows[index].ItemArray[4].ToString();
           this.textBox5.Text = dt.Rows[index].ItemArray[5].ToString();
           this.textBox6.Text = dt.Rows[index].ItemArray[6].ToString();
           this.comboBox1.SelectedValue = dt.Rows[index].ItemArray[7].ToString();
           this.textBoxEmail.Text = dt.Rows[index].ItemArray[8].ToString();


            // selectionner la ligne adéquate dans la grille de données :
            // desactiver la propriété multi select :
           this.dataGridView1.Rows[index].Selected = true;
              

        
        }

        // 3 : navigation : (cliquer sur les bouttons de chaque evenement : premier , suivant , precedent et dernier)
      
        // 4 : Mise à jour (Ajouter , supprimer , modifier et enregistrer)

        // 5 : Rechercher

        private void rechercher(string pk)
        {
            position = -1;

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (pk.ToLower().Equals(dt.Rows[i].ItemArray[0].ToString().ToLower()))
                {
                    position = i;
                    break;
                }
            }
        }


        private DataTable ListeMagasins()
        {
            
            SqlCommand cmd = new SqlCommand("SELECT numero_magasin,libelle_magasin FROM Magasin", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ListeMagasins");
            return ds.Tables["ListeMagasins"];
        
        }

       

        private void FormDeconnecteClient_Load(object sender, EventArgs e)
        {
            // remplir liste des magasins :
            comboBox1.DataSource = ListeMagasins();
            comboBox1.DisplayMember = "libelle_magasin";
            comboBox1.ValueMember = "numero_magasin";
            comboBox1.Refresh();


            /// chargement des données dans la grille de données :
            dataGridView1.DataSource = charger();


            if (dt.Rows.Count > 0)
            {
                afficher(RowNumber);
            }

        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            // premier :
            RowNumber = 0;
           afficher(RowNumber);
        }

        private void button1Dernier_Click(object sender, EventArgs e)
        {
            // dernier :
            RowNumber = dt.Rows.Count - 1;
            afficher(RowNumber);

        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            //precedent :
            if (RowNumber == 0)
            {
                RowNumber = dt.Rows.Count - 1;
            }
            else
            {
                RowNumber -= 1;
            }
            afficher(RowNumber);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            //Suivant :
            if (RowNumber == dt.Rows.Count - 1)
            { 
            RowNumber = 0;
            }
             else
            {
                RowNumber += 1;
            }
            afficher(RowNumber);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblNavigation.Text ="Row : " + (RowNumber + 1).ToString() + " of " + dt.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ajouter :
            dr = dt.NewRow();
            dr[0] = this.textBox1.Text;
            dr[1] = this.radioButton1.Checked ? "Homme" : "Femme";
            dr[2] = this.textBox2.Text;
            dr[3] = this.textBox3.Text;
            dr[4] = this.textBox4.Text;
            dr[5] = this.textBox5.Text;
            dr[6] = this.textBox6.Text;
            dr[7] = this.comboBox1.SelectedValue;
            dr[8] = this.textBoxEmail.Text;
            // ajouter l'objet dr dans l'objet dt
            dt.Rows.Add(dr);

            MessageBox.Show("Bien ajouter");
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // modifier :
            dr = dt.Rows[RowNumber];
            dr[0] = this.textBox1.Text;
            dr[1] = this.radioButton1.Checked ? "Homme" : "Femme";
            dr[2] = this.textBox2.Text;
            dr[3] = this.textBox3.Text;
            dr[4] = this.textBox4.Text;
            dr[5] = this.textBox5.Text;
            dr[6] = this.textBox6.Text;
            dr[7] = this.comboBox1.SelectedValue;
            dr[8] = this.textBoxEmail.Text;
           
            MessageBox.Show("Bien modifier");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // supprimer :
            dt.Rows[RowNumber].Delete();
            MessageBox.Show("Bien supprimer");

            if (RowNumber > 0)
            {
                RowNumber -= 1;
            }
            else
            {
                RowNumber += 1;
            }
            afficher(RowNumber);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // enregistrer :
            cmdBuild = new SqlCommandBuilder(da);

            da.Update(dt);
            dt.Clear();
            da.Fill(dt);

            MessageBox.Show("Enregistrement réussi");

           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // rechercher :

            rechercher(this.textBox1.Text);

            // test resultat :
            if (position == -1)
            {
                MessageBox.Show(this.textBox1.Text + " est introuvable");
            }
            else
            {
                RowNumber = position;
                afficher(RowNumber);
            }

        }

        // fonction pour tester email :
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(this.textBoxEmail.Text))
            {
                MessageBox.Show("email invalide");
                e.Cancel = true;
            }
        }
        

        }
    }

