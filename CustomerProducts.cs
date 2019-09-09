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
    public partial class CustomerProducts : Form
    {
        public CustomerProducts()
        {
            InitializeComponent();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerProducts_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToSingle(textBox2.Text) * Convert.ToSingle(textBox3.Text));
        }

        Category cObj = new Category();
        private void Button1_Click(object sender, EventArgs e)
        {
            cObj.ICid = Convert.ToInt32(textBox1.Text);
            bool bResult = cObj.checkid();
            if (bResult == true)
            {
                string[] strProduct = cObj.getCategories();
                foreach (var item in strProduct)
                {
                    comboBox1.Items.Add(item);
                }
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("particular category id is not existing");
            }
        }
    }
}
