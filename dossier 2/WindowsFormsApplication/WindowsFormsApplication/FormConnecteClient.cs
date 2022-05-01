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
    public partial class FormConnecteClient : Form
    {
        public FormConnecteClient()
        {
            InitializeComponent();
        }

      

      private  SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

      private DataTable dt;

      private DataTable dt_navigation;

      private int RowNumber = 0;


        // COMBOBOX MAGASIN
        private DataTable ListeMagasins()
        {
            
            SqlCommand cmd = new SqlCommand("SELECT numero_magasin,libelle_magasin FROM Magasin", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ListeMagasins");
            return ds.Tables["ListeMagasins"];
        
        }

        // COMBBOX CIN
        private DataTable ListeCin()
        {

            SqlCommand cmd = new SqlCommand("SELECT cin FROM Client", cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ListeCin");
            return ds.Tables["ListeCin"];

        }

        private void remplir_grid()
        {
            SqlCommand cmd = new SqlCommand("SELECT     C.cin, C.Genre, C.Nom, C.Prenom, C.Tel, C.Adresse, C.Ville, M.libelle_magasin AS magasin " +
                                            " FROM         Client AS C INNER JOIN magasin AS M ON C.numero_magasin = M.numero_magasin", cn);
            cn.Open();
            dt = new DataTable();
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            cn.Close();
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1[0, i].Value = dt.Rows[i].ItemArray[0].ToString();
                this.dataGridView1[1, i].Value = dt.Rows[i].ItemArray[1].ToString();

                if (dt.Rows[i].ItemArray[1].ToString() == "Homme")
                {
                    this.dataGridView1[1, i].Style.BackColor = Color.Red;
                }
                else
                {
                    this.dataGridView1[1, i].Style.BackColor = Color.Green;
                }

                this.dataGridView1[2, i].Value = dt.Rows[i].ItemArray[2].ToString();
                this.dataGridView1[3, i].Value = dt.Rows[i].ItemArray[3].ToString();
                this.dataGridView1[4, i].Value = dt.Rows[i].ItemArray[4].ToString();
                this.dataGridView1[5, i].Value = dt.Rows[i].ItemArray[5].ToString();
                this.dataGridView1[6, i].Value = dt.Rows[i].ItemArray[6].ToString();
                this.dataGridView1[7, i].Value = dt.Rows[i].ItemArray[7].ToString();


            }

        
        }


        //CHARGEMENT DES DONNEES DANS L'OBJET DATATABLE dt
        private DataTable charger()
        {

            SqlCommand cmd = new SqlCommand("SELECT     C.cin, C.Genre, C.Nom, C.Prenom, C.Tel, C.Adresse, C.Ville, M.libelle_magasin AS magasin " +
                                           " FROM         Client AS C INNER JOIN magasin AS M ON C.numero_magasin = M.numero_magasin", cn);
            cn.Open();
            dt_navigation = new DataTable();
            dt_navigation.Clear();
            dt_navigation.Load(cmd.ExecuteReader());
            cn.Close();
            return dt_navigation;
        
        }

        //AFFICHAGE DES LIGNES
        private void afficher(int index)
        {
            this.textBox1.Text = dt_navigation.Rows[index].ItemArray[0].ToString();
            if (dt_navigation.Rows[index].ItemArray[1].ToString() == "Homme")
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;
            }
            this.textBox2.Text = dt_navigation.Rows[index].ItemArray[2].ToString();
            this.textBox3.Text = dt_navigation.Rows[index].ItemArray[3].ToString();
            this.textBox4.Text = dt_navigation.Rows[index].ItemArray[4].ToString();
            this.textBox5.Text = dt_navigation.Rows[index].ItemArray[5].ToString();
            this.textBox6.Text = dt_navigation.Rows[index].ItemArray[6].ToString();
            this.comboBox1.Text = dt_navigation.Rows[index].ItemArray[7].ToString();


            // selectionner la ligne adéquate dans la grille de données :
            // desactiver la propriété multi select :
            this.dataGridView1.Rows[index].Selected = true;


        }


        private void FormDeconnecteClient_Load(object sender, EventArgs e)
        {
            // remplir liste des magasins :
            comboBox1.DataSource = ListeMagasins();
            comboBox1.DisplayMember = "libelle_magasin";
            comboBox1.ValueMember = "numero_magasin";
            comboBox1.Refresh();


            // remplir liste cin client :
            comboBoxCin.DataSource = ListeCin();
            comboBoxCin.DisplayMember = "cin";
            comboBoxCin.ValueMember = "cin";
            comboBoxCin.Refresh();



            /// chargement des données dans la grille de données :
            remplir_grid();

            //chargement des données :
            charger();

            if (dt_navigation.Rows.Count > 0)
            {
                afficher(RowNumber);
            }

            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // ajouter :



            SqlCommand cmd = new SqlCommand("INSERT INTO Client (cin, Genre, Nom, Prenom, Tel, Adresse, Ville, numero_magasin) " +
                                            " VALUES (@cin,@Genre,@Nom,@Prenom,@Tel,@Adresse,@Ville,@numero_magasin)", cn);
            cmd.Parameters.AddWithValue("@cin", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@Genre", this.radioButton1.Checked ? "Homme" : "Femme");
            cmd.Parameters.AddWithValue("@Nom", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@Prenom", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@Tel", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@Adresse", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@Ville", this.textBox6.Text);
            cmd.Parameters.AddWithValue("@numero_magasin", this.comboBox1.SelectedValue);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Bien ajouter");


            // actualiser dgv :
            /// chargement des données dans la grille de données :
            remplir_grid();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // modifier :


            SqlCommand cmd = new SqlCommand("UPDATE    Client SET Genre = @Genre, Nom = @Nom, Prenom = @Prenom, Tel = @Tel, Adresse = @Adresse, Ville = @Ville, numero_magasin = @numero_magasin " +
                                            " WHERE    (cin = @cin)", cn);
            cmd.Parameters.AddWithValue("@cin", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@Genre", this.radioButton1.Checked ? "Homme" : "Femme");
            cmd.Parameters.AddWithValue("@Nom", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@Prenom", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@Tel", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@Adresse", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@Ville", this.textBox6.Text);
            cmd.Parameters.AddWithValue("@numero_magasin", this.comboBox1.SelectedValue);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Bien Modifier");


            // actualiser dgv :
            /// chargement des données dans la grille de données :
            remplir_grid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // supprimer :

            DialogResult response = MessageBox.Show("Voulez vous vraiment supprimer cette ligne ?", "Suppression avec confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE (cin = @cin)", cn);
                cmd.Parameters.AddWithValue("@cin", this.textBox1.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Bien Supprimer");

                
                // actualiser dgv :
                /// chargement des données dans la grille de données :
                remplir_grid();
            }
            else
            {
                MessageBox.Show("Suppression annulé par l'utilisateur!");
            }

           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // rechercher :

            SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE (cin = @cin)", cn);
            cmd.Parameters.AddWithValue("@cin", this.textBox1.Text);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                this.textBox1.Text = dr[0].ToString();
                if (dr[1].ToString() == "Homme")
                {
                    this.radioButton1.Checked = true;
                }
                else
                {
                    this.radioButton2.Checked = true;
                }
                this.textBox2.Text = dr[2].ToString();
                this.textBox3.Text = dr[3].ToString();
                this.textBox4.Text = dr[4].ToString();
                this.textBox5.Text = dr[5].ToString();
                this.textBox6.Text = dr[6].ToString();
                this.comboBox1.SelectedValue = dr[7].ToString();


            }
            else
            {
                MessageBox.Show("cin " + this.textBox1.Text.ToString() + " est introuvable ! ");
            }

            cn.Close();

           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 
            int row = this.dataGridView1.CurrentRow.Index;
            int column = this.dataGridView1.CurrentCell.ColumnIndex;
            //MessageBox.Show(" row : " + row.ToString() + " - column : " + column.ToString());


            //editer :
            if (column == 8)
            {

                this.textBox1.Text = this.dataGridView1[0, row].Value.ToString();
                if(this.dataGridView1[0, row].Value.ToString() == "Homme")
                {
                    this.radioButton1.Checked = true;
                }
                else
                {
                    this.radioButton2.Checked = true;
                }
               
                this.textBox2.Text = this.dataGridView1[0, row].Value.ToString();
                this.textBox3.Text = this.dataGridView1[1, row].Value.ToString();
                this.textBox4.Text = this.dataGridView1[2, row].Value.ToString();
                this.textBox5.Text = this.dataGridView1[3, row].Value.ToString();
                this.textBox6.Text = this.dataGridView1[4, row].Value.ToString();
                this.comboBox1.Text = this.dataGridView1[5, row].Value.ToString();
                
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int supprimer = 0;
            // suppression multiple :

            bool erreur = false;

            cn.Open();

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(this.dataGridView1[9, i].Value) == true)
                {
                    // supprimer :

                    SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE (cin = @cin)", cn);
                    cmd.Parameters.AddWithValue("@cin", this.dataGridView1[0, i].Value.ToString());
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Le client " + this.dataGridView1[0, i].Value.ToString() + " ne peut pas etre supprimé car il a déja un ou plusieurs chéque");
                            erreur = true;
                            break;
                        }
                    }

                    supprimer += 1;
                    
                }
            }
            cn.Close();

            if (erreur == false)
            {
                MessageBox.Show("Bien Supprimer : " + supprimer.ToString() + " lignes");
            }



            /// chargement des données dans la grille de données :
            remplir_grid();
        }

        private void comboBoxCin_SelectedIndexChanged(object sender, EventArgs e)
        {
            // rechercher par combobox :


            //try
            //{


            //    SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE (cin = @cin)", cn);
            //    cmd.Parameters.AddWithValue("@cin", this.comboBoxCin.Text);
            //    cn.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    if (dr.HasRows)
            //    {
            //        dr.Read();
            //        this.textBox1.Text = dr[0].ToString();
            //        if (dr[1].ToString() == "Homme")
            //        {
            //            this.radioButton1.Checked = true;
            //        }
            //        else
            //        {
            //            this.radioButton2.Checked = true;
            //        }
            //        this.textBox2.Text = dr[2].ToString();
            //        this.textBox3.Text = dr[3].ToString();
            //        this.textBox4.Text = dr[4].ToString();
            //        this.textBox5.Text = dr[5].ToString();
            //        this.textBox6.Text = dr[6].ToString();
            //        this.comboBox1.SelectedValue = dr[7].ToString();


            //    }
               

            //    cn.Close();
            //}
            //catch { }

        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            //premier :
            RowNumber = 0;
            afficher(RowNumber);
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            //précédent :
            if (RowNumber == 0)
            {
                RowNumber = dt_navigation.Rows.Count - 1;
            }
            else
            {
                RowNumber -= 1;
            }
            afficher(RowNumber);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            //suivant :
            if (RowNumber == dt_navigation.Rows.Count - 1)
            {
                RowNumber = 0;
            }
            else
            {
                RowNumber += 1;
            }
            afficher(RowNumber);
        }

        private void button1Dernier_Click(object sender, EventArgs e)
        {
            //dernier :
            RowNumber = dt_navigation.Rows.Count - 1;
            afficher(RowNumber);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblNavigation.Text = (RowNumber + 1).ToString() + " / " + dt_navigation.Rows.Count.ToString();
        }

        }
    }

