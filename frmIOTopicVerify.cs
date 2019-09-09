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
    public partial class frmIOTopicVerify : Form
    {
        public frmIOTopicVerify()
        {
            InitializeComponent();
        }

        public static string strTopic;
        private void Button1_Click(object sender, EventArgs e)
        {
            DetailsBook dObj = new Jay_7_OOPS_windows_forms.DetailsBook();
            DetailsBook.StrTopic = textBox1.Text.Trim();

            bool bResult = dObj.Checktopic();
            if (bResult == true)
            {
                strTopic = textBox1.Text.Trim();
                frmBookDetailsIO frObj = new frmBookDetailsIO();
                frObj.Show();
                //this.HIde();
            }

            else
            {
                MessageBox.Show("Please! enter the topic again not correct");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
    }
}
