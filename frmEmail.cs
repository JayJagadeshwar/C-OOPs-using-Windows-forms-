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
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailCheck eObj = new EmailCheck();
            eObj.CheckEmail(textBox1.Text);
            frmBrowser fObj = new frmBrowser();
            fObj.Show();
        }
    }
}
