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
    public partial class frmVehicleVerify : Form
    {
        public frmVehicleVerify()
        {
            InitializeComponent();
        }


        public static string strMotorVehicle;
        private void Button1_Click(object sender, EventArgs e)
        {
            MotorPriceDescription mObj = new MotorPriceDescription();
            MotorPriceDescription.StrVehicleModel = textBox1.Text;
            strMotorVehicle = textBox1.Text.Trim();


            string strValue;
            bool bResult = mObj.checkVehicleModel(out strValue);
            if (bResult == true)
            {
                if (strValue == "Bajaj Company")
                {
                    frmBajajMotors fObj = new frmBajajMotors();
                    fObj.Show();
                }
                else if (strValue == "Hero Motors")
                {
                    frmHeroMotors fObj1 = new frmHeroMotors();
                    fObj1.Show();
                }
            }
            else
            {
                MessageBox.Show("Particular model of vehicle is not existing in Hero Moto corp or Bajaj. Please re- enter properly again");
                textBox1.Clear();
                textBox1.Focus();
            }
               


        }
    }
}
