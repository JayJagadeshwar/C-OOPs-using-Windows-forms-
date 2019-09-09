using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jay_7_OOPS_windows_forms
{
    class Category
    {
        int iCid;
        public int ICid { get => iCid; set => iCid = value; }


        



        public bool checkid()
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

        public string[] getCategories()
        {
            string[] NewObject = new string [3];
            if (ICid == 121)
            {
                NewObject[0] = "Rin";
                NewObject[1] = "Tide";
                NewObject[2] = "SurfExcel";
            }
            else if (ICid == 122)
            {
                NewObject[0] = "Crompton bulbs";
                NewObject[1] = "red bulbs";
                NewObject[2] = "blue bulbs";
            }
            return NewObject;




            
        }
    }
}
