using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jay_7_OOPS_windows_forms
{
    class SingleCast_Delegate
    {
        public string Display(string strValue)
        {
            return "Hello " + strValue;
        }
        public static void show()
        {
            MessageBox.Show("Single cast delegate implemented");
        }
    }
}
