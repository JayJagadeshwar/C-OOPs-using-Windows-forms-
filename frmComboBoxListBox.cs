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
    public partial class frmComboBoxListBox : Form
    {
        public frmComboBoxListBox()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox2.Text))
            {
                listBox1.Items.Remove(textBox2.Text);
            }
            else
            {
                MessageBox.Show("Please enter the name properly with out any spelling mistake..");
                textBox2.Clear();
            }
            textBox2.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            int IndexValue = Convert.ToInt32(textBox3.Text);
            if (listBox1.TopIndex != IndexValue)
            {
                MessageBox.Show("Please enter the index value properly");
                textBox3.Clear();
                textBox3.Focus();
            }
            else
            {
                listBox1.Items.RemoveAt(Convert.ToInt32(textBox3.Text));
                textBox2.Clear();
            }
        }
    }
}
