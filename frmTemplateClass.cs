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
    public partial class frmTemplateClass : Form
    {
        public frmTemplateClass()
        {
            InitializeComponent();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB;
            iA = Convert.ToInt32(textBox1.Text.Trim());
            iB = Convert.ToInt32(textBox2.Text.Trim());
            int iR;
            MyTemplate<int> myObj = new MyTemplate<int>(iA, iB, out iR);
            textBox3.Text = iR.ToString();
        }
    }
}
