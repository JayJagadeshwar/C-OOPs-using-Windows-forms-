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
    public partial class ProductsByCategory : Form
    {
        public ProductsByCategory()
        {
            InitializeComponent();
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToSingle(textBox2.Text) * Convert.ToSingle(textBox3.Text));
            textBox4.Focus();
        }


        Categoty_By_Products cObj = new Categoty_By_Products();
        private void Button1_Click(object sender, EventArgs e)
        {
            cObj.ICid = Convert.ToInt32(textBox1.Text);
            bool bResult = cObj.CheckIdNumber();
            if (bResult == true)
            {
                string[] strProducts = cObj.checkCategory();
                foreach (var item in strProducts)
                {
                    comboBox1.Items.Add(item);
                }
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter the Proper id number");
                textBox1.Text = "";
            }
        }
    }
}
