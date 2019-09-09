using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jay_7_OOPS_windows_forms
{
    public partial class ThreeTierImplement : Form
    {
        public ThreeTierImplement()
        {
            InitializeComponent();
        }

        int iMaths, iScience, iSocial;
        float fTotal, fAverage;
        DataTable dt;
        int iRecordCount;



       

        StudentBLL sObj = new StudentBLL();

        void StudentDisplay()
        {
            sObj.StrAction = "SelectTotal";
            dt = sObj.GetTable();
            if (dt.Rows.Count > 0)
            {
                dgStudent.DataSource = dt;
            }
            else
            {
                MessageBox.Show("There is no data");
            }

        }


        private void CmdSave_Click_Click(object sender, EventArgs e)
        {
            try
            {
                sObj.StrAction = "Insert";
                sObj.IId = Convert.ToInt32(txtStudentId.Text.Trim());
                sObj.StrSname = txtStudentName.Text.Trim();
                sObj.IMaths = Convert.ToInt32(txtMaths.Text.Trim());
                sObj.IScience = Convert.ToInt32(txtScience.Text.Trim());
                sObj.ISocial = Convert.ToInt32(txtSocial.Text.Trim());
                sObj.FAverage = fAverage;
                sObj.FTotal = fTotal;
                sObj.StrResult = txtResult.Text.Trim();
                sObj.StrGrade = txtGrade.Text.Trim();

                iRecordCount = sObj.DMLStudentOpentions();
                if (iRecordCount > 0)
                {
                    StudentDisplay();
                    MessageBox.Show("Record is inserted");
                    txtStudentId.Text = txtStudentName.Text = txtMaths.Text = txtScience.Text = txtSocial.Text = txtTotal.Text = txtAverage.Text = txtResult.Text = txtGrade.Text = "";
                    txtStudentId.Focus();
                }
                else
                {
                    MessageBox.Show("Record is not inserted");
                }
            }
            catch (SqlException sq)
            {

                MessageBox.Show(sq.Message);
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            sObj.StrAction = "SelectSingle";
            sObj.IId = Convert.ToInt32(txtStudentId.Text.Trim());
            dt = sObj.GetTable();
            if (dt.Rows.Count > 0)
            {
                txtStudentName.Text = dt.Rows[0]["Sname"].ToString();
                txtMaths.Text = dt.Rows[0]["Maths"].ToString();
                txtScience.Text = dt.Rows[0]["Science"].ToString();
                txtSocial.Text = dt.Rows[0]["Social"].ToString();
                txtTotal.Text = dt.Rows[0]["Total"].ToString();
                txtAverage.Text = dt.Rows[0]["Average"].ToString();
                txtResult.Text = dt.Rows[0]["Result"].ToString();
                txtGrade.Text = dt.Rows[0]["Grade"].ToString();
            }
            else
            {
                MessageBox.Show("Sorry! that id is not existing");
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sObj.StrAction = "Delete";
                sObj.IId = Convert.ToInt32(txtStudentId.Text.Trim());
                iRecordCount = sObj.DMLStudentOpentions();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is deleted");
                    StudentDisplay();
                }
                else
                {
                    MessageBox.Show("Record is not deleted");
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }

        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sObj.StrAction = "Update";
                sObj.IId = Convert.ToInt16(txtStudentId.Text.Trim());
                sObj.StrSname = txtStudentName.Text.Trim();
                sObj.IMaths = Convert.ToInt16(txtMaths.Text.Trim());
                sObj.IScience = Convert.ToInt16(txtScience.Text.Trim());
                sObj.ISocial = Convert.ToInt16(txtSocial.Text.Trim());
                sObj.FTotal = fTotal;
                sObj.FAverage = fAverage;
                sObj.StrResult = txtResult.Text;
                sObj.StrGrade = txtGrade.Text;
                iRecordCount = sObj.DMLStudentOpentions();
                if (iRecordCount > 0)
                {
                    StudentDisplay();
                    MessageBox.Show("Record is updated");
                }
                else
                {
                    MessageBox.Show("Record is not Updated");
                }

            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }

        }

        private void TxtSocial_Leave(object sender, EventArgs e)
        {
            iMaths = Convert.ToInt16(txtMaths.Text.Trim());
            iScience = Convert.ToInt16(txtScience.Text.Trim());
            iSocial = Convert.ToInt16(txtSocial.Text.Trim());
            if (iMaths >= 40 && iScience >= 40 && iSocial >= 40)
            {
                fTotal = iMaths + iScience + iSocial;
                fAverage = fTotal / 3;
                txtTotal.Text = fTotal.ToString();
                txtAverage.Text = fAverage.ToString();
                txtResult.Text = "Passed";
                if (fAverage >= 70)
                    txtGrade.Text = "Merit";
                else if (fAverage >= 60 && fAverage < 70)
                    txtGrade.Text = "FirstClass";
                else if (fAverage >= 50 && fAverage < 60)
                    txtGrade.Text = "SecondClass";
                else
                    txtGrade.Text = "ThirdClass";
            }
            else
            {
                txtResult.Text = "Failed";
            }

        }

       

        private void ThreeTierImplement_Load(object sender, EventArgs e)
        {
            StudentDisplay();
        }


       
    }
}
