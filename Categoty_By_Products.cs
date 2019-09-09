using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    class Categoty_By_Products
    {
        int iCid;

        public int ICid
        {
            get => iCid;
            set => iCid = value;
        }

        public bool CheckIdNumber()
        {
            bool bResult = false;
            if (ICid == 121)
            {
                bResult = true;
            }
            else if (ICid == 122)
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }


        public string[] checkCategory()
        {
            string[] NewObject = new string[3];
            if (ICid == 121)
            {
                NewObject[0] = "Rin";
                NewObject[1] = "Surf Excel";
                NewObject[2] = "Xtra";

            }
            else if (ICid == 122)
            {
                NewObject[0] = "Bulb";
                NewObject[1] = "Red Bulb";
                NewObject[2] = "Blue Blub";
            }
            return NewObject;
        }
    }
}
