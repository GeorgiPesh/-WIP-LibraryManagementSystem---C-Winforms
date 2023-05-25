using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Data
{
    class DBBooks
    {
        public static SqlConnection Connect()
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True");

            conn.Open();

            return conn;
        }

        public static void AddBook(Book book)
        {
            SqlConnection conn = Connect();
            SqlCommand commandInsert = new SqlCommand("INSERT INTO Books VALUES (@Title, @Author, @Genre, @PublishYear)", conn);

            commandInsert.Parameters.Add("@Title", SqlDbType.NVarChar).Value = book.Title;
            commandInsert.Parameters.Add("@Author", SqlDbType.NVarChar).Value = book.Author;
            commandInsert.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = book.Genre;
            commandInsert.Parameters.Add("@PublishYear", SqlDbType.Int).Value = book.PublishYear;
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditBook(Book book, int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandEdit = new SqlCommand("UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, PublishYear=@PublishYear WHERE ID=@id", conn);

            commandEdit.Parameters.Add("@Title", SqlDbType.NVarChar).Value = book.Title;
            commandEdit.Parameters.Add("@Author", SqlDbType.NVarChar).Value = book.Author;
            commandEdit.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = book.Genre;
            commandEdit.Parameters.Add("@PublishYear", SqlDbType.Int).Value = book.PublishYear;
            commandEdit.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commandEdit.ExecuteNonQuery();
        }

        public static void DeleteBook(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandDelete = new SqlCommand("DELETE FROM Books WHERE ID=@id", conn);

            commandDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commandDelete.ExecuteNonQuery();
        }

        public static Book PopulateBookTB(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandSelect = new SqlCommand("Select * From Books Where ID=" + id, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();
            Book book = new Book();
            if (dr != null)
            {
                while (dr.Read())
                {
                    book.Id = Convert.ToInt32(dr["ID"]);
                    book.Title = dr["Title"].ToString();
                    book.Author = dr["Author"].ToString();
                    book.Genre = dr["Genre"].ToString();
                    book.PublishYear = Convert.ToInt32(dr["PublishYear"]);
                }
            }
            return book;
        }

        public static void GetBooksData(string select, DataGridView dgv)
        {
            SqlConnection conn = Connect();
            string sql = select;
            SqlCommand commandSelect = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();
            SqlDataReader dr = commandSelect.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            
            conn.Close();
        }
    }
}

