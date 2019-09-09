using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Jay_7_OOPS_windows_forms
{
    class MotorVehicle
    {
        static string strVehicleModel;

        public static string StrVehicleModel { get => strVehicleModel; set => strVehicleModel = value; }
    }

    class MotorPriceDescription : MotorVehicle
    {
         
        public bool checkVehicleModel(out string strModelReturn)
        {
            strModelReturn = "";
            bool bResult = false;
            if (StrVehicleModel == "Pulser")
            {
                strModelReturn = "Bajaj Company";
                bResult = true;
            }
            else if (StrVehicleModel == "Bajaj CT100")
            {
                strModelReturn = "Bajaj Company";
                bResult = true;
            }
            else if (StrVehicleModel == "Hero Pleasure")
            {
                strModelReturn = "Hero Motors";
                bResult = true;
            }
            else if (StrVehicleModel == "Duet")
            {
                strModelReturn = "Hero Motors";
                bResult = true;
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        public string BajajMotors()
        {
            string strValue = string.Empty;
            if (StrVehicleModel == "Pulser")
            {
                strValue = "75600" + ":" + "0.70" + ":" + "0.05";
            }
            else if (StrVehicleModel == "Bajaj CT100")
            {
                strValue = "52600" + ":" + "0.70" + ":" + "0.05";
            }
            return strValue;
        }


        public string HeroMotors()
        {
            string strValue = string.Empty;
            if (StrVehicleModel == "Hero Pleasure")
            {
                strValue = "75600" + ":" + "0.70" + ":" + "0.05";
            }
            else if (StrVehicleModel == "Duet")
            {
                strValue = "52600" + ":" + "0.70" + ":" + "0.05";
            }
            return strValue;
        }


    }
}
