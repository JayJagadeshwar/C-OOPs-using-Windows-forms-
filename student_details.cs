using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class student_details
    {
        protected int iStudent;
    }

    class Bookdetails : student_details
    {
        protected string strBookTaken, strBookReturn;
    }

    class FeesDetails : Bookdetails
    {
        int iFees;

        public bool checkBook(int iSid, int iFees1, string strBookT, string strBookR, out string strReturn)
        {
            strReturn = string.Empty;
            bool bResult = false;
            iStudent = iSid;
            strBookTaken = strBookT;
            strBookReturn = strBookR;
            iFees = iFees1;
            if (iFees == 0)
            {
                if (string.Compare(strBookTaken, strBookReturn) == 0)
                {
                    bResult = true;
                }
                else
                {
                    bResult = false;
                }
            }
            else
            {
                strReturn = "Due to fees balance you cant take the book";
            }
            return bResult;

        }

        public float Totalcalc(float fNod, float fRent)
        {
            return fNod * fRent;
        }
    }
}
