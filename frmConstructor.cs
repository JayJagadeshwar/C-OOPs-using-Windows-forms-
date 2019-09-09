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
    public partial class frmConstructor : Form
    {
        public frmConstructor()
        {
            InitializeComponent();
        }

        public static int iA, iB, iC;
        private void Button1_Click(object sender, EventArgs e)
        {
            iA = Convert.ToInt32(textBox1.Text.Trim());
            iB = Convert.ToInt32(textBox2.Text.Trim());

            Constructor obj = new Constructor();
            textBox3.Text = iC.ToString();

            int iR;
            Constructor obj1 = new Constructor(iA, iB, out iR);
            textBox4.Text = iR.ToString();

            int iR1=0;
            Constructor obj2 = new Constructor(obj1,out iR1);
            textBox5.Text = iR1.ToString();
        }
    }
}
