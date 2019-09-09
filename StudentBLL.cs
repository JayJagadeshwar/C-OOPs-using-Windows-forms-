using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Jay_7_OOPS_windows_forms
{
    class StudentBLL
    {
        DAL dObj = new DAL();

        #region DelcareSection

        SqlCommand cmd;
        DataTable dt;
        int iCount;
        string strAction, strSname, strResult, strGrade;
        int iId, iMaths, iScience, iSocial;
        float fTotal, fAverage;

        public string StrAction { get => strAction; set => strAction = value; }
        public string StrSname { get => strSname; set => strSname = value; }
        public string StrResult { get => strResult; set => strResult = value; }
        public string StrGrade { get => strGrade; set => strGrade = value; }
        public int IId { get => iId; set => iId = value; }
        public int IMaths { get => iMaths; set => iMaths = value; }
        public int IScience { get => iScience; set => iScience = value; }
        public int ISocial { get => iSocial; set => iSocial = value; }
        public float FTotal { get => fTotal; set => fTotal = value; }
        public float FAverage { get => fAverage; set => fAverage = value; }
        #endregion

        #region DefineSection

        public int DMLStudentOpentions()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "ssp_Student";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", StrAction);
            cmd.Parameters.AddWithValue("@Id", IId);
            cmd.Parameters.AddWithValue("@Sname", StrSname);
            cmd.Parameters.AddWithValue("@Maths", IMaths);
            cmd.Parameters.AddWithValue("@Science", IScience);
            cmd.Parameters.AddWithValue("@Social", ISocial);
            cmd.Parameters.AddWithValue("@Total", FTotal);
            cmd.Parameters.AddWithValue("@Average", FAverage);
            cmd.Parameters.AddWithValue("@Result", StrResult);
            cmd.Parameters.AddWithValue("@Grade", StrGrade);
            iCount = dObj.ExecuteDML(cmd);
            return iCount;
        }

        public DataTable GetTable()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "ssp_Student";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", StrAction);
            cmd.Parameters.AddWithValue("@Id", IId);
            dt = dObj.ExecuteDataTable(cmd);
            return dt;
        }

        #endregion
    }
}
