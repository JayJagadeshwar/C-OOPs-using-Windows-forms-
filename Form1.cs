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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB;
            float fA, fB;
            iA = Convert.ToInt32(textBox1.Text.Trim());
            iB = Convert.ToInt32(textBox2.Text.Trim());
            fA = Convert.ToSingle(textBox3.Text.Trim());
            fB = Convert.ToSingle(textBox4.Text.Trim());

            //Creating the instance of the class
            OverLoad ovObj = new OverLoad();

            textBox5.Text = ovObj.Calc(iA, iB).ToString();
            textBox6.Text = ovObj.Calc(fA, fB).ToString();

            ovObj.Calc(ref iA, ref iB);
            textBox7.Text = iA.ToString();
            textBox8.Text = iB.ToString();
        }
    }
}
