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
    public partial class frmListEmployeeCompany : Form
    {
        public frmListEmployeeCompany()
        {
            InitializeComponent();
        }


        string[] strEid, strComId, strEmpName, strComName;


        private void Button1_Click(object sender, EventArgs e)
        {
            strEid = Regex.Split(textBox1.Text.Trim(), "\r\n"); 
            strEmpName = Regex.Split(textBox2.Text.Trim(), "\r\n");
            strComId = Regex.Split(textBox3.Text.Trim(), "\r\n");
            strComName = Regex.Split(textBox4.Text.Trim(), "\r\n");

            if (strEid.Length == strEmpName.Length && strEid.Length == strComId.Length && strEid.Length == strComName.Length)
            {

                List<EmployeeDetails> lEmp = new List<EmployeeDetails>();
                List<CompanyDetails> lCmp = new List<CompanyDetails>();

                for (int i = 0; i < strEid.Length; i++)
                {
                    lEmp.Add(new EmployeeDetails(Convert.ToInt32(strEid[i]), strComId[i], strEmpName[i]));
                    lCmp.Add(new CompanyDetails(strComId[i], strComName[i]));
                }
                
                for (int i = 0; i < lEmp.Count; i++)
                {
                    if (lEmp[i].StrCompanyId == lCmp[i].StrCompanyId)
                    {
                        textBox5.Text += "\r" + "\n" + "Employee Id: " + lEmp[i].IEid + "Employee Name: " + lEmp[i].StrEmployeeName + "Company id: " + lEmp[i].StrCompanyId + "Company name: " + lCmp[i].StrCompanyName;
                    }
                }
            }

            else
            {
                MessageBox.Show("Please enter employee id, emp name, com id, com name");
            }
        }
    }
}
