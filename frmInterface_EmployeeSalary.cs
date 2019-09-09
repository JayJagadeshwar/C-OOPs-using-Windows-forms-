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
    public partial class frmInterface_EmployeeSalary : Form
    {
        public frmInterface_EmployeeSalary()
        {
            InitializeComponent();
        }


        public static int iEmpid;
        Employee_Salary_interface eObj = new Employee_Salary_interface();

        private void Button1_Click(object sender, EventArgs e)
        {
            bool bResult = eObj.CheckEmployee(Convert.ToInt32(textBox1.Text.Trim()));
            if (bResult == true)
            {
                iEmpid = Convert.ToInt32(textBox1.Text.Trim());
                frm_Employee_Salary_check_interface fObj = new frm_Employee_Salary_check_interface();
                fObj.Show();
            }
            else
            {
                MessageBox.Show("Particular Employee iD you have entered is not existed...");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
