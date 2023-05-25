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
    public partial class GivenBooksForm : Form
    {
        public GivenBooksForm()
        {
            InitializeComponent();
        }


        public void DisplayGivenBooksDB()
        {
            DBGivenBooks.GetGivenBooksData("Select * FROM GivenBooks ORDER BY ID desc", dataGridViewGivenBooks);
        }

        private void GivenBooksForm_Shown(object sender, EventArgs e)
        {
            DisplayGivenBooksDB();
        }
        private void buttonGivenBooksTake_Click(object sender, EventArgs e)
        {
            GivenBookOperationsForm form = new GivenBookOperationsForm();
            form.ShowDialog();
        }
        private void buttonGivenBooksReturn_Click(object sender, EventArgs e)
        {
            int fetchID;
            fetchID = (int)dataGridViewGivenBooks.Rows[dataGridViewGivenBooks.CurrentRow.Index].Cells[0].Value;
            DBGivenBooks.ReturnGivenBook(fetchID);
            DisplayGivenBooksDB();
        }
    }
}
