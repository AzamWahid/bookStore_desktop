using bookStore.book;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace bookStore
{
    public partial class frmBook : Form
    {
        string entryMode = "";
        string PreviousBOOKID = "";
        DataTable dt_list = new DataTable();

        private readonly ClsBook bookManager;

        public frmBook()
        {
            InitializeComponent();
            bookManager = new ClsBook();
        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            getListData();
        }

        private void getListData()
        {

            dgvList.DataSource = bookManager.GetBooks();
            setGrid();
        }
        private void setGrid()
        {
            dgvList.Columns["book_ID"].HeaderText = "Book ID";
            dgvList.Columns["book_ID"].Width = 50;

            dgvList.Columns["book_Name"].HeaderText = "Book Name";
            dgvList.Columns["book_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns["book_Author"].HeaderText = "Book Author";
            dgvList.Columns["book_Author"].Width = 80;

            dgvList.Columns["book_Description"].HeaderText = "Book Description";
            dgvList.Columns["book_Description"].Width = 80;

            dgvList.Columns["edition"].HeaderText = "Edition";
            dgvList.Columns["edition"].Width = 50;


        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbBookID.Text = "";
            tbBookName.Text = "";
            tbBookAuthor.Text = "";
            tbBookDesc.Text = "";
            tbBookEdition.Text = "0";
            entryMode = "New";
            btnSave.Enabled = true;
            btnSave.BackColor = Color.LightSeaGreen;
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.LightGray;
            this.Text = "BOOK (NEW)";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            getEdit(dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim());
            tbBookID.Focus();
            entryMode = "Edit";

        }
        private void getEdit(string BookID)
        {
            BookModel book = bookManager.GetBookById(BookID);

            if (book != null)
            {
                this.Text = "BOOK (EDIT)";
                entryMode = "Edit";
                //btnSave.Enabled = false;
                //btnUpdate.Enabled = true;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                BookModel newBook = new BookModel
                {
                    BookID = tbBookID.Text.Trim(),
                    BookName = tbBookName.Text,
                    Author = tbBookAuthor.Text,
                    Description = tbBookDesc.Text,
                    Edition = int.Parse(tbBookEdition.Text)
                };

                bookManager.AddBook(newBook);

                MessageBox.Show("Record Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew_Click(sender, e);
                //  getListData();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (saveCheck())
            {
                BookModel newBook = new BookModel
                {
                    BookID = tbBookID.Text.Trim(),
                    BookName = tbBookName.Text,
                    Author = tbBookAuthor.Text,
                    Description = tbBookDesc.Text,
                    Edition = int.Parse(tbBookEdition.Text)
                };

                bookManager.UpdateBook(newBook);

                MessageBox.Show("Record Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getListData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string bookID = dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim();

            if (MessageBox.Show("Are you sure you want to delete "+ dgvList.CurrentRow.Cells["book_Name"].Value.ToString().Trim() + " Book?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bookManager.DeleteBook(bookID);
                MessageBox.Show("Record Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew_Click(sender,e);
                // getListData();
            }
            else
            {
                MessageBox.Show("Delete Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            DataView dv;

            dv = new DataView(bookManager.GetBooks());


            string searchTerm = tbSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {

                dgvList.DataSource = bookManager.GetBooks();
            }
            else
            {
                dv.RowFilter = $"book_ID LIKE '%{searchTerm}%' " +
                               $"OR book_Name LIKE '%{searchTerm}%'" +
                               $"OR book_Author LIKE '%{searchTerm}%'" +
                               $"OR book_Description LIKE '%{searchTerm}%'" +
                               $"OR Convert(edition , 'System.String') LIKE '%{searchTerm}%'";

                dgvList.DataSource = dv;
            }
        }
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getEdit(dgvList.CurrentRow.Cells["book_ID"].Value.ToString().Trim());
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
        private void frmBook_Activated(object sender, EventArgs e)
        {
            getListData();
        }

        private void tbBookEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}