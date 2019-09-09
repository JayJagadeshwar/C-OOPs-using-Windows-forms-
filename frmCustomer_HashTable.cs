using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;


namespace Jay_7_OOPS_windows_forms
{
    public partial class frmCustomer_HashTable : Form
    {
        public frmCustomer_HashTable()
        {
            InitializeComponent();
        }


        CustomerCheck cObj = new CustomerCheck();
        string[] strProductItems;
        string[] strProductQun, strProductPrice;
        int iCount, iQun, iPrice;

        private void FrmCustomer_HashTable_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Select Customer");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Detergent");
            comboBox1.Items.Add("Confectionary");
            textBox3.Text = frmHashTableImplement.strCustomerName;
        }



       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                if (comboBox1.SelectedItem.ToString() == "Food")
                {
                    strProductItems = cObj.GetConsumerItems(comboBox1.SelectedItem.ToString());
                    foreach (var item in strProductItems)
                    {
                        checkedListBox1.Items.Add(item);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Detergent")
                {
                    strProductItems = cObj.GetConsumerItems(comboBox1.SelectedItem.ToString());
                    foreach (var item in strProductItems)
                    {
                        checkedListBox1.Items.Add(item);
                    }
                }
                else
                {
                    strProductItems = cObj.GetConsumerItems(comboBox1.SelectedItem.ToString());
                    foreach (var item in strProductItems)
                    {
                        checkedListBox1.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the category item correctly");
                comboBox1.Focus();
            }
        }




        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
              
            }


        }



    }
}
