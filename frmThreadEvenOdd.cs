using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Jay_7_OOPS_windows_forms
{
    public partial class frmThreadEvenOdd : Form
    {
        public frmThreadEvenOdd()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyThread_even_odd.iNO = Convert.ToInt32(textBox1.Text.Trim());
            MyThread_even_odd mobj = new MyThread_even_odd();
            Thread thObj1 = new Thread(new ThreadStart(mobj.Even_odd));
            Thread thObj2 = new Thread(new ThreadStart(mobj.Display));
            thObj1.Start();
            thObj2.Start();

        }
    }
}
