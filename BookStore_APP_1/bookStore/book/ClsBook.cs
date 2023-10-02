using bookStore.book;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace bookStore
{
    public class ClsBook
    {
        private readonly SqlConnection connection;

        public ClsBook()
        {
            // Load the connection string from app.config
            string connectionString = clsGeneral.getConnectionString();
            connection = new SqlConnection(connectionString);
        }

        public DataTable GetBooks()
        {
            using (SqlCommand cmd = new SqlCommand("sp_getBookList", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
        public BookModel GetBookById(string bookID)
        {
            using (SqlCommand cmd = new SqlCommand("sp_getBookEdit", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@book_ID", bookID);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                BookModel? book = null;

                if (reader.Read())
                {
                    book = new BookModel
                    {
                        BookID = reader["book_ID"].ToString().Trim(),
                        BookName = reader["book_Name"].ToString(),
                        Author = reader["book_Author"].ToString(),
                        Description = reader["book_Description"].ToString(),
                        Edition = Convert.ToInt32(reader["edition"])
                    };
                }

                reader.Close();
                connection.Close();

                return book;
            }
        }

        public void AddBook(BookModel book)
        {
            using (SqlCommand cmd = new SqlCommand("sp_SaveBook", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EntryMode", "Add");
                cmd.Parameters.AddWithValue("@book_ID", book.BookID);
                cmd.Parameters.AddWithValue("@book_Name", book.BookName);
                cmd.Parameters.AddWithValue("@book_Author", book.Author);
                cmd.Parameters.AddWithValue("@book_Description", book.Description);
                cmd.Parameters.AddWithValue("@edition", book.Edition);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdateBook(BookModel book)
        {
            using (SqlCommand cmd = new SqlCommand("sp_SaveBook", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EntryMode", "Update");
                cmd.Parameters.AddWithValue("@book_ID", book.BookID);
                cmd.Parameters.AddWithValue("@book_Name", book.BookName);
                cmd.Parameters.AddWithValue("@book_Author", book.Author);
                cmd.Parameters.AddWithValue("@book_Description", book.Description);
                cmd.Parameters.AddWithValue("@edition", book.Edition);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void DeleteBook(string bookID)
        {
            using (SqlCommand cmd = new SqlCommand("sp_DeleteBook", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@book_ID", bookID);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
