using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Jay_7_OOPS_windows_forms
{
    public partial class frmInsertDeleteUpdate_Ado : Form
    {
        public frmInsertDeleteUpdate_Ado()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConnectionString.GetConnect());
        SqlCommand cmd;
        DataSet ds;
        int iRecordCount;


        void Display()
        {
            try
            {
                string strQuery = "select * from tbl_studentDetails";
                SqlDataAdapter da = new SqlDataAdapter(strQuery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgStudent.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("There is no record");
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }

        }


        private void FrmInsertDeleteUpdate_Ado_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "insert into tbl_studentDetails values( " + txtStudentId.Text +" , '"+ txtStudentName.Text +"' , "+ txtStudentAge.Text +")";
                cmd = new SqlCommand(strInsert, con);
                con.Open();
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is Inserted");
                    txtStudentAge.Text = txtStudentId.Text = txtStudentName.Text = "" ;
                    txtStudentId.Focus();
                    Display();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strSearch = "select * from tbl_studentDetails where sid1 = " + txtStudentId.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(strSearch, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtStudentName.Text = Convert.ToString(dt.Rows[0]["sname"]);
                    txtStudentAge.Text = dt.Rows[0]["Age"].ToString();
                }
                else
                {
                    MessageBox.Show("There is no record with that Id");
                }
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strDelete = "delete from tbl_studentDetails where sid1 = " + txtStudentId.Text + " ";
                cmd = new SqlCommand(strDelete, con);
                con.Open();
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is deleted");
                    Display();
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

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string strUpdate = "update tbl_studentDetails set sname = '"+ txtStudentName.Text +"', Age = "+ txtStudentAge.Text +" where sid1='"+ txtStudentId.Text +"'";
                cmd = new SqlCommand(strUpdate, con);
                con.Open();
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is updated");
                    Display();
                }
                else
                {
                    MessageBox.Show("Record is not updated");
                }

            }
            catch (SqlException sq)
            {

                MessageBox.Show(sq.Message);
            }
            
        }
    }
}
