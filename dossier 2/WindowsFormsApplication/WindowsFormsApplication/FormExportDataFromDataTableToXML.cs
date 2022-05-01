using System;
using System.IO;
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
    public partial class FormExportDataFromDataTableToXML : Form
    {
        public FormExportDataFromDataTableToXML()
        {
            InitializeComponent();
        }
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
         DataTable dt; 

        private void button1_Click(object sender, EventArgs e)
        {

            //Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                

                if (saveFileDialog1.FileName != null)
                {
                    //StreamWriter wText = new StreamWriter(myStream);

                    //wText.Write(" your text");

                    //myStream.Close();
                    DataSet ds = new DataSet();

                    dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Cheque", cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);


                    ds.Tables.Add(dt);

                    ds.Tables[0].TableName = "Cheque";
                    //MessageBox.Show(saveFileDialog1.FileName);
                    ds.WriteXml(saveFileDialog1.FileName);
                    MessageBox.Show("Fichier crée avec succées");

                }
            }         

            
         
        }

       

       
        }
    }

