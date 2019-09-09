using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Jay_7_OOPS_windows_forms
{
    class ConnectionString
    {
        public static string GetConnect()
        {
            string strConnection = "Data Source = DESKTOP-REEH9UJ; Database = adoExamples_batch972; Integrated Security = true";
            return strConnection;
        }
    }
}
