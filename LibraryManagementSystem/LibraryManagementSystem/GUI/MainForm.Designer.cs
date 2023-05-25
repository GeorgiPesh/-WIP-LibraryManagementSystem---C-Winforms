
namespace LibraryManagementSystem.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.panelMainTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelMenu.Controls.Add(this.btnIssueBooks);
            this.panelMenu.Controls.Add(this.btnReaders);
            this.panelMenu.Controls.Add(this.btnBooks);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Location = new System.Drawing.Point(0, 270);
            this.btnIssueBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(250, 60);
            this.btnIssueBooks.TabIndex = 3;
            this.btnIssueBooks.Text = "Дадени книги";
            this.btnIssueBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            // 
            // btnReaders
            // 
            this.btnReaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReaders.FlatAppearance.BorderSize = 0;
            this.btnReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReaders.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReaders.ForeColor = System.Drawing.Color.White;
            this.btnReaders.Location = new System.Drawing.Point(0, 210);
            this.btnReaders.Margin = new System.Windows.Forms.Padding(0);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Size = new System.Drawing.Size(250, 60);
            this.btnReaders.TabIndex = 2;
            this.btnReaders.Text = "Читатели";
            this.btnReaders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaders.UseVisualStyleBackColor = true;
            this.btnReaders.Click += new System.EventHandler(this.btnReaders_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 150);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(250, 60);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Книги";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelFrame
            // 
            this.panelFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(135)))));
            this.panelFrame.Controls.Add(this.labelInfo);
            this.panelFrame.Controls.Add(this.panelMainTitle);
            this.panelFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrame.Location = new System.Drawing.Point(250, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(834, 561);
            this.panelFrame.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(17, 166);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(820, 174);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelMainTitle.Controls.Add(this.labelMainTitle);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(834, 150);
            this.panelMainTitle.TabIndex = 0;
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainTitle.ForeColor = System.Drawing.Color.White;
            this.labelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(834, 150);
            this.labelMainTitle.TabIndex = 8;
            this.labelMainTitle.Text = "Управление на библиотека";
            this.labelMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.panelMainTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel panelFrame;
        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label labelInfo;
    }
}