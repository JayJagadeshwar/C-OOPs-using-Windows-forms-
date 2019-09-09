using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class HotelVerify_MultipleInheritance
    {
        public bool checkHotel(string strHotelName)
        {
            bool bResult = false;
            if (strHotelName == "Benson Taj")
            {
                bResult = true;
            }
            else if (strHotelName == "Kamat Hotel")
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }
    }

    interface HotelMenu
    {
        bool checkItem(string strItemName);
        string[] GetMenuItems(string strItemName);

    }

    class MultipleClass : HotelVerify_MultipleInheritance , HotelMenu
    {
        public bool checkItem(string strItemName)
        {
            bool bResult = false;
            if (strItemName == "Tiffin")
            {
                bResult = true;
            }
            else if (strItemName == "Meals")
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public string[] GetMenuItems(string strItemName)
        {
            string[] strItems = new string[4];
            if (strItemName == "Tiffin")
            {
                strItems[0] = "Select Item";
                strItems[1] = "Idly";
                strItems[2] = "Vada";
                strItems[3] = "Dosa";
            }
            else if (strItemName == "Meals")
            {
                strItems[0] = "Select Item";
                strItems[1] = "Fried Rice";
                strItems[2] = "Plain Rice";
                strItems[3] = "Curd Rice";
            }
            return strItems;
        }

       
    }

}
