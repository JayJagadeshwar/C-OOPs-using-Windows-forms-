using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    class OverLoad
    {
        public int Calc(int a, int b)
        {
            return a + b;
        }

        public float Calc(float fA, float fB)
        {
            return fA - fB;
        }

        public void Calc(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
        
    }
}
