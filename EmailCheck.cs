using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class EmailCheck
    {
        string[] strSplit;
        public static string strUrl;
        public void CheckEmail(string strEmail)
        {
            if (strEmail.Contains("@"))
            {
                strSplit = strEmail.Split('@');

                switch (strSplit[1])
                {
                    case "gmail.com":
                        strUrl = "http://www.gmail.com";
                        break;

                    case "hotmail.com":
                        strUrl = "http://www.hotmail.com";
                        break;

                    case "rediffmailcom":
                        strUrl = "http://www.rediffmail.com";
                        break;

                    case "yahoo.com":
                        strUrl = "http://www.yahoo.com";
                        break;
                }

            }

        }
    }
}
