using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Jay_7_OOPS_windows_forms
{
    class CustomerCheck
    {
        public bool checkCusomer(Hashtable htObj, string strCustId)
        {
            bool bResult = false;
            if (htObj.Contains(strCustId))
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public string[] GetConsumerItems(string strCategoryItem)
        {
            string[] strArray = new string[3];
            if (strCategoryItem == "Food")
            {
                strArray[0] = "Rice";
                strArray[1] = "Dall";
                strArray[2] = "Wheet";
            }
            else if (strCategoryItem == "Detergent")
            {
                strArray[0] = "Rin";
                strArray[1] = "SurfExcel";
                strArray[2] = "Vim";
            }
            else if (strCategoryItem == "Confectionary")
            {
                strArray[0] = "FiveStar";
                strArray[1] = "DairyMilk";
                strArray[2] = "Munch";
            }
            return strArray;
        }


    }
}
