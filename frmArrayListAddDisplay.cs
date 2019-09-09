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
    public partial class frmArrayListAddDisplay : Form
    {
        public frmArrayListAddDisplay()
        {
            InitializeComponent();
        }

        ArrayList _arObj = new ArrayList();
        string[] strValues;

        private void Button1_Click(object sender, EventArgs e)
        {
            strValues = Regex.Split(textBox1.Text, "\r\n");

            for (int i = 0; i < strValues.Length; i++)
            {
                _arObj.Add(strValues[i]);
            }
            foreach (var item in _arObj)
            {
                textBox2.Text += "\r" + "\n" + item;
            }
        }
    }
}
