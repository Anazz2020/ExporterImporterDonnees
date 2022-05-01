using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections;
namespace WindowsFormsApplication
{
   public class DB
    {
        SqlConnection cn;
        SqlCommand cmd;
        DataTable dt;


        public void initialize(string query_ps, CommandType cmdType)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            cmd = new SqlCommand(query_ps, cn);
            cmd.CommandType = cmdType;
        }

        public int ExecuteNonQuery()
        {
            int resultat = 0;
            try
            {
                resultat = cmd.ExecuteNonQuery();

                if (cn.State == ConnectionState.Open)
                    cn.Close();


                if (resultat > 0)
                    resultat = 1;

            }
            catch (SqlException ex)
            {
                resultat = ex.Number;
            }
            catch (Exception ex)
            {
                resultat = -1;
            }
            finally
            {
                if (resultat == 0)
                    resultat = -1;
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return resultat;
        }

        public int RunPsNonQuery(string nom_ps, SortedList SL)
        {
            initialize(nom_ps, CommandType.StoredProcedure);

            for (int i = 0; i < SL.Count; i++)
            {
                cmd.Parameters.AddWithValue(SL.GetKey(i).ToString(), SL.GetByIndex(i).ToString());
            }

            return ExecuteNonQuery();


        }

        public int RunQueryNonQuery(string query)
        {
            initialize(query, CommandType.Text);

            return ExecuteNonQuery();


        }

        public DataTable ExecuteRaeder()
        {
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            if (cn.State == ConnectionState.Open)
                cn.Close();
            return dt;
        }

        public DataTable RunPsReader(string nom_ps, SortedList SL)
        {
            initialize(nom_ps, CommandType.StoredProcedure);

            for (int i = 0; i < SL.Count; i++)
            {
                cmd.Parameters.AddWithValue(SL.GetKey(i).ToString(), SL.GetByIndex(i).ToString());
            }

            return ExecuteRaeder();


        }

        public DataTable RunQueryReader(string query)
        {
            initialize(query, CommandType.Text);

            return ExecuteRaeder();


        }

       
    }
}
