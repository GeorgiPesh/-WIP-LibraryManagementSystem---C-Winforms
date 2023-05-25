using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Models
{
    public class GivenBook
    {
        private int id;
        private int readerID;
        private int bookID;
        private DateTime doe;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ReaderID
        {
            get { return readerID; }
            set { readerID = value; }
        }
        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        public DateTime DOE
        {
            get { return doe; }
            set { doe = value; }
        }
    }
}
