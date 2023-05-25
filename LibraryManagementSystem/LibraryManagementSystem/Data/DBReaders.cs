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
    class DBReaders
    {
        public static SqlConnection Connect() {

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True");

                conn.Open();

            return conn;
        }

        public static void AddReader(Reader reader)
        {
            SqlConnection conn = Connect();
            SqlCommand commandInsert = new SqlCommand("INSERT INTO Readers VALUES (@Name, @Email, @PhoneNumber)",conn);

            commandInsert.Parameters.Add("@Name", SqlDbType.NVarChar).Value = reader.Name;
            commandInsert.Parameters.Add("@Email", SqlDbType.NVarChar).Value = reader.Email;
            commandInsert.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = reader.PhoneNumber;
            commandInsert.ExecuteNonQuery();
            conn.Close();
        }

        public static void EditReader(Reader reader, int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandEdit = new SqlCommand("UPDATE Readers SET ReaderName=@Name, Email=@Email, PhoneNumber=@Phonenumber WHERE ID=@id",conn);

            commandEdit.Parameters.Add("@Name", SqlDbType.NVarChar).Value = reader.Name;
            commandEdit.Parameters.Add("@Email", SqlDbType.NVarChar).Value = reader.Email;
            commandEdit.Parameters.Add("@Phonenumber", SqlDbType.NVarChar).Value = reader.PhoneNumber;
            commandEdit.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commandEdit.ExecuteNonQuery();
        }

        public static void DeleteReader(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandDelete = new SqlCommand("DELETE FROM Readers WHERE ID=@id",conn);

            commandDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commandDelete.ExecuteNonQuery();
        }

        public static Reader PopulateReaderTB(int id)
        {
            SqlConnection conn = Connect();
            SqlCommand commandSelect = new SqlCommand("Select * From Readers Where ID=" + id, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();
            Reader reader = new Reader();
            if (dr != null)
            {
                while (dr.Read()) 
                {
                    reader.Id = Convert.ToInt32(dr["ID"]);
                    reader.Name = dr["ReaderName"].ToString();
                    reader.Email = dr["Email"].ToString();
                    reader.PhoneNumber = dr["PhoneNumber"].ToString();
                }
            }
            return reader;
        }

        public static void GetReadersData(string select,DataGridView dgv)
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
