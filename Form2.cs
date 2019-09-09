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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ArthmaticOpetaion AOp = new ArthmaticOpetaion();
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(AOp.Add(textBox1, textBox2));
            radioButton1.Checked = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(AOp.Sub(textBox1, textBox2));
            radioButton1.Checked = false;
        }
    }
}
