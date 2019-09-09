using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jay_7_OOPS_windows_forms
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }


        string[] StrSplitNames;

        private void Button1_Click(object sender, EventArgs e)
        {
            StrSplitNames = Regex.Split(textBox1.Text, "\r\n");
            List<string> lObj = new List<string>();
            for (int i = 0; i < StrSplitNames.Length; i++)
            {
                lObj.Add(StrSplitNames[i]);
            }
            foreach (var item in lObj)
            {
                textBox2.Text += "\r" + "\n" + item;
            }


        }
    }
}
