using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class EmployeeDetails
    {
        int iEid;
        string strCompanyId;
        string strEmployeeName;
        
        public int IEid { get => iEid; set => iEid = value; } 
        public string StrCompanyId { get => strCompanyId; set => strCompanyId = value; }
        public string StrEmployeeName { get => strEmployeeName; set => strEmployeeName = value; }

        public EmployeeDetails(int eid, string strComId, string strEmpname)
        {
            this.IEid = eid;
            this.StrCompanyId = strComId;
            this.StrEmployeeName = strEmpname;
        }

    }
}
