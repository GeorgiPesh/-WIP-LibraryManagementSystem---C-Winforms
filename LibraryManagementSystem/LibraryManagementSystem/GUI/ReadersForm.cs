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
    public partial class ReadersForm : Form
    {
        public ReadersForm()
        {
            InitializeComponent();
        }



        public void DisplayReadersDB()
        {
            DBReaders.GetReadersData("Select * FROM Readers ORDER BY ID desc", dataGridViewReaders);
        }

        private void ReadersForm_Shown(object sender, EventArgs e)
        {
            DisplayReadersDB();
        }

        private void tbReadersSearch_TextChanged(object sender, EventArgs e)
        {
            DBReaders.GetReadersData("Select * FROM Readers WHERE ReaderName LIKE'%" + tbReadersSearch.Text + "%' OR Email Like '%" +
                tbReadersSearch.Text + "%' OR PhoneNumber LIKE '%" + tbReadersSearch.Text + "%'", dataGridViewReaders);
        }

        private void buttonReadersAdd_Click(object sender, EventArgs e)
        {
            ReaderOperationsForm form = new ReaderOperationsForm(this);
            form.ShowDialog();
        }

        private void buttonReadersEdit_Click(object sender, EventArgs e)
        {
            ReaderOperationsForm form = new ReaderOperationsForm(this);
            var row = dataGridViewReaders.CurrentRow.Index;
            form.ChangeLabelTitle = "Редактирай читател";
            form.ChangeButtonText = "Запази";
            form.GetReaderID = (int)dataGridViewReaders.Rows[row].Cells[0].Value;
            form.ShowDialog();
        }

        private void buttonReadersDelete_Click(object sender, EventArgs e)
        {
            int fetchID;
            fetchID = (int)dataGridViewReaders.Rows[dataGridViewReaders.CurrentRow.Index].Cells[0].Value;
            DBReaders.DeleteReader(fetchID);
            DisplayReadersDB();
        }
    }
}
