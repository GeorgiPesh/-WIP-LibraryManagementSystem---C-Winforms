
namespace LibraryManagementSystem.GUI
{
    partial class GivenBookOperationsForm
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
            this.panelGBTitle = new System.Windows.Forms.Panel();
            this.labelGBTitle = new System.Windows.Forms.Label();
            this.labelGBReader = new System.Windows.Forms.Label();
            this.labelGBBook = new System.Windows.Forms.Label();
            this.buttonAddSave = new System.Windows.Forms.Button();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.panelGBTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGBTitle
            // 
            this.panelGBTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelGBTitle.Controls.Add(this.labelGBTitle);
            this.panelGBTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGBTitle.Location = new System.Drawing.Point(0, 0);
            this.panelGBTitle.Name = "panelGBTitle";
            this.panelGBTitle.Size = new System.Drawing.Size(384, 100);
            this.panelGBTitle.TabIndex = 0;
            // 
            // labelGBTitle
            // 
            this.labelGBTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGBTitle.ForeColor = System.Drawing.Color.White;
            this.labelGBTitle.Location = new System.Drawing.Point(0, 0);
            this.labelGBTitle.Name = "labelGBTitle";
            this.labelGBTitle.Size = new System.Drawing.Size(384, 100);
            this.labelGBTitle.TabIndex = 3;
            this.labelGBTitle.Text = "Взимане на книга";
            this.labelGBTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGBReader
            // 
            this.labelGBReader.AutoSize = true;
            this.labelGBReader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGBReader.Location = new System.Drawing.Point(30, 130);
            this.labelGBReader.Name = "labelGBReader";
            this.labelGBReader.Size = new System.Drawing.Size(67, 20);
            this.labelGBReader.TabIndex = 4;
            this.labelGBReader.Text = "Читател:";
            // 
            // labelGBBook
            // 
            this.labelGBBook.AutoSize = true;
            this.labelGBBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGBBook.Location = new System.Drawing.Point(30, 200);
            this.labelGBBook.Name = "labelGBBook";
            this.labelGBBook.Size = new System.Drawing.Size(53, 20);
            this.labelGBBook.TabIndex = 5;
            this.labelGBBook.Text = "Книга:";
            // 
            // buttonAddSave
            // 
            this.buttonAddSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSave.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonAddSave.FlatAppearance.BorderSize = 0;
            this.buttonAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSave.ForeColor = System.Drawing.Color.White;
            this.buttonAddSave.Location = new System.Drawing.Point(130, 310);
            this.buttonAddSave.Name = "buttonAddSave";
            this.buttonAddSave.Size = new System.Drawing.Size(100, 38);
            this.buttonAddSave.TabIndex = 20;
            this.buttonAddSave.Text = "Добави";
            this.buttonAddSave.UseVisualStyleBackColor = false;
            this.buttonAddSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(130, 130);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(242, 23);
            this.comboBoxReader.TabIndex = 21;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(130, 200);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(242, 23);
            this.comboBoxBook.TabIndex = 22;
            // 
            // GivenBookOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.buttonAddSave);
            this.Controls.Add(this.labelGBBook);
            this.Controls.Add(this.labelGBReader);
            this.Controls.Add(this.panelGBTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GivenBookOperationsForm";
            this.Text = "GivenBookOperationsForm";
            this.Shown += new System.EventHandler(this.GivenBookOperationsForm_Shown);
            this.panelGBTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGBTitle;
        private System.Windows.Forms.Label labelGBTitle;
        private System.Windows.Forms.Label labelGBReader;
        private System.Windows.Forms.Label labelGBBook;
        private System.Windows.Forms.Button buttonAddSave;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.ComboBox comboBoxBook;
    }
}