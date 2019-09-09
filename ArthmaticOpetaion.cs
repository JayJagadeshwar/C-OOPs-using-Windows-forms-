using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    class ArthmaticOpetaion
    {
        public int Add(TextBox t1, TextBox t2)
        {
            int iC = 0;
            if (Convert.ToInt16(t1.Text) != 0 && Convert.ToInt16(t2.Text) != 0)
            {
                iC = Convert.ToInt32(t1.Text) + Convert.ToInt32(t2.Text);
            }
            else
            {
                MessageBox.Show("Please enter proper values");
                if (Convert.ToInt32(t1.Text) == 0)
                {
                    t1.Focus();
                }
                else
                {
                    t2.Focus();
                }
            }
            return iC;
        }

        public int Sub(TextBox t1, TextBox t2)
        {
            int iD = 0;
            if (Convert.ToInt32(t1.Text) != 0 && Convert.ToInt32(t2.Text) != 0)
            {
                iD = Convert.ToInt16(t1.Text) - Convert.ToInt16(t2.Text);
            }
            else
            {
                MessageBox.Show("Please Enter the proper Values");
                if (Convert.ToInt32(t1.Text) == 0)
                {
                    t1.Focus();
                }
                else
                {
                    t2.Focus();
                }
            }
            return iD;
        }

    }
}
