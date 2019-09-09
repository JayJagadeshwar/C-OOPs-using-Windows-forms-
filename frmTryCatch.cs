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
    public partial class frmTryCatch : Form
    {
        public frmTryCatch()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int iA, iB, iC;
                iA = Convert.ToInt32(textBox1.Text.Trim());
                iB = Convert.ToInt32(textBox2.Text.Trim());
                iC = iA / iB;
                textBox3.Text = iC.ToString();
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message);
            }
           /* catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            finally
            {
                MessageBox.Show("Division Error");
            }
        }
    }
}
