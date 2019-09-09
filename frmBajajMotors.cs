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
    public partial class frmBajajMotors : Form
    {
        public frmBajajMotors()
        {
            InitializeComponent();
        }

        private void FrmBajajMotors_Load(object sender, EventArgs e)
        {
            MotorPriceDescription mObj = new MotorPriceDescription();
            MotorPriceDescription.StrVehicleModel = frmVehicleVerify.strMotorVehicle;
            string strResult = mObj.BajajMotors();
            string[] strSplit = strResult.Split(':');
            textBox1.Text = strSplit[0];
            textBox2.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) * Convert.ToSingle(strSplit[1]));
            textBox3.Text = Convert.ToString(Convert.ToSingle(textBox1.Text) * Convert.ToSingle(strSplit[2]));
            textBox4.Text = (Convert.ToString(Convert.ToSingle(textBox1.Text) + Convert.ToSingle(textBox2.Text) + Convert.ToSingle(textBox3.Text)));
        }
    }
}
