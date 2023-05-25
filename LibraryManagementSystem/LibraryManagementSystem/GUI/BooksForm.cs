using LibraryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.GUI
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }



        public void DisplayBooksDB()
        {
            DBBooks.GetBooksData("Select * FROM Books ORDER BY ID desc", dataGridViewBooks);
        }

        private void BooksForm_Shown(object sender, EventArgs e)
        {
            DisplayBooksDB();
        }

        private void tbBooksSearch_TextChanged(object sender, EventArgs e)
        {
            DBBooks.GetBooksData("Select * FROM Books WHERE Genre LIKE'%" + tbBooksSearch.Text + "%' OR Author Like '%" +
                tbBooksSearch.Text+ "%' OR Title LIKE '%" + tbBooksSearch.Text +"%'", dataGridViewBooks);
        }
        private void buttonBooksAdd_Click(object sender, EventArgs e)
        {
            BookOperationsForm form = new BookOperationsForm(this);
            form.ShowDialog();
        }

        private void buttonBooksEdit_Click(object sender, EventArgs e)
        {
            BookOperationsForm form = new BookOperationsForm(this);
            var row = dataGridViewBooks.CurrentRow.Index;
            form.ChangeLabelTitle = "Редактирай книга";
            form.ChangeButtonText = "Запази";
            form.GetBookID = (int)dataGridViewBooks.Rows[row].Cells[0].Value;
            form.ShowDialog();
        }
        private void buttonBooksDelete_Click(object sender, EventArgs e)
        {
            int fetchID;
            fetchID = (int)dataGridViewBooks.Rows[dataGridViewBooks.CurrentRow.Index].Cells[0].Value;
            DBBooks.DeleteBook(fetchID);
            DisplayBooksDB();
        }
    }
}
