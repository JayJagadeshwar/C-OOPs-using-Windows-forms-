using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    partial class Operation
    {
        public int Mul(int a, int b)
        {
            if (a != 0 || b != 0)
            {
                return a * b;
            }
            else
            {
                return 0;
            }
        }
            
    }
}
