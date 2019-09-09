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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Select Category");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Select Category");
            comboBox1.Items.Add("Select Category");

        }
    }
}
