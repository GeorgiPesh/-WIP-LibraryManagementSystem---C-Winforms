
namespace LibraryManagementSystem.GUI
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBooksTitle = new System.Windows.Forms.Panel();
            this.labelBooksTitle = new System.Windows.Forms.Label();
            this.buttonBooksDelete = new System.Windows.Forms.Button();
            this.buttonBooksEdit = new System.Windows.Forms.Button();
            this.buttonBooksAdd = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tbBooksSearch = new System.Windows.Forms.TextBox();
            this.panelBooksTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBooksTitle
            // 
            this.panelBooksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelBooksTitle.Controls.Add(this.labelBooksTitle);
            this.panelBooksTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooksTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBooksTitle.Name = "panelBooksTitle";
            this.panelBooksTitle.Size = new System.Drawing.Size(800, 150);
            this.panelBooksTitle.TabIndex = 0;
            // 
            // labelBooksTitle
            // 
            this.labelBooksTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBooksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.labelBooksTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBooksTitle.ForeColor = System.Drawing.Color.White;
            this.labelBooksTitle.Location = new System.Drawing.Point(0, 0);
            this.labelBooksTitle.Name = "labelBooksTitle";
            this.labelBooksTitle.Size = new System.Drawing.Size(797, 150);
            this.labelBooksTitle.TabIndex = 14;
            this.labelBooksTitle.Text = "Книги";
            this.labelBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBooksDelete
            // 
            this.buttonBooksDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBooksDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonBooksDelete.FlatAppearance.BorderSize = 0;
            this.buttonBooksDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooksDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBooksDelete.ForeColor = System.Drawing.Color.White;
            this.buttonBooksDelete.Location = new System.Drawing.Point(688, 150);
            this.buttonBooksDelete.Name = "buttonBooksDelete";
            this.buttonBooksDelete.Size = new System.Drawing.Size(100, 38);
            this.buttonBooksDelete.TabIndex = 20;
            this.buttonBooksDelete.Text = "Изтрий";
            this.buttonBooksDelete.UseVisualStyleBackColor = false;
            this.buttonBooksDelete.Click += new System.EventHandler(this.buttonBooksDelete_Click);
            // 
            // buttonBooksEdit
            // 
            this.buttonBooksEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBooksEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBooksEdit.FlatAppearance.BorderSize = 0;
            this.buttonBooksEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooksEdit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBooksEdit.ForeColor = System.Drawing.Color.White;
            this.buttonBooksEdit.Location = new System.Drawing.Point(588, 150);
            this.buttonBooksEdit.Name = "buttonBooksEdit";
            this.buttonBooksEdit.Size = new System.Drawing.Size(100, 38);
            this.buttonBooksEdit.TabIndex = 19;
            this.buttonBooksEdit.Text = "Редактирай";
            this.buttonBooksEdit.UseVisualStyleBackColor = false;
            this.buttonBooksEdit.Click += new System.EventHandler(this.buttonBooksEdit_Click);
            // 
            // buttonBooksAdd
            // 
            this.buttonBooksAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBooksAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonBooksAdd.FlatAppearance.BorderSize = 0;
            this.buttonBooksAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooksAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBooksAdd.ForeColor = System.Drawing.Color.White;
            this.buttonBooksAdd.Location = new System.Drawing.Point(488, 150);
            this.buttonBooksAdd.Name = "buttonBooksAdd";
            this.buttonBooksAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonBooksAdd.TabIndex = 18;
            this.buttonBooksAdd.Text = "Добави";
            this.buttonBooksAdd.UseVisualStyleBackColor = false;
            this.buttonBooksAdd.Click += new System.EventHandler(this.buttonBooksAdd_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewBooks.TabIndex = 17;
            // 
            // tbBooksSearch
            // 
            this.tbBooksSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBooksSearch.Location = new System.Drawing.Point(12, 158);
            this.tbBooksSearch.Name = "tbBooksSearch";
            this.tbBooksSearch.Size = new System.Drawing.Size(280, 23);
            this.tbBooksSearch.TabIndex = 16;
            this.tbBooksSearch.TextChanged += new System.EventHandler(this.tbBooksSearch_TextChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonBooksEdit);
            this.Controls.Add(this.buttonBooksAdd);
            this.Controls.Add(this.tbBooksSearch);
            this.Controls.Add(this.panelBooksTitle);
            this.Controls.Add(this.buttonBooksDelete);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Shown += new System.EventHandler(this.BooksForm_Shown);
            this.panelBooksTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBooksTitle;
        private System.Windows.Forms.Button buttonBooksDelete;
        private System.Windows.Forms.Button buttonBooksEdit;
        private System.Windows.Forms.Button buttonBooksAdd;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TextBox tbBooksSearch;
        private System.Windows.Forms.Label labelBooksTitle;
    }
}