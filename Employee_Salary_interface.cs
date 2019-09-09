using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{

    interface Employee
    {
         bool CheckEmployee(int iEmpId);
        float salaryCalculation(int iMonthDays, int iPresent, float fBasic);
    }


    class Employee_Salary_interface : Employee
    {
        public bool CheckEmployee(int iEmpId)
        {
            bool bResult = false;
            if (iEmpId == 121)
            {
                bResult = true;
            }
            else if (iEmpId == 122)
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public float salaryCalculation(int iMonthDays, int iPresent, float fBasic)
        {
            float fActualSalary = fBasic / iMonthDays;
            float fSalaryTaken = iPresent * fActualSalary;
            return fSalaryTaken;
            
        }
    }
}
