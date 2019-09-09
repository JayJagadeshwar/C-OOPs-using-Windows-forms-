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
    public partial class frmHashTableImplement : Form
    {
        public frmHashTableImplement()
        {
            InitializeComponent();
        }

        Hashtable htObj = new Hashtable();
        string[] strCustId, strCustName;
        public static string strCustomerName;
        CustomerCheck cObj = new CustomerCheck();

        private void Button1_Click(object sender, EventArgs e)
        {
            strCustId = Regex.Split(textBox1.Text, "\r\n");
            strCustName = Regex.Split(textBox2.Text, "\r\n");
            if (strCustId.Length == strCustName.Length)
            {
                for (int i = 0; i < strCustId.Length; i++)
                {
                    htObj.Add(strCustId[i], strCustName[i]);
                    MessageBox.Show("Customer name id inserted in hash table");
                }
            }
            else
            {
                MessageBox.Show("Please enter the customer id and customer name in correct index");
                textBox1.Text = textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool bResult = cObj.checkCusomer(htObj, textBox3.Text);
            if (bResult == true)
            {
                strCustomerName = htObj[textBox3.Text.Trim()].ToString();
                frmCustomer_HashTable fObj = new frmCustomer_HashTable();
                fObj.Show();
            }
            else
            {
                MessageBox.Show("Please enter the customer ID curretly");
                textBox3.Clear();

                textBox3.Focus();
            }

        }
    }
}
