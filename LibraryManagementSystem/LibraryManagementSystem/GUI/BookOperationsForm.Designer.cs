
namespace LibraryManagementSystem.GUI
{
    partial class BookOperationsForm
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
            this.panelBOTitle = new System.Windows.Forms.Panel();
            this.labelBOTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.tbPublishYear = new System.Windows.Forms.TextBox();
            this.labelPublishYear = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonAddSave = new System.Windows.Forms.Button();
            this.comboStock = new System.Windows.Forms.ComboBox();
            this.panelBOTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBOTitle
            // 
            this.panelBOTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelBOTitle.Controls.Add(this.labelBOTitle);
            this.panelBOTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBOTitle.Location = new System.Drawing.Point(0, 0);
            this.panelBOTitle.Name = "panelBOTitle";
            this.panelBOTitle.Size = new System.Drawing.Size(384, 100);
            this.panelBOTitle.TabIndex = 0;
            // 
            // labelBOTitle
            // 
            this.labelBOTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBOTitle.ForeColor = System.Drawing.Color.White;
            this.labelBOTitle.Location = new System.Drawing.Point(0, 0);
            this.labelBOTitle.Name = "labelBOTitle";
            this.labelBOTitle.Size = new System.Drawing.Size(384, 100);
            this.labelBOTitle.TabIndex = 3;
            this.labelBOTitle.Text = "Добави книга";
            this.labelBOTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(130, 130);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(242, 23);
            this.tbTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(30, 130);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(75, 20);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Заглавие:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(130, 180);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(242, 23);
            this.tbAuthor.TabIndex = 7;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor.Location = new System.Drawing.Point(30, 180);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 20);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Автор:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(130, 230);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(242, 23);
            this.tbGenre.TabIndex = 9;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenre.Location = new System.Drawing.Point(30, 230);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(51, 20);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Жанр:";
            // 
            // tbPublishYear
            // 
            this.tbPublishYear.Location = new System.Drawing.Point(130, 280);
            this.tbPublishYear.Name = "tbPublishYear";
            this.tbPublishYear.Size = new System.Drawing.Size(242, 23);
            this.tbPublishYear.TabIndex = 11;
            // 
            // labelPublishYear
            // 
            this.labelPublishYear.AutoSize = true;
            this.labelPublishYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPublishYear.Location = new System.Drawing.Point(30, 280);
            this.labelPublishYear.Name = "labelPublishYear";
            this.labelPublishYear.Size = new System.Drawing.Size(79, 20);
            this.labelPublishYear.TabIndex = 10;
            this.labelPublishYear.Text = "Издадена:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.Location = new System.Drawing.Point(30, 330);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(87, 20);
            this.labelStock.TabIndex = 12;
            this.labelStock.Text = "Наличност:";
            // 
            // buttonAddSave
            // 
            this.buttonAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonAddSave.FlatAppearance.BorderSize = 0;
            this.buttonAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSave.ForeColor = System.Drawing.Color.White;
            this.buttonAddSave.Location = new System.Drawing.Point(130, 380);
            this.buttonAddSave.Name = "buttonAddSave";
            this.buttonAddSave.Size = new System.Drawing.Size(100, 38);
            this.buttonAddSave.TabIndex = 20;
            this.buttonAddSave.Text = "Добави";
            this.buttonAddSave.UseVisualStyleBackColor = false;
            this.buttonAddSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // comboStock
            // 
            this.comboStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStock.FormattingEnabled = true;
            this.comboStock.Items.AddRange(new object[] {
            "Да",
            "Не"});
            this.comboStock.Location = new System.Drawing.Point(130, 330);
            this.comboStock.Name = "comboStock";
            this.comboStock.Size = new System.Drawing.Size(121, 23);
            this.comboStock.TabIndex = 21;
            // 
            // BookOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.comboStock);
            this.Controls.Add(this.buttonAddSave);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.tbPublishYear);
            this.Controls.Add(this.labelPublishYear);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelBOTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BookOperationsForm";
            this.Text = "BookOperationsForm";
            this.Load += new System.EventHandler(this.BookOperationsForm_Load);
            this.panelBOTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBOTitle;
        private System.Windows.Forms.Label labelBOTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox tbPublishYear;
        private System.Windows.Forms.Label labelPublishYear;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button buttonAddSave;
        private System.Windows.Forms.ComboBox comboStock;
    }
}