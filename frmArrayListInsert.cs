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
    public partial class frmArrayListInsert : Form
    {
        public frmArrayListInsert()
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

        int iINoValue;
        object iInPosition;

        private void Button2_Click(object sender, EventArgs e)
        {
            iINoValue = Convert.ToInt32(textBox4.Text.Trim());
            iInPosition = (object)textBox5.Text.Trim();
            _arObj.Insert(iINoValue, iInPosition);
            foreach (var item in _arObj)
            {
                textBox3.Text += "\r" + "\n" + item;
            }
        }
    }
}
