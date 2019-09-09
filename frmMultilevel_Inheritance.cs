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
    public partial class frmMultilevel_Inheritance : Form
    {
        public frmMultilevel_Inheritance()
        {
            InitializeComponent();
        }

        FeesDetails fObj = new FeesDetails();
        private void Button1_Click(object sender, EventArgs e)
        {
            string strValue;
            bool bResult = fObj.checkBook(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),textBox3.Text,textBox4.Text, out strValue);
            if (bResult == true)
            {
                panel1.Visible = true;
            }
            else
            {
                if (strValue != "")
                {
                    MessageBox.Show(strValue);
                }
                else
                {
                    MessageBox.Show("Particular book selected is not available");
                }
            }

        }

        private void TextBox6_Leave(object sender, EventArgs e)
        { 
            textBox5.Text = Convert.ToString(fObj.Totalcalc(Convert.ToSingle(textBox7.Text.Trim()), Convert.ToSingle(textBox6.Text.Trim())));
        }
    }
}
  