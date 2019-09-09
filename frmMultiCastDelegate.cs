using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    public partial class frmMultiCastDelegate : Form
    {
        public frmMultiCastDelegate()
        {
            InitializeComponent();
        }

       
        delegate int Operation(int a, int b);

        private void Button1_Click(object sender, EventArgs e)
        {
            MultiCastDelegateImplement mObj = new MultiCastDelegateImplement();
            int a, b;
            a = Convert.ToInt32(textBox1.Text.Trim());
            b = Convert.ToInt32(textBox2.Text.Trim());

            Operation oObj1 = new Operation(mObj.Sum);
            Operation oObj2 = new Operation(MultiCastDelegateImplement.Mul);

            textBox3.Text = oObj1(a, b).ToString();
            textBox4.Text = oObj2(a, b).ToString();
            
        }
    }
}
