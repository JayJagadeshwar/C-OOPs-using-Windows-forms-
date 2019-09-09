using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Jay_7_OOPS_windows_forms
{
    class CheckTopic
    {
        static string strTopic;

        public static string StrTopic { get => strTopic; set => strTopic = value; }
    }

    class DetailsBook : CheckTopic
    {
        public bool Checktopic()
        {
            bool bResult = false;
            if (StrTopic.ToLower() == "software")
            {
                bResult = true;
            }
            else if (StrTopic.ToLower() == "subjects")
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public string[] GetBooks()
        {
            string[] strBooks = new string[4];
            if (StrTopic.ToLower() == "software")
            {
                strBooks[0] = "selectBook";
                strBooks[1] = "C";
                strBooks[2] = "Java";
                strBooks[3] = "Csharp";
            }
            else if (StrTopic.ToLower() == "subjects")
            {
                strBooks[0] = "selectBook";
                strBooks[1] = "Maths";
                strBooks[2] = "Science";
                strBooks[3] = "Social";
            }
            return strBooks;  
        }

        public void AcceptDetails(string strTopic, string strBookName, int iNofBooks, float fPrice, float fTotal)
        {
            FileStream fsObj = new FileStream(@"C:\Jay\books.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fsObj);
            swObj.WriteLine("Topic:{0} \n BookName:{1} \n NumberofBooks{2} \n Price is:{3} \n Total is: {4}", strTopic, strBookName, iNofBooks, fPrice, fTotal);
            swObj.Close();
            fsObj.Close();
        }

        public string GetBookDetails()
        {
            string content = string.Empty;
            FileStream fs = new FileStream(@"C:\Jay\books.txt", FileMode.Open, FileAccess.Read);

            using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            return content;
        }
    }
}

