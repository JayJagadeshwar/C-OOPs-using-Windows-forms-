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
    public partial class frmQueueImplement : Form
    {
        public frmQueueImplement()
        {
            InitializeComponent();
        }

        

        Queue _qObj = new Queue();
        string[] strSplit;

        private void Button1_Click(object sender, EventArgs e)
        {
            strSplit = Regex.Split(textBox1.Text.Trim() , "\r\n");
            for (int i = 0; i < strSplit.Length; i++)
            {
                _qObj.Enqueue(strSplit[i]);
            }
            foreach (var item in _qObj)
            {
                textBox2.Text += "\r" + "\n" + item;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            _qObj.Dequeue();
            foreach (var item in _qObj)
            {
                textBox3.Text += "\r" + "\n" + item;
            }
        }

    }
}
