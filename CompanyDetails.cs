using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class CompanyDetails
    {
        string strCompanyId;
        string strCompanyName;

        public string StrCompanyId { get => strCompanyId; set => strCompanyId = value; }
        public string StrCompanyName { get => strCompanyName; set => strCompanyName = value; }


        public CompanyDetails(string strComId, string strComName)
        {
            this.StrCompanyId = strComId;
            this.StrCompanyName = strComName;
        }
    }
}
