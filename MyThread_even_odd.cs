using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    class MyThread_even_odd
    {
        public static int iNO;
        public void Even_odd()
        {
            for (int i = 0; i < iNO; i++)
            {
                if (i % 2 == 0)
                {
                    MessageBox.Show("Even is" + i);
                }
                else
                {
                    MessageBox.Show("Odd is" + i);
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < iNO; i++)
            {
                MessageBox.Show("value is " + i);
            }
        }


    }
}
