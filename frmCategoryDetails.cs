using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jay_7_OOPS_windows_forms
{
    public partial class frmCategoryDetails : Form
    {
        public frmCategoryDetails()
        {
            InitializeComponent();
        }

        ConsumerProducts cObj = new ConsumerProducts();
        ElectronicProducts eObj = new ElectronicProducts();
        string[] strPname, strQun, strPrice;
        int iPn, iQu, iPr;

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            strPname = Regex.Split(textBox2.Text.Trim() , "\r\n");
            strQun = Regex.Split(textBox3.Text.Trim(), "\r\n");
            strPrice = Regex.Split(textBox4.Text.Trim(), "\r\n");
            iPn = strPname.Length;
            iQu = strQun.Length;
            iPr = strPrice.Length;

            if (iPn == iQu && iQu == iPr && iPr == iPn)
            {
                for (int i = 0; i < strPname.Length; i++)
                {
                    if (textBox5.Text == "Consumer")
                    {
                        textBox6.Text += "\r" + "\n" + "Product is: " + strPname[i] + "Quantity is: " + strQun[i] + "Price is:" + strPrice[i] + "total is:" + cObj.TotalCalculation(Convert.ToSingle(strQun[i]), Convert.ToSingle(strPrice[i]));
                    }
                    else if (textBox5.Text == "Electronics")
                    {
                        textBox6.Text += "\r" + "\n" + "Product is: " + strPname[i] + "Quantity is: " + strQun[i] + "Price is:" + strPrice[i] + "total is:" + eObj.TotalCalculation(Convert.ToSingle(strQun[i]), Convert.ToSingle(strPrice[i]));
                    }
                }
            }
            else
            {
                MessageBox.Show("please enter the all the product price and quantities");
                textBox2.Text = textBox3.Text = textBox4.Text = "";

            }

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            bool bConsumer, bElectronics;
            bConsumer = cObj.checkCategory(textBox1.Text.Trim());
            bElectronics = eObj.checkCategory(textBox2.Text.Trim());
            if (bConsumer == true || bElectronics == true)
            {
                if (bConsumer == true)
                {
                    panel1.Visible = true;
                    textBox5.Text = textBox1.Text;
                }
                else if (bElectronics == true)
                {
                    panel1.Visible = true;
                    textBox5.Text = textBox1.Text;
                }
            }
            else
            {
                MessageBox.Show("Particular product is not availabel");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

    }
}
