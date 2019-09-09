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
    public partial class frmBookDetailsIO : Form
    {
        public frmBookDetailsIO()
        {
            InitializeComponent();
        }

        

        DetailsBook dObj = new DetailsBook();
        string[] strBooks;

        public void DisplayAllRecords()
        {
            textBox5.Text += dObj.GetBookDetails();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > 0)
            {
                dObj.AcceptDetails(textBox1.Text, comboBox1.SelectedItem.ToString(), Convert.ToInt32(textBox2.Text), Convert.ToSingle(textBox3.Text), Convert.ToSingle(textBox4.Text));
                MessageBox.Show("Record is inserted in file");
                textBox2.Text = textBox3.Text = textBox4.Text = "";
                comboBox1.SelectedItem = 0;
                DisplayAllRecords();
            }
            else
            {
                MessageBox.Show("Please! enter the book item");
                comboBox1.Focus();
            }

        }

        private void FrmBookDetailsIO_Load(object sender, EventArgs e)
        {
            if (frmIOTopicVerify.strTopic.ToLower() == "software")
            {
                textBox1.Text = frmIOTopicVerify.strTopic;
                DetailsBook.StrTopic = textBox1.Text;
                strBooks = dObj.GetBooks();
                foreach (var item in strBooks)
                {
                    comboBox1.Items.Add(item);
                }
            }
            else if (frmIOTopicVerify.strTopic.ToLower() == "subjects")
            {
                textBox1.Text = frmIOTopicVerify.strTopic;
                DetailsBook.StrTopic = textBox1.Text;
                strBooks = dObj.GetBooks();
                foreach (var item in strBooks)
                {
                    comboBox1.Items.Add(item);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmIOTopicVerify fObj = new frmIOTopicVerify();
            fObj.Show();
            //this.Hide();
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt16(textBox2.Text) * Convert.ToSingle(textBox3.Text));
        }
    }
}
