using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace bookStore
{
    public partial class frmBook : Form
    {
        int pBkID = 0;
        string entryMode = "";
        string PreviousBOOKID = "";
         DataTable dt_list = new DataTable();
        public frmBook()
        {
            InitializeComponent();
        }
        // private const string  ConnectionString = clsGeneral.getConnectionString();
        private static readonly string ConnectionString = clsGeneral.getConnectionString();

        SqlConnection con = new SqlConnection(ConnectionString);
        private void frmBook_Load(object sender, EventArgs e)
        {
            con.Open();
            getListData();
          //  setGrid();
        }

        private void getListData()
        {
            //if (dgvList.Rows.Count > 0) { dgvList.Rows.Clear(); }
            dt_list.Clear();
            SqlCommand cmd = new SqlCommand("exec sp_getBookList", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt_list);
            dgvList.DataSource = dt_list;
            setGrid();
        }
        private void setGrid()
        {
            dgvList.Columns["book_ID"].HeaderText = "Book ID";
            dgvList.Columns["book_ID"].Width = 50;

            dgvList.Columns["book_Name"].HeaderText = "Book Name";
            dgvList.Columns["book_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns["book_Author"].HeaderText = "Book Author";
            dgvList.Columns["book_Author"].Width = 120;

            dgvList.Columns["book_Description"].HeaderText = "Book Description";
            dgvList.Columns["book_Description"].Width = 150;

            dgvList.Columns["edition"].HeaderText = "Edition";
            dgvList.Columns["edition"].Width = 50; 
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clsGeneral.ClearAllInputs(groupBox1);
            pBkID = 0;
            tabControl1.SelectedIndex = 1;
            entryMode = "New";
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            this.Text = "BOOK (NEW)";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            getEdit(dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim());
            tabControl1.SelectedIndex = 1;
            tbBookID.Focus();
            entryMode = "Edit";
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getEdit(dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim());
            tabControl1.SelectedIndex = 1;
        }
        private void tbBookID_Validated(object sender, EventArgs e)
        {
            if ((tbBookID.Text != null) && (PreviousBOOKID != tbBookID.Text))
            {
                PreviousBOOKID = tbBookID.Text;
                getEdit(tbBookID.Text.Trim());
                tbBookID.Text = PreviousBOOKID;
            }
        }
        private void getEdit(string BookID)
        {
            SqlCommand cmd = new SqlCommand("exec sp_getBookEdit '" + BookID + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt_Edit = new DataTable();
            sda.Fill(dt_Edit);
            if (dt_Edit.Rows.Count != 0)
            {
                this.Text = "BOOK (EDIT)";
                entryMode = "Edit";
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;

                pBkID = int.Parse(dt_Edit.Rows[0]["BK_ID"].ToString());
                tbBookID.Text = dt_Edit.Rows[0]["book_ID"].ToString().Trim();
                tbBookName.Text = dt_Edit.Rows[0]["book_Name"].ToString();
                tbBookAuthor.Text = dt_Edit.Rows[0]["book_Author"].ToString();
                tbBookDesc.Text = dt_Edit.Rows[0]["book_Description"].ToString();
                tbBookEdition.Text = dt_Edit.Rows[0]["edition"].ToString();
            }
            else
            {
                btnNew_Click(new object(), new EventArgs());

            }
        }

        private bool saveCheck()
        {
            if (tbBookID.Text == "")
            {
                MessageBox.Show("Book ID should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (tbBookName.Text == "")
            {
                MessageBox.Show("Book Name should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (tbBookDesc.Text == "")
            {
                MessageBox.Show("Book Description should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (tbBookAuthor.Text == "")
            {
                MessageBox.Show("Book Author should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                SqlCommand cmd = new SqlCommand("exec sp_SaveBook  'Add','" + int.Parse("0") + "','" + tbBookID.Text.Trim() + "','" + tbBookName.Text + "','" + tbBookAuthor.Text + "','" + tbBookDesc.Text + "','" + int.Parse(tbBookEdition.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedIndex = 0;
               getListData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                SqlCommand cmd = new SqlCommand("exec sp_SaveBook  'Update','" + pBkID + "','" + tbBookID.Text.Trim() + "','" + tbBookName.Text + "','" + tbBookAuthor.Text + "','" + tbBookDesc.Text + "','" + int.Parse(tbBookEdition.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Book?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string bookID = dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim();
                SqlCommand cmd = new SqlCommand("exec sp_DeleteBook '" + bookID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListData();
            }
            else 
            {
                MessageBox.Show("Delete Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
           // getListData();
            this.Text = "BOOK LIST";
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            if (entryMode == "New")
            {
                this.Text = "BOOK (NEW)";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
            if (entryMode == "Edit")
            {
                this.Text = "BOOK (EDIT)";
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmBook_Activated(object sender, EventArgs e)
        {
          //  getListData();
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
         DataView dv;
        //DataTable dt_search = new DataTable();
        //using (SqlCommand cmd = new SqlCommand("sp_SearchBook", con))
        //{
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    // Assuming that "tbBookName.Text" is the value you want to pass as a parameter.
        //    cmd.Parameters.Add("@bookName", SqlDbType.VarChar).Value =  tbSearch.Text;
        //    cmd.ExecuteNonQuery();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    sda.Fill(dt_search);
        //    dgvList.DataSource = dt_search;
        //}
        //// SqlCommand cmd = new SqlCommand("exec sp_SearchBook '" + tbSearch.Text + "' ", con);
        //SqlCommand cmd = new SqlCommand("exec sp_getBookList", con);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt_search = new DataTable();
        //    sda.Fill(dt_search);
            dv = new DataView(dt_list);
            //    dgvList.DataSource = dt_search;
            //string pSearchField = dt_Get0402.Columns[cboSearch.SelectedIndex + 3].ColumnName;
            //dt_Get0402 = cls0402.Search0402(pSearchField, tbSearch.Text);
            //dgvList.DataSource = dt_Get0402;

            string searchTerm = tbSearch.Text.ToLower(); // Convert search term to lowercase for case-insensitive search

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // If the search term is empty or contains only whitespace, show all rows
                dgvList.DataSource = dt_list;
            }
            else
            {
                // Use RowFilter to filter rows that contain the search term in any of the four columns
                dv.RowFilter = $"book_ID LIKE '%{searchTerm}%' " +
                               $"OR book_Name LIKE '%{searchTerm}%'"+
                               $"OR book_Author LIKE '%{searchTerm}%'"+
                               $"OR book_Description LIKE '%{searchTerm}%'"+
                               $"OR Convert(edition , 'System.String') LIKE '%{searchTerm}%'";

                // Update the DataGridView to display the filtered rows
                dgvList.DataSource = dv;
            }
        }
    }
}