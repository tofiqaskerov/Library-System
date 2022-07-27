namespace Library
{
    partial class RentBookScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.DgvBook = new System.Windows.Forms.DataGridView();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserId = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LblUserLimit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent Book";
            // 
            // DgvBook
            // 
            this.DgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBook.Location = new System.Drawing.Point(0, 0);
            this.DgvBook.Name = "DgvBook";
            this.DgvBook.RowHeadersWidth = 51;
            this.DgvBook.RowTemplate.Height = 29;
            this.DgvBook.Size = new System.Drawing.Size(964, 202);
            this.DgvBook.TabIndex = 1;
          
            // 
            // CmbBooks
            // 
            this.CmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(41, 130);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(151, 28);
            this.CmbBooks.TabIndex = 2;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(247, 125);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(107, 33);
            this.BtnConfirm.TabIndex = 3;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Books";
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(247, 78);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(17, 20);
            this.LblUserId.TabIndex = 5;
            this.LblUserId.Text = "0";
            this.LblUserId.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblUserLimit);
            this.splitContainer1.Panel1.Controls.Add(this.CmbBooks);
            this.splitContainer1.Panel1.Controls.Add(this.LblUserId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnConfirm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvBook);
            this.splitContainer1.Size = new System.Drawing.Size(964, 520);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 6;
            // 
            // LblUserLimit
            // 
            this.LblUserLimit.AutoSize = true;
            this.LblUserLimit.Location = new System.Drawing.Point(247, 193);
            this.LblUserLimit.Name = "LblUserLimit";
            this.LblUserLimit.Size = new System.Drawing.Size(17, 20);
            this.LblUserLimit.TabIndex = 6;
            this.LblUserLimit.Text = "0";
            this.LblUserLimit.Visible = false;
            // 
            // RentBookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 520);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentBookScreen";
            this.Text = "RentBookScreen";
            this.Load += new System.EventHandler(this.RentBookScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private DataGridView DgvBook;
        private ComboBox CmbBooks;
        private Button BtnConfirm;
        private Label label2;
        private Label LblUserId;
        private SplitContainer splitContainer1;
        private Label LblUserLimit;
    }
}