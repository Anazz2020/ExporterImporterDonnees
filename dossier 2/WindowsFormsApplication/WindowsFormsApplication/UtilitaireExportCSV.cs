using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WindowsFormsApplication
{
  public static  class  UtilitaireExportCSV
    {
      
        
        public static DataTable createDataTable()
        {
            DataTable table = new DataTable();
            //columns  
            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("NAME", typeof(string));
            //table.Columns.Add("CITY", typeof(string));

            //data  
            //table.Rows.Add(111, "Devesh", "Ghaziabad");
            //table.Rows.Add(222, "ROLI", "KANPUR");
            //table.Rows.Add(102, "ROLI", "MAINPURI");
            //table.Rows.Add(212, "DEVESH", "KANPUR");
            //table.Rows.Add(102, "NIKHIL", "GZB");
            //table.Rows.Add(212, "HIMANSHU", "NOIDa");
            //table.Rows.Add(102, "AVINASH", "NOIDa");
            //table.Rows.Add(212, "BHUPPI", "GZB");

            DataSet ds = new DataSet();

            table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Client", Program.cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds,"ClientCsv");

            table = ds.Tables["ClientCsv"];

            return table;
        }

        public static void ExportToCSV(this DataTable dtDataTable, string strFilePath)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }  


    }
}
