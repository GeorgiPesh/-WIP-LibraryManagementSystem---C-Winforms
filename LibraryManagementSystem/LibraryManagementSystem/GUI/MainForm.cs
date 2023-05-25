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
    public partial class MainForm : Form
    {

        private Button buttonClicked;
        private StyleHelper style = new StyleHelper();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonStyle(object clicked) 
        {
            if (clicked != null)
            {
                InactiveButton();
                buttonClicked = (Button)clicked;

                buttonClicked.ForeColor = style.changedForeColor;
                buttonClicked.BackColor = style.changedBackColor;
                buttonClicked.Font = style.changedFont;
                buttonClicked.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void InactiveButton()
        {
            if (buttonClicked != null)
            {
                buttonClicked.ForeColor = style.normalForeColor;
                buttonClicked.BackColor = style.normalBackColor;
                buttonClicked.Font = style.normalFont;
                buttonClicked.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        Form currentForm = null;
        private void ShowForm (Form shownForm) 
        {
            CloseCurrentForm();
            currentForm = shownForm;
            shownForm.TopLevel = false;
            shownForm.Dock = DockStyle.Fill;
            shownForm.FormBorderStyle = FormBorderStyle.None;
            panelFrame.Controls.Add(shownForm);
            panelMainTitle.Visible = false;
            shownForm.BringToFront();
            shownForm.Show();
        }

        private void CloseCurrentForm() 
        {
            if (currentForm != null)
                currentForm.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ButtonStyle(sender);
            ShowForm(new BooksForm());
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            ButtonStyle(sender);
            ShowForm(new ReadersForm());
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            ButtonStyle(sender);
            ShowForm(new GivenBooksForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseCurrentForm();
            InactiveButton();
            panelMainTitle.Visible = true;
        }
    }
}
