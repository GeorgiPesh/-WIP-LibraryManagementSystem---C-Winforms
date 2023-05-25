
namespace LibraryManagementSystem.GUI
{
    partial class GivenBooksForm
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
            this.panelGivenBooksTitle = new System.Windows.Forms.Panel();
            this.tbGivenBooksSearch = new System.Windows.Forms.TextBox();
            this.buttonGivenBooksReturn = new System.Windows.Forms.Button();
            this.buttonGivenBooksTake = new System.Windows.Forms.Button();
            this.dataGridViewGivenBooks = new System.Windows.Forms.DataGridView();
            this.labelGivenBooksTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGivenBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGivenBooksTitle
            // 
            this.panelGivenBooksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelGivenBooksTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGivenBooksTitle.Location = new System.Drawing.Point(0, 0);
            this.panelGivenBooksTitle.Name = "panelGivenBooksTitle";
            this.panelGivenBooksTitle.Size = new System.Drawing.Size(800, 150);
            this.panelGivenBooksTitle.TabIndex = 0;
            // 
            // tbGivenBooksSearch
            // 
            this.tbGivenBooksSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGivenBooksSearch.Location = new System.Drawing.Point(12, 158);
            this.tbGivenBooksSearch.Name = "tbGivenBooksSearch";
            this.tbGivenBooksSearch.Size = new System.Drawing.Size(280, 23);
            this.tbGivenBooksSearch.TabIndex = 23;
            // 
            // buttonGivenBooksReturn
            // 
            this.buttonGivenBooksReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGivenBooksReturn.BackColor = System.Drawing.Color.Firebrick;
            this.buttonGivenBooksReturn.FlatAppearance.BorderSize = 0;
            this.buttonGivenBooksReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGivenBooksReturn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGivenBooksReturn.ForeColor = System.Drawing.Color.White;
            this.buttonGivenBooksReturn.Location = new System.Drawing.Point(688, 150);
            this.buttonGivenBooksReturn.Name = "buttonGivenBooksReturn";
            this.buttonGivenBooksReturn.Size = new System.Drawing.Size(100, 38);
            this.buttonGivenBooksReturn.TabIndex = 27;
            this.buttonGivenBooksReturn.Text = "Връщане";
            this.buttonGivenBooksReturn.UseVisualStyleBackColor = false;
            this.buttonGivenBooksReturn.Click += new System.EventHandler(this.buttonGivenBooksReturn_Click);
            // 
            // buttonGivenBooksTake
            // 
            this.buttonGivenBooksTake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGivenBooksTake.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGivenBooksTake.FlatAppearance.BorderSize = 0;
            this.buttonGivenBooksTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGivenBooksTake.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGivenBooksTake.ForeColor = System.Drawing.Color.White;
            this.buttonGivenBooksTake.Location = new System.Drawing.Point(588, 150);
            this.buttonGivenBooksTake.Name = "buttonGivenBooksTake";
            this.buttonGivenBooksTake.Size = new System.Drawing.Size(100, 38);
            this.buttonGivenBooksTake.TabIndex = 26;
            this.buttonGivenBooksTake.Text = "Взимане";
            this.buttonGivenBooksTake.UseVisualStyleBackColor = false;
            this.buttonGivenBooksTake.Click += new System.EventHandler(this.buttonGivenBooksTake_Click);
            // 
            // dataGridViewGivenBooks
            // 
            this.dataGridViewGivenBooks.AllowUserToAddRows = false;
            this.dataGridViewGivenBooks.AllowUserToDeleteRows = false;
            this.dataGridViewGivenBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGivenBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGivenBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGivenBooks.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewGivenBooks.Name = "dataGridViewGivenBooks";
            this.dataGridViewGivenBooks.ReadOnly = true;
            this.dataGridViewGivenBooks.RowTemplate.Height = 25;
            this.dataGridViewGivenBooks.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewGivenBooks.TabIndex = 24;
            // 
            // labelGivenBooksTitle
            // 
            this.labelGivenBooksTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGivenBooksTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.labelGivenBooksTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGivenBooksTitle.ForeColor = System.Drawing.Color.White;
            this.labelGivenBooksTitle.Location = new System.Drawing.Point(0, 0);
            this.labelGivenBooksTitle.Name = "labelGivenBooksTitle";
            this.labelGivenBooksTitle.Size = new System.Drawing.Size(797, 150);
            this.labelGivenBooksTitle.TabIndex = 21;
            this.labelGivenBooksTitle.Text = "Дадени книги";
            this.labelGivenBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GivenBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGivenBooksSearch);
            this.Controls.Add(this.buttonGivenBooksReturn);
            this.Controls.Add(this.buttonGivenBooksTake);
            this.Controls.Add(this.dataGridViewGivenBooks);
            this.Controls.Add(this.labelGivenBooksTitle);
            this.Controls.Add(this.panelGivenBooksTitle);
            this.Name = "GivenBooksForm";
            this.Text = "IssuedBooksForm";
            this.Shown += new System.EventHandler(this.GivenBooksForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGivenBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGivenBooksTitle;
        private System.Windows.Forms.TextBox tbGivenBooksSearch;
        private System.Windows.Forms.Button buttonGivenBooksReturn;
        private System.Windows.Forms.Button buttonGivenBooksTake;
        private System.Windows.Forms.DataGridView dataGridViewGivenBooks;
        private System.Windows.Forms.Label labelGivenBooksTitle;
    }
}