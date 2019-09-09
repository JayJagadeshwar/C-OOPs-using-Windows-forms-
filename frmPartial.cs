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
    public partial class frmPartial : Form
    {
        public frmPartial()
        {
            InitializeComponent();
        }


        int a, b;
        Operation obj = new Operation();
        Operation1 Obj1 = new Operation1();


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            a = Convert.ToInt32(textBox1.Text.Trim());
            b = Convert.ToInt32(textBox2.Text.Trim());
            int iC = obj.Mul(a, b);
            if (iC != 0)
            {
                textBox3.Text = "product is " + iC.ToString();
            }
            else
            {
                MessageBox.Show("Please enter the proper values again");
                textBox1.Focus();
                textBox2.Focus();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text.Trim());
            b = Convert.ToInt32(textBox2.Text.Trim());
            int iD = Obj1.Div(a, b);
            if (iD != 0)
            {
                textBox3.Text = "quotient is " + iD.ToString();
            }
            else
            {
                MessageBox.Show("Please enter the proper values again");
                textBox1.Focus();
                textBox2.Focus();
            }
            checkBox1.Checked = false;
        }
    }
}
