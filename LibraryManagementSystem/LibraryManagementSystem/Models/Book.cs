using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {

        private int id;
        private string title;
        private string author;
        private string genre;
        private int publishyear;
        private bool stock;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int PublishYear
        {
            get { return publishyear; }
            set { publishyear = value; }
        }

        public bool Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
