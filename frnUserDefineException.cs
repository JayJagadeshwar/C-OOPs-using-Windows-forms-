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
    public partial class frnUserDefineException : Form
    {
        public frnUserDefineException()
        {
            InitializeComponent();
        }

        class MyException : Exception
        {
            public string GetError()
            {
                return "Divider cant be zero ";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int iA, iB, iC;
            iA = int.Parse(textBox1.Text);
            iB = int.Parse(textBox2.Text);
            try
            {
                if (iB != 0)
                {

                    iC = iA / iB;
                    textBox3.Text = iC.ToString();
                }
                else
                {
                    throw new MyException();
                }

            }
            catch (MyException my)
            {
                MessageBox.Show(my.GetError());
            }
            finally
            {
                MessageBox.Show("This is the finally exception throwed");
            }
        }
    }
}
