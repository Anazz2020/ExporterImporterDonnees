using System;
using System.IO; // Importer System.IO pour travailler avec les fichiers streamWriter ou StreamReader
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
    public partial class FormExporterDataToHtml : Form
    {
        public FormExporterDataToHtml()
        {
            InitializeComponent();
        }

        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

        DataTable dt;




        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Banque", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"banque");
            dt = ds.Tables["banque"];





            StreamWriter sw = new StreamWriter("./Banque2020.html");
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<table border=" + "1" + ">");
            sw.WriteLine("<tr>");
            sw.WriteLine("<td>");
            sw.WriteLine("Code banque");
            sw.WriteLine("</td>");
            sw.WriteLine("<td>");
            sw.WriteLine("Adresse siege");
            sw.WriteLine("</td>");
            sw.WriteLine("<td>");
            sw.WriteLine("Tel");
            sw.WriteLine("</td>");
            sw.WriteLine("<td>");
            sw.WriteLine("Ville");
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sw.WriteLine("<tr>");
                sw.WriteLine("<td>");
                sw.WriteLine(dt.Rows[i][0].ToString());
                sw.WriteLine("</td>");
                sw.WriteLine("<td>");
                sw.WriteLine(dt.Rows[i][1].ToString());
                sw.WriteLine("</td>");
                sw.WriteLine("<td>");
                sw.WriteLine(dt.Rows[i][2].ToString());
                sw.WriteLine("</td>");
                sw.WriteLine("<td>");
                sw.WriteLine(dt.Rows[i][3].ToString());
                sw.WriteLine("</td>");
                sw.WriteLine("</tr>");

            }
            sw.WriteLine("</table>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();

            MessageBox.Show("Fichier html bien crée");
        }
    }
}
