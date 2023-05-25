using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
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
    public partial class GivenBookOperationsForm : Form
    {
        public GivenBookOperationsForm()
        {
            InitializeComponent();
        }

        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            GivenBook givenBook = new GivenBook();
            givenBook.ReaderID = comboBoxReader.SelectedIndex;
            givenBook.BookID = comboBoxBook.SelectedIndex;
            //givenBook.DOE = ;
        }

        public void FillCombos()
        {
            DBGivenBooks.FillComboBooks(comboBoxBook);
            DBGivenBooks.FillComboReaders(comboBoxReader);
        }

        private void GivenBookOperationsForm_Shown(object sender, EventArgs e)
        {
            FillCombos();
        }
    }
}
