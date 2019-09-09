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
    public partial class frm_Employee_Salary_check_interface : Form
    {
        public frm_Employee_Salary_check_interface()
        {
            InitializeComponent();
        }

        public static int iPresent;
        int iMonthDays;
        Employee_Salary_interface eObj = new Employee_Salary_interface();





        private int GetDays(int iMonth, int iYear)
        {
            int iNdays = 0;
            if (iMonth == 1)
            {
                iNdays = 31;
            }
            else if (iMonth == 2)
            {
                if (iYear % 4 == 0)
                {
                    iNdays = 29;
                }
                else
                {
                    iNdays = 28;
                }
            }
            else if (iMonth == 3)
            {
                iNdays = 31;
            }
            else if (iMonth == 4)
            {
                iNdays = 30;
            }
            else if (iMonth == 5)
            {
                iNdays = 31;
            }
            else if (iMonth == 6)
            {
                iNdays = 30;
            }
            else if (iMonth == 7)
            {
                iNdays = 31;
            }
            else if (iMonth == 8)
            {
                iNdays = 31;
            }
            else if (iMonth == 9)
            {
                iNdays = 30;
            }
            else if (iMonth == 10)
            {
                iNdays = 31;
            }
            else if (iMonth == 11)
            {
                iNdays = 30;
            }
            else if (iMonth == 12)
            {
                iNdays = 31;
            }
            else
            {
                iNdays = 0;
            }
            return iNdays;
        }


        private void Frm_Employee_Salary_check_interface_Load(object sender, EventArgs e)
        {
            textBox1.Text = frmInterface_EmployeeSalary.iEmpid.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            iMonthDays = GetDays(DateTime.Now.Month, DateTime.Now.Year);
            string strResult = textBox3.Text = dateTimePicker1.Value.Date.ToShortDateString();
            string[] strSplit = strResult.Split('/');
            iPresent = Convert.ToInt32(strSplit[1]);
            textBox4.Text = eObj.salaryCalculation(iMonthDays, iPresent, Convert.ToSingle(textBox2.Text)).ToString();
            textBox5.Text = "You have made it man jay";
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }
    }
}
