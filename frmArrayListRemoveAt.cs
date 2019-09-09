using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Jay_7_OOPS_windows_forms
{
    public partial class frmArrayListRemoveAt : Form
    {
        public frmArrayListRemoveAt()
        {
            InitializeComponent();
        }

        ArrayList _arObj = new ArrayList();
        string[] strSplitValues;
        

        private void Button1_Click(object sender, EventArgs e)
        {
            strSplitValues = Regex.Split(textBox1.Text, "\r\n");
            for (int i = 0; i < strSplitValues.Length; i++)
            {
                _arObj.Add(strSplitValues[i]);
            }
            foreach (var item in _arObj)
            {
                textBox2.Text += "\r" + "\n" + item;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int iRemoveAt;
            iRemoveAt = Convert.ToInt32(textBox4.Text.Trim());
            if (_arObj.Count > iRemoveAt)
            {
                _arObj.RemoveAt(iRemoveAt);
                foreach (var item in _arObj)
                {
                    textBox3.Text += "\r" + "\n" + item;
                }
            }
            else
            {
                MessageBox.Show("Please enter the Correct Index Value");
                textBox4.Clear();
                textBox4.Focus();
            }
        }
    }
}
