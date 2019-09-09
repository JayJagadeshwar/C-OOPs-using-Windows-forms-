using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class MyTemplate<T>
    {
        public MyTemplate(T X, T Y, out int iR)
        {
            iR = 0;
            string strValue = X.GetType().ToString();
            if (strValue == "System.Int32")
            {
                iR = Convert.ToInt32(X) + Convert.ToInt32(Y);
            }
        }
    }
}
