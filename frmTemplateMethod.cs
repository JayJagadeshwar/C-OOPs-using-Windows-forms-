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
    public partial class frmTemplateMethod : Form
    {
        public frmTemplateMethod()
        {
            InitializeComponent();
        }
        
        void Swap<T>(ref T x, ref T y)
        {
            T z;
            z = x;
            x = y;
            y = z;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB;
            float fA, fB;
            iA = Convert.ToInt32(textBox1.Text.Trim());
            iB = Convert.ToInt32(textBox2.Text.Trim());
            fA = Convert.ToSingle(textBox3.Text.Trim());
            fB = Convert.ToSingle(textBox4.Text.Trim());

            Swap<int>(ref iA, ref iB);
            Swap<float>(ref fA, ref fB);

            textBox5.Text = iA.ToString();
            textBox6.Text = iB.ToString();
            textBox7.Text = fA.ToString();
            textBox8.Text = fB.ToString();

        }
    }
}
