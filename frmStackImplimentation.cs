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
    public partial class frmStackImplimentation : Form
    {
        public frmStackImplimentation()
        {
            InitializeComponent();
        }

        private void FrmStackImplimentation_Load(object sender, EventArgs e)
        {

        }

        //Creating tje stack object instance
        Stack _stObj = new Stack();

        //Queue _qObj = new Queue();


        //Declaring the variable
        string[] strSplit;

        private void Button1_Click(object sender, EventArgs e)
        {
           // _qObj.Enqueue();
            //_qObj.Dequeue();

            strSplit = Regex.Split(textBox1.Text.Trim(), "\r\n");
            for (int i = 0; i < strSplit.Length; i++)
            {
                _stObj.Push(strSplit[i]);
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
