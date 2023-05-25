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
    public partial class ReaderOperationsForm : Form
    {
        private readonly ReadersForm _parent;
        public ReaderOperationsForm(ReadersForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public string ChangeLabelTitle
        {
            get
            {
                return this.labelROTitle.Text;
            }
            set
            {
                this.labelROTitle.Text = value;
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

        private int getReaderID;
        public int GetReaderID 
        {
            get
            {
                return getReaderID;
            }
            set
            {
                getReaderID = value;
            }
        }

        public void Clear()
        {
            tbName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhonenumber.Text = string.Empty;
        }
        private void buttonAddSave_Click(object sender, EventArgs e)
        {
            if (buttonAddSave.Text == "Добави")
            {
                Reader reader = new Reader();
                reader.Name = tbName.Text.ToString();
                reader.Email = tbEmail.Text.ToString();
                reader.PhoneNumber = tbPhonenumber.Text.ToString();
                DBReaders.AddReader(reader);
                Clear();
            } 
            else
            {
                Reader reader = new Reader();
                reader.Name = tbName.Text.ToString();
                reader.Email = tbEmail.Text.ToString();
                reader.PhoneNumber = tbPhonenumber.Text.ToString();
                DBReaders.EditReader(reader, GetReaderID);
                Clear();
                Close();
            }
            _parent.DisplayReadersDB();
        }

        private void ReaderOperationsForm_Load(object sender, EventArgs e)
        {
            if (buttonAddSave.Text == "Запази")
            {
                Reader reader = new Reader();
                reader = DBReaders.PopulateReaderTB(GetReaderID);
                tbName.Text = reader.Name;
                tbEmail.Text = reader.Email;
                tbPhonenumber.Text = reader.PhoneNumber;
            }
        }
    }
}
