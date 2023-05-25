
namespace LibraryManagementSystem.GUI
{
    partial class ReaderOperationsForm
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
            this.panelROTitle = new System.Windows.Forms.Panel();
            this.labelROTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbPhonenumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonAddSave = new System.Windows.Forms.Button();
            this.panelROTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelROTitle
            // 
            this.panelROTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelROTitle.Controls.Add(this.labelROTitle);
            this.panelROTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelROTitle.Location = new System.Drawing.Point(0, 0);
            this.panelROTitle.Name = "panelROTitle";
            this.panelROTitle.Size = new System.Drawing.Size(384, 100);
            this.panelROTitle.TabIndex = 0;
            // 
            // labelROTitle
            // 
            this.labelROTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelROTitle.ForeColor = System.Drawing.Color.White;
            this.labelROTitle.Location = new System.Drawing.Point(0, 0);
            this.labelROTitle.Name = "labelROTitle";
            this.labelROTitle.Size = new System.Drawing.Size(384, 100);
            this.labelROTitle.TabIndex = 0;
            this.labelROTitle.Text = "Добави читател";
            this.labelROTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(30, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Име:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(130, 130);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 23);
            this.tbName.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(130, 190);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(242, 23);
            this.tbEmail.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(30, 190);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Имейл:";
            // 
            // tbPhonenumber
            // 
            this.tbPhonenumber.Location = new System.Drawing.Point(130, 250);
            this.tbPhonenumber.Name = "tbPhonenumber";
            this.tbPhonenumber.Size = new System.Drawing.Size(242, 23);
            this.tbPhonenumber.TabIndex = 6;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 250);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(89, 20);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Тел. номер:";
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
            this.buttonAddSave.TabIndex = 19;
            this.buttonAddSave.Text = "Добави";
            this.buttonAddSave.UseVisualStyleBackColor = false;
            this.buttonAddSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // ReaderOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.buttonAddSave);
            this.Controls.Add(this.tbPhonenumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelROTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReaderOperationsForm";
            this.Text = "ReaderOperationsForm";
            this.Load += new System.EventHandler(this.ReaderOperationsForm_Load);
            this.panelROTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelROTitle;
        private System.Windows.Forms.Label labelROTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbPhonenumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonAddSave;
    }
}