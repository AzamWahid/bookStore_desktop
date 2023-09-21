using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;

namespace bookStore
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private const string ConnectionString = @"Data Source=azam-lt\sql19;Initial Catalog=bookstore;User ID=sa;Password=sasasa-1;MultipleActiveResultSets=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        private void frmBook_Load(object sender, EventArgs e)
        {
            setlistGrid();
        }

        private void setlistGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec sp_getBookList", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dgvList.DataSource = dataTable;
            dgvList.Columns["book_Name"].HeaderText = "Book Name";
            dgvList.Columns["book_Name"].Width = 70;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
            tabControl1.SelectedIndex= 1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

        }
    }
}