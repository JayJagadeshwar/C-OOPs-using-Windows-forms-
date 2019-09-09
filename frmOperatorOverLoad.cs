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
    public partial class frmOperatorOverLoad : Form
    {
        public frmOperatorOverLoad()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB;
            iA = Convert.ToInt16(textBox1.Text.Trim());
            iB = Convert.ToInt16(textBox2.Text.Trim());
            OperatorOverLoad opObj = new OperatorOverLoad(iA, iB);
            ++opObj;
            --opObj;
            int iR, iR1;
            opObj.Display(out iR, out iR1);
            textBox3.Text = iR.ToString();
            textBox4.Text = iR1.ToString();
        }
    }
}
