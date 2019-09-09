using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Jay_7_OOPS_windows_forms
{
    class DAL
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-REEH9UJ; Database = adoExamples_batch972; Integrated Security = true");


        public int ExecuteDML(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd.Connection = con;
            con.Open();
            int iRecord = cmd.ExecuteNonQuery();
            con.Close();
            return iRecord;
        }


        public object ExecuteSingle(SqlCommand cmd)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            cmd.Connection = con;
            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataSet ExecuteDataSet(SqlCommand cmd)
        {
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public DataTable ExecuteDataTable(SqlCommand cmd)
        {
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
