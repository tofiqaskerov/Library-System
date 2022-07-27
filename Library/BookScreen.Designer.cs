namespace Library
{
    partial class BookScreen
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RchTxtDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NmrPage = new System.Windows.Forms.NumericUpDown();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.CmbAuthor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblBookId = new System.Windows.Forms.Label();
            this.NmrPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnDelete1 = new System.Windows.Forms.Button();
            this.DgvBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(25, 518);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(106, 20);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Add Language";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(25, 381);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(101, 20);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Add Category";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 257);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Author";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(594, 117);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(94, 33);
            this.BtnUpdate.TabIndex = 16;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(594, 117);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(227, 29);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // RchTxtDesc
            // 
            this.RchTxtDesc.Location = new System.Drawing.Point(332, 338);
            this.RchTxtDesc.Name = "RchTxtDesc";
            this.RchTxtDesc.Size = new System.Drawing.Size(507, 164);
            this.RchTxtDesc.TabIndex = 13;
            this.RchTxtDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Page";
            // 
            // NmrPage
            // 
            this.NmrPage.Location = new System.Drawing.Point(332, 117);
            this.NmrPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NmrPage.Name = "NmrPage";
            this.NmrPage.Size = new System.Drawing.Size(150, 27);
            this.NmrPage.TabIndex = 11;
            // 
            // CmbLanguage
            // 
            this.CmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Location = new System.Drawing.Point(24, 461);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(166, 28);
            this.CmbLanguage.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Language";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(24, 338);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(166, 28);
            this.CmbCategory.TabIndex = 8;
            // 
            // CmbAuthor
            // 
            this.CmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAuthor.FormattingEnabled = true;
            this.CmbAuthor.Location = new System.Drawing.Point(24, 212);
            this.CmbAuthor.Name = "CmbAuthor";
            this.CmbAuthor.Size = new System.Drawing.Size(166, 28);
            this.CmbAuthor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author";
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(24, 117);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(166, 27);
            this.TxtBookName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book";
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
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.LblBookCount);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.LblBookId);
            this.splitContainer1.Panel1.Controls.Add(this.NmrPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.BtnDelete1);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.RchTxtDesc);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.CmbCategory);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.NmrPage);
            this.splitContainer1.Panel1.Controls.Add(this.CmbLanguage);
            this.splitContainer1.Panel1.Controls.Add(this.CmbAuthor);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.BtnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.TxtBookName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvBook);
            this.splitContainer1.Size = new System.Drawing.Size(993, 763);
            this.splitContainer1.SplitterDistance = 613;
            this.splitContainer1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(155, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 35);
            this.label10.TabIndex = 26;
            this.label10.Text = "kitab var";
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBookCount.Location = new System.Drawing.Point(121, 564);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(28, 35);
            this.LblBookCount.TabIndex = 25;
            this.LblBookCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 35);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bazada";
            // 
            // LblBookId
            // 
            this.LblBookId.AutoSize = true;
            this.LblBookId.Location = new System.Drawing.Point(550, 214);
            this.LblBookId.Name = "LblBookId";
            this.LblBookId.Size = new System.Drawing.Size(17, 20);
            this.LblBookId.TabIndex = 24;
            this.LblBookId.Text = "0";
            this.LblBookId.Visible = false;
            // 
            // NmrPrice
            // 
            this.NmrPrice.Location = new System.Drawing.Point(332, 212);
            this.NmrPrice.Name = "NmrPrice";
            this.NmrPrice.Size = new System.Drawing.Size(150, 27);
            this.NmrPrice.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Price";
            // 
            // BtnDelete1
            // 
            this.BtnDelete1.Location = new System.Drawing.Point(724, 117);
            this.BtnDelete1.Name = "BtnDelete1";
            this.BtnDelete1.Size = new System.Drawing.Size(97, 33);
            this.BtnDelete1.TabIndex = 21;
            this.BtnDelete1.Text = "Delete";
            this.BtnDelete1.UseVisualStyleBackColor = true;
            this.BtnDelete1.Visible = false;
            this.BtnDelete1.Click += new System.EventHandler(this.BtnDelete1_Click);
            // 
            // DgvBook
            // 
            this.DgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvBook.Location = new System.Drawing.Point(0, 0);
            this.DgvBook.Name = "DgvBook";
            this.DgvBook.RowHeadersWidth = 51;
            this.DgvBook.Size = new System.Drawing.Size(993, 146);
            this.DgvBook.TabIndex = 0;
            this.DgvBook.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBook_RowHeaderMouseDoubleClick);
            // 
            // BookScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 763);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookScreen";
            this.Text = "BookScreen";
            this.Load += new System.EventHandler(this.BookScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NmrPage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NmrPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label4;
        private Label label3;
        private TextBox TxtBookName;
        private Label label2;
        private Label label1;
        private ComboBox CmbAuthor;
        private ComboBox CmbCategory;
        private ComboBox CmbLanguage;
        private Label label5;
        private Label label6;
        private NumericUpDown NmrPage;
        private RichTextBox RchTxtDesc;
        private Label label7;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnUpdate;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private SplitContainer splitContainer1;
        private DataGridView DgvBook;
        private Button BtnDelete1;
        private NumericUpDown NmrPrice;
        private Label label9;
        private Label LblBookId;
        private Label LblBookCount;
        private Label label8;
        private Label label10;
    }
}