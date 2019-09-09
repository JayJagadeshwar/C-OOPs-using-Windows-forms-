using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class OperatorOverLoad
    {
        int iX, iY;

        public OperatorOverLoad(int a, int b)
        {
            iX = a;
            iY = b;
        }
        public static OperatorOverLoad operator ++(OperatorOverLoad obj)
        {
            obj.iX++;
            return obj;
        }
        public static OperatorOverLoad operator --(OperatorOverLoad obj)
        {
            obj.iY--;
            return obj;
        }
        public void Display(out int iR, out int iR1)
        {
            iR = 0;
            iR1 = 0;
            iR = iX;
            iR1 = iY;
        }
    }
}
