using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.GUI
{
    public partial class BookOperationsForm : Form
    {
        private readonly BooksForm _parent;
        public BookOperationsForm(BooksForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public string ChangeLabelTitle
        {
            get 
            {
                return this.labelBOTitle.Text;
            }
            set
            {
                this.labelBOTitle.Text = value;
            }
        }
        
        public string ChangeButtonText
        {
            get
            {
                return this.buttonAddSave.Text;
            }
            set
            {
                this.buttonAddSave.Text = value;
            }
        }

        private int getBookID;
        public int GetBookID
        {
            get
            {
                return getBookID;
            }
            set
            {
                getBookID = value;
            }
        }

        public void Clear() 
        {
            tbTitle.Text = string.Empty;
            tbAuthor.Text = string.Empty;
            tbGenre.Text = string.Empty;
            tbPublishYear.Text = string.Empty;
            comboStock.Text = string.Empty;
        }

        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            if (buttonAddSave.Text == "Добави")
            {
                Book book = new Book();
                book.Title = tbTitle.Text;
                book.Author = tbAuthor.Text;
                book.Genre = tbGenre.Text;
                book.PublishYear = int.Parse(tbPublishYear.Text);
                DBBooks.AddBook(book);
                Clear();
            } 
            else
            {
                Book book = new Book();
                book.Title = tbTitle.Text;
                book.Author = tbAuthor.Text;
                book.Genre = tbGenre.Text;
                book.PublishYear = int.Parse(tbPublishYear.Text);
                DBBooks.EditBook(book, GetBookID);
                Clear();
                Close();
            }
            _parent.DisplayBooksDB();
        }

        private void BookOperationsForm_Load(object sender, EventArgs e)
        {
            if (buttonAddSave.Text == "Запази")
            {
                Book book = new Book();
                book = DBBooks.PopulateBookTB(GetBookID);
                tbTitle.Text = book.Title;
                tbAuthor.Text = book.Author;
                tbGenre.Text = book.Genre;
                tbPublishYear.Text= book.PublishYear.ToString();
            }
        }
    }
}
