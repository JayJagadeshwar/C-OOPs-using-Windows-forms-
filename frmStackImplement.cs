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
    public partial class frmStackImplement : Form
    {
        public frmStackImplement()
        {
            InitializeComponent();
        }

        Stack _stObj = new Stack();
        string[] strSplitValues; 

        private void Button1_Click(object sender, EventArgs e)
        {
            strSplitValues = Regex.Split(textBox1.Text, "\r\n");
            for (int i = 0; i < strSplitValues.Length; i++)
            {
                _stObj.Push(strSplitValues[i]);
            }
            foreach (var item in _stObj)
            {
                textBox2.Text += "\r" + "\n" + item;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _stObj.Pop();
            foreach (var item in _stObj)
            {
                textBox3.Text += "\r" + "\n" + item;
            }
        }
    }
}
