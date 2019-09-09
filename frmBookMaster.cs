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
    public partial class frmBookMaster : Form
    {
        public frmBookMaster()
        {
            InitializeComponent();
        }

        string strValue;
        //Creating the instance of SqlConnnection
        SqlConnection con = new SqlConnection(ConnectionString.GetConnect());
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        int iRecordCount;

        //Creating the incerement id function
        int IDIncrement()
        {
            int iRecord = 0;
            string strQuery = "select max(Bid) from tbl_BookMaster";
            con.Open();
            cmd = new SqlCommand(strQuery, con);
            object objRecord = cmd.ExecuteScalar();
            con.Close();
            if (DBNull.Value == objRecord)
            {
                iRecord = 1;
            }
            else
            {
                iRecord = Convert.ToInt16(objRecord) + 1;
            }
            return iRecord;
        }//method close

        void Bookdisplay()
        {
            string strQuery = "select * from tbl_BookMaster";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgBookMaster.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("There is no datae");
            }
        }//Method Clsoe


        private void CmdSave_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsertQuery = "insert into tbl_BookMaster values(" + txtBookId.Text + ",'" + txtBookName.Text + "','" + txtBookDesc.Text.Trim() + "')";
                con.Open();
                cmd = new SqlCommand(strInsertQuery, con);
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    int iRecordIncr = IDIncrement();
                    txtBookId.Text = iRecordIncr.ToString();
                    MessageBox.Show("Record is inserted");
                    Bookdisplay();
                    txtBookName.Text = txtBookDesc.Text = "";

                    txtBookName.Focus();
                    btnAddNew.Focus();
                }
                else
                {
                    MessageBox.Show("Record is not inserted");
                }
                cmdSave.Visible = false;

            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message);
            }

        }
    }
}
