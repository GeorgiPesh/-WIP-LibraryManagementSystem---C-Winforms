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
    class DBGivenBooks
    {
        public static SqlConnection Connect()
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True");

            conn.Open();

            return conn;
        }
        public static void AddGivenBook(GivenBook givenBook)
        {
            SqlConnection conn = Connect();
            SqlCommand commandInsert = new SqlCommand("INSERT INTO GivenBooks (ReaderID, BookID, DOE)" +
                                                      "SELECT ", conn);

            commandInsert.Parameters.Add("@ReaderID", SqlDbType.NVarChar).Value = givenBook.ReaderID;
            commandInsert.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = givenBook.BookID;
            commandInsert.Parameters.Add("@DOE", SqlDbType.NVarChar).Value = givenBook.DOE;
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static void ReturnGivenBook(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandReturn = new SqlCommand("DELETE FROM GivenBooks WHERE ID=@id", conn);

            commandReturn.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commandReturn.ExecuteNonQuery();
            conn.Close();
        }

        public static void FillComboReaders(ComboBox combo) 
        {
            SqlConnection conn = Connect();
            SqlCommand commandInsert = new SqlCommand("SELECT ReaderName FROM Readers", conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = commandInsert.ExecuteReader();
            dt.Load(dr);
            combo.ValueMember = "ReaderName";
            combo.DataSource = dt;
            conn.Close();
        }

        public static void FillComboBooks(ComboBox combo)
        {
            SqlConnection conn = Connect();
            SqlCommand commandInsert = new SqlCommand("SELECT Title FROM Books", conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = commandInsert.ExecuteReader();
            dt.Load(dr);
            combo.ValueMember = "Title";
            combo.DataSource = dt;
            conn.Close();
        }

        public static void GetGivenBooksData(string select, DataGridView dgv) {
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
