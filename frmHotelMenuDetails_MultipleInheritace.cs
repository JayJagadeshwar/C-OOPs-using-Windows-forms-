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
    public partial class frmHotelMenuDetails_MultipleInheritace : Form
    {
        public frmHotelMenuDetails_MultipleInheritace()
        {
            InitializeComponent();
        }


        string[] strItemDisplay;
        HotelMenu hObj = new MultipleClass();
     

        private void Button1_Click(object sender, EventArgs e)
        {
            bool bResult = hObj.checkItem(textBox2.Text.Trim());
            if (bResult == true)
            {
                strItemDisplay = hObj.GetMenuItems(textBox2.Text.Trim());
                foreach (var item in strItemDisplay)
                {
                    comboBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct Item Name ");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void FrmHotelMenuDetails_MultipleInheritace_Load(object sender, EventArgs e)
        {
            textBox1.Text = frmHotelMember_MultipleInheritance.strHotel;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                if (comboBox1.SelectedItem.ToString() == "Idly")
                {
                    textBox4.Text = "25";
                }
                else if (comboBox1.SelectedItem.ToString() == "Vada")
                {
                    textBox4.Text = "35";
                }
                else if (comboBox1.SelectedItem.ToString() == "Dosa")
                {
                    textBox4.Text = "30";
                }
                else if (comboBox1.SelectedItem.ToString() == "Fried Rice")
                {
                    textBox4.Text = "40";
                }
                else if (comboBox1.SelectedItem.ToString() == "Plain Rice")
                {
                    textBox4.Text = "35";
                }
                else if (comboBox1.SelectedItem.ToString() == "Curd Rice")
                {
                    textBox4.Text = "40";
                }
                textBox3.Focus();
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox4.Text));
        }
    }
}
