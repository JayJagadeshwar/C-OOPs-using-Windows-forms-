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
    public partial class frmSingleCastDelegateImplement : Form
    {
        public frmSingleCastDelegateImplement()
        {
            InitializeComponent();
        }

        delegate string Use(string strUse);
        delegate void Used();

        private void Button1_Click(object sender, EventArgs e)
        {
            SingleCast_Delegate sObj = new SingleCast_Delegate();
            Use obj = new Use(sObj.Display);
            Used obj1 = new Used(SingleCast_Delegate.show);
            MessageBox.Show(obj("Jay Jagadeshwar"));
            obj1.Invoke();
        }
    }
}
