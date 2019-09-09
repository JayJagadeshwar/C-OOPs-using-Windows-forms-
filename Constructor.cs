using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class Constructor
    {
        int iX, iY;

        public Constructor()
        {
            frmConstructor.iC = frmConstructor.iA + frmConstructor.iB;
        }

        public Constructor(int a, int b, out int iR)
        {
            iR = 0;
            iX = a;
            iY = b;
            iR = a - b; 
        }

        public Constructor(Constructor obj, out int iR1)
        {
            iR1 = 0;
            iR1 = obj.iX * obj.iY;
        }
    }
}
