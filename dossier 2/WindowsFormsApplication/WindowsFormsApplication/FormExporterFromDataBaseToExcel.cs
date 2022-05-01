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
using Excel = Microsoft.Office.Interop.Excel;  // ajouter une référence : Microsoft.Office.Interop.Excel

namespace WindowsFormsApplication
{
    public partial class FormExporterFromDataBaseToExcel : Form
    {
        public FormExporterFromDataBaseToExcel()
        {
            InitializeComponent();
        }

        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            string data = null;
           

            Excel.Application xlApp; // utilisation d'une application Excel
            Excel.Workbook xlWorkBook; // utilisation
            Excel.Worksheet xlWorkSheet; // classeur 
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Client", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            // boucle sur les lignes
            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                // boucle sur les colonnes
                for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs(Application.StartupPath + "\\Clients2020.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Le fichier est crée avec succés. Pour le consulter voir le chemin : " + Application.StartupPath);
      
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath.ToString());
        }
    }
}
