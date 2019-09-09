using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay_7_OOPS_windows_forms
{
    abstract class CategoryDetails
    {
        public bool checkCategory(string strCategory)
        {
            bool bResult = false;
            if (strCategory == "Consumer")
            {
                bResult = true;
            }
            else if (strCategory == "Electronics")
            {
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public abstract float TotalCalculation(float fQun, float fPrice);
    }

    class ConsumerProducts : CategoryDetails
    {
        public override float TotalCalculation(float fQun, float fPrice)
        {
            return fQun * fPrice;
        }
    }

    class ElectronicProducts : CategoryDetails
    {
        public override float TotalCalculation(float fQun, float fPrice)
        {
            return fQun * fPrice;
        }
    }
}
