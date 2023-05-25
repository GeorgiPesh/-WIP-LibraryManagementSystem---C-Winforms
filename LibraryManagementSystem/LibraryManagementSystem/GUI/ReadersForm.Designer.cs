
namespace LibraryManagementSystem.GUI
{
    partial class ReadersForm
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
            this.panelReadersTitle = new System.Windows.Forms.Panel();
            this.labelReadersTitle = new System.Windows.Forms.Label();
            this.buttonReadersDelete = new System.Windows.Forms.Button();
            this.buttonReadersEdit = new System.Windows.Forms.Button();
            this.buttonReadersAdd = new System.Windows.Forms.Button();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.tbReadersSearch = new System.Windows.Forms.TextBox();
            this.panelReadersTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReadersTitle
            // 
            this.panelReadersTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(100)))));
            this.panelReadersTitle.Controls.Add(this.labelReadersTitle);
            this.panelReadersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReadersTitle.Location = new System.Drawing.Point(0, 0);
            this.panelReadersTitle.Name = "panelReadersTitle";
            this.panelReadersTitle.Size = new System.Drawing.Size(800, 150);
            this.panelReadersTitle.TabIndex = 0;
            // 
            // labelReadersTitle
            // 
            this.labelReadersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReadersTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReadersTitle.ForeColor = System.Drawing.Color.White;
            this.labelReadersTitle.Location = new System.Drawing.Point(0, 0);
            this.labelReadersTitle.Name = "labelReadersTitle";
            this.labelReadersTitle.Size = new System.Drawing.Size(797, 150);
            this.labelReadersTitle.TabIndex = 7;
            this.labelReadersTitle.Text = "Читатели";
            this.labelReadersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReadersDelete
            // 
            this.buttonReadersDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadersDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonReadersDelete.FlatAppearance.BorderSize = 0;
            this.buttonReadersDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadersDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadersDelete.ForeColor = System.Drawing.Color.White;
            this.buttonReadersDelete.Location = new System.Drawing.Point(688, 150);
            this.buttonReadersDelete.Name = "buttonReadersDelete";
            this.buttonReadersDelete.Size = new System.Drawing.Size(100, 38);
            this.buttonReadersDelete.TabIndex = 13;
            this.buttonReadersDelete.Text = "Изтрий";
            this.buttonReadersDelete.UseVisualStyleBackColor = false;
            this.buttonReadersDelete.Click += new System.EventHandler(this.buttonReadersDelete_Click);
            // 
            // buttonReadersEdit
            // 
            this.buttonReadersEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadersEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonReadersEdit.FlatAppearance.BorderSize = 0;
            this.buttonReadersEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadersEdit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadersEdit.ForeColor = System.Drawing.Color.White;
            this.buttonReadersEdit.Location = new System.Drawing.Point(588, 150);
            this.buttonReadersEdit.Name = "buttonReadersEdit";
            this.buttonReadersEdit.Size = new System.Drawing.Size(100, 38);
            this.buttonReadersEdit.TabIndex = 12;
            this.buttonReadersEdit.Text = "Редактирай";
            this.buttonReadersEdit.UseVisualStyleBackColor = false;
            this.buttonReadersEdit.Click += new System.EventHandler(this.buttonReadersEdit_Click);
            // 
            // buttonReadersAdd
            // 
            this.buttonReadersAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadersAdd.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonReadersAdd.FlatAppearance.BorderSize = 0;
            this.buttonReadersAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadersAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadersAdd.ForeColor = System.Drawing.Color.White;
            this.buttonReadersAdd.Location = new System.Drawing.Point(488, 150);
            this.buttonReadersAdd.Name = "buttonReadersAdd";
            this.buttonReadersAdd.Size = new System.Drawing.Size(100, 38);
            this.buttonReadersAdd.TabIndex = 11;
            this.buttonReadersAdd.Text = "Добави";
            this.buttonReadersAdd.UseVisualStyleBackColor = false;
            this.buttonReadersAdd.Click += new System.EventHandler(this.buttonReadersAdd_Click);
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.AllowUserToAddRows = false;
            this.dataGridViewReaders.AllowUserToDeleteRows = false;
            this.dataGridViewReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowTemplate.Height = 25;
            this.dataGridViewReaders.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewReaders.TabIndex = 10;
            // 
            // tbReadersSearch
            // 
            this.tbReadersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReadersSearch.Location = new System.Drawing.Point(12, 158);
            this.tbReadersSearch.Name = "tbReadersSearch";
            this.tbReadersSearch.Size = new System.Drawing.Size(280, 23);
            this.tbReadersSearch.TabIndex = 9;
            this.tbReadersSearch.TextChanged += new System.EventHandler(this.tbReadersSearch_TextChanged);
            // 
            // ReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(185)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReaders);
            this.Controls.Add(this.tbReadersSearch);
            this.Controls.Add(this.buttonReadersDelete);
            this.Controls.Add(this.buttonReadersEdit);
            this.Controls.Add(this.buttonReadersAdd);
            this.Controls.Add(this.panelReadersTitle);
            this.Name = "ReadersForm";
            this.Text = "ReadersForm";
            this.Shown += new System.EventHandler(this.ReadersForm_Shown);
            this.panelReadersTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReadersTitle;
        private System.Windows.Forms.Button buttonReadersDelete;
        private System.Windows.Forms.Button buttonReadersEdit;
        private System.Windows.Forms.Button buttonReadersAdd;
        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.TextBox tbReadersSearch;
        private System.Windows.Forms.Label labelReadersTitle;
    }
}