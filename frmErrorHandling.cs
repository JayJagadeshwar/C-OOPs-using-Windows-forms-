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
    public partial class frmErrorHandling : Form
    {
        public frmErrorHandling()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB;
            iA = Convert.ToInt32(textBox1.Text.Trim());
            iB = Convert.ToInt32(textBox2.Text.Trim());
            if (iB != iA)
            {
                textBox3.Text = Convert.ToString(iA / iB);
            }
            else
            {
                errorProvider1.SetError(textBox2, " ");
            }
        }
    }
}
