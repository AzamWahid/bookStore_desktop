using System.Data;

namespace bookStore
{
    public partial class frmBook : Form
    {
        string previousBookId = "";

        //ClsBook Book = new ClsBook();
        DataTable dt_list = new DataTable();
        List<ClsBook> BookList = new List<ClsBook>();
        public frmBook()
        {
            InitializeComponent();
        }
        private void frmBook_Load(object sender, EventArgs e)
        {
            getListData();
            btnNew_Click(sender,e);
        }

        private void getListData()
        {
            ClsBook book = new ClsBook();
            BookList = book.GetBooks();
            dgvList.DataSource = BookList;
            setGrid();
        }
        private void setGrid()
        {
            dgvList.Columns["BookID"].HeaderText = "Book ID";
            dgvList.Columns["BookID"].Width = 50;

            dgvList.Columns["BookName"].HeaderText = "Book Name";
            dgvList.Columns["BookName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns["Author"].HeaderText = "Book Author";
            dgvList.Columns["Author"].Width = 80;

            dgvList.Columns["Description"].HeaderText = "Book Description";
            dgvList.Columns["Description"].Width = 80;

            dgvList.Columns["Edition"].HeaderText = "Edition";
            dgvList.Columns["Edition"].Width = 50;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbBookID.Text = "";
            tbBookName.Text = "";
            tbBookAuthor.Text = "";
            tbBookDesc.Text = "";
            tbBookEdition.Text = "0";

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

            btnSave.BackColor = Color.LightSeaGreen;
            btnUpdate.BackColor = Color.LightGray;
            this.Text = "BOOK (NEW)";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                getEdit(dgvList.CurrentRow.Cells["BookID"].Value.ToString().Trim());
            }
            tbBookID.Focus();

        }
        private void getEdit(string _bookID)
        {
            ClsBook book = new ClsBook();
            book.BookID = _bookID;
            book.GetBookById();
            if (!string.IsNullOrEmpty(book.BookID))
            {
                this.Text = "BOOK (EDIT)";
                btnSave.Enabled = false;
                btnSave.BackColor = Color.LightGray;
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.SteelBlue;


                tbBookID.Text = book.BookID;
                tbBookName.Text = book.BookName;
                tbBookAuthor.Text = book.Author;
                tbBookDesc.Text = book.Description;
                tbBookEdition.Text = book.Edition.ToString();
            }
            else
            {
                btnNew_Click(new object(), new EventArgs());

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                ClsBook book = new ClsBook();

                book.BookID = tbBookID.Text.Trim();
                book.BookName = tbBookName.Text;
                book.Author = tbBookAuthor.Text;
                book.Description = tbBookDesc.Text;
                book.Edition = int.Parse(tbBookEdition.Text);

                book.AddBook();

                MessageBox.Show("Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew_Click(sender, e);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                ClsBook book = new ClsBook();

                book.BookID = tbBookID.Text.Trim();
                book.BookName = tbBookName.Text;
                book.Author = tbBookAuthor.Text;
                book.Description = tbBookDesc.Text;
                book.Edition = int.Parse(tbBookEdition.Text);


                book.UpdateBook();

                MessageBox.Show("Record Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                string bookID = dgvList.CurrentRow.Cells["BookID"].Value.ToString().Trim();

                ClsBook book = new ClsBook();
                book.BookID = bookID;

                if (MessageBox.Show("Are you sure you want to delete " + dgvList.CurrentRow.Cells["BookName"].Value.ToString().Trim() + " Book?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    book.DeleteBook();
                    MessageBox.Show("Record Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Delete Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {

            string searchTerm = tbSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dgvList.DataSource = BookList;
            }
            else
            {
                var filteredList = BookList.Where(book =>
                    book.BookID.ToLower().Contains(searchTerm) ||
                    book.BookName.ToLower().Contains(searchTerm) ||
                    book.Author.ToLower().Contains(searchTerm) ||
                    book.Description.ToLower().Contains(searchTerm) ||
                    book.Edition.ToString().Contains(searchTerm)
                ).ToList();
                dgvList.DataSource = filteredList;
            }
        }
        //-------------------------------------------------SAVE CHECK-------------------------------------------------------------------------
        private bool saveCheck()
        {
            if (tbBookID.Text == "")
            {
                MessageBox.Show("Book ID should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbBookID.Focus();
                return false;
            }
            if (tbBookName.Text == "")
            {
                MessageBox.Show("Book Name should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbBookName.Focus();
                return false;
            }
            if (tbBookDesc.Text == "")
            {
                MessageBox.Show("Book Description should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbBookDesc.Focus();
                return false;
            }
            if (tbBookAuthor.Text == "")
            {
                MessageBox.Show("Book Author should not be empty", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbBookAuthor.Focus();
                return false;
            }
            return true;
        }
        //-------------------------------------------------GRID DOUBLE CLICK EDIT-------------------------------------------------------------------------
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                getEdit(dgvList.CurrentRow.Cells["BookID"].Value.ToString().Trim());
            }
        }

        //-------------------------------------------------BOOK ID TEXTBOX VALIDATION-------------------------------------------------------------------------
        private void tbBookID_Validated(object sender, EventArgs e)
        {
            if ((tbBookID.Text != null) && (previousBookId != tbBookID.Text))
            {
                previousBookId = tbBookID.Text;
                getEdit(tbBookID.Text.Trim());
                tbBookID.Text = previousBookId;
            }
        }
        //-------------------------------------------------FOCUS ON FORM FORM REFRESH-------------------------------------------------------------------------
        private void frmBook_Activated(object sender, EventArgs e)
        {
            getListData();
        }

        //-------------------------------------------------BOOK EDITION NUMERIC ALLOW ONLY-------------------------------------------------------------------------

        private void tbBookEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}