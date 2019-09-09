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
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(ConnectionString.GetConnect());
        SqlCommand cmd;
        int iRecordCount;


        void FillBooks()
        {
            string strSelectQuery = "select distinct Bid, Bname from tbl_BookMaster";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                comBookDetails.DisplayMember = "Bname";
                comBookDetails.ValueMember = "Bid";
                comBookDetails.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("There is no data");
            }
        }

        void BookDetailsDisplay()
        {
            string strSelectQuery = "select bm.Bid, bm.Bname, bm.BookDescription, bd.NoofBooks, bd.Price, bd.Total from tbl_BookMaster bm, tbl_BookDetails bd where bm.Bid = bd.Bid";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgBookDetails.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("There is no data");
            }
        }



        private void FrmBookDetails_Load(object sender, EventArgs e)
        {
            FillBooks();
            BookDetailsDisplay();
        }

        private void CmdSave_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsertQuery = " insert into tbl_BookDetails values( " + comBookDetails.SelectedValue + " , " + Convert.ToInt32(txtNoofBooks.Text) + ", " + Convert.ToInt32(txtBookPrice.Text) + " , " + Convert.ToInt32(txtTotal.Text) + " )";
                cmd = new SqlCommand(strInsertQuery, con);
                con.Open();
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is inserted");
                    BookDetailsDisplay();
                    comBookDetails.SelectedValue = 0;
                    txtBookPrice.Text = txtNoofBooks.Text = txtTotal.Text = "" ;
                    comBookDetails.Focus();
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

        private void CmdSearch_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string strSelectQuery = "select * from tbl_BookDetails where Bid = " + comBookDetails.SelectedValue + "";
                SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtNoofBooks.Text = dt.Rows[0]["NoofBooks"].ToString();
                    txtBookPrice.Text = dt.Rows[0]["Price"].ToString();
                    txtTotal.Text = dt.Rows[0]["Total"].ToString();
                }
                else
                {
                    MessageBox.Show("There is no records with that id");
                }
            }
            catch (SqlException sq)
            {

                MessageBox.Show(sq.Message);
            }
        }

        private void CmdDelete_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string strDeleteQuery = "delete from tbl_BookMaster where Bid = " + Convert.ToInt32(comBookDetails.SelectedValue) + " ; " + "delete from tbl_BookDetails where Bid = " + Convert.ToInt32(comBookDetails.SelectedValue) + " ";
                cmd = new SqlCommand(strDeleteQuery, con);
                con.Open();
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    BookDetailsDisplay();
                    FillBooks();
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

        private void CmdUpdate_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string strUpdateQuery = "update tbl_BookDetails set NoofBooks=" + Convert.ToInt32(txtNoofBooks.Text.Trim()) + ",Price=" + Convert.ToDecimal(txtBookPrice.Text) + ",Total=" + Convert.ToDecimal(txtTotal.Text) + " where Bid=" + Convert.ToInt32(comBookDetails.SelectedValue) + "";
                con.Open();
                cmd = new SqlCommand(strUpdateQuery, con);
                iRecordCount = cmd.ExecuteNonQuery();
                con.Close();
                if (iRecordCount > 0)
                {
                    MessageBox.Show("Record is updated");
                    BookDetailsDisplay();
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

        private void TxtBookPrice_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = Convert.ToString(Convert.ToInt32(txtNoofBooks.Text) * Convert.ToDecimal(txtBookPrice.Text));
        }

        private void CmdBookMaster_Click_Click(object sender, EventArgs e)
        {
            frmBookMaster fObj = new frmBookMaster();
            fObj.Show();
            this.Hide();
        }
    }
}
