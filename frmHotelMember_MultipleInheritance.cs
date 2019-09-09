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
    public partial class frmHotelMember_MultipleInheritance : Form
    {
        public frmHotelMember_MultipleInheritance()
        {
            InitializeComponent();
        }


        MultipleClass mObj = new MultipleClass();
        public static string strHotel;


        private void Button1_Click(object sender, EventArgs e)
        {
            bool bResult = mObj.checkHotel(textBox1.Text.Trim());
            if (bResult == true)
            {
                strHotel = textBox1.Text;
                frmHotelMenuDetails_MultipleInheritace fObj = new frmHotelMenuDetails_MultipleInheritace();
                fObj.Show();
            }
            else
            {
                MessageBox.Show("Please enter the currect Hotel Name");
                textBox1.Clear();
                textBox1.Focus();
            }

        }
    }
}
