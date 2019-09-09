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
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

     

        private void FrmBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(EmailCheck.strUrl));
        }
    }
}
