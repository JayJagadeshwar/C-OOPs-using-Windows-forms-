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
    public partial class DynamicPolyomrphism_Ex : Form
    {
        public DynamicPolyomrphism_Ex()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ParentClass cObj = new ParentClass();
            cObj.Display();
            cObj = new childClass();
            cObj.Display();
        }
    }
}
