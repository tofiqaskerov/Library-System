namespace Library
{
    partial class AuthorScreen
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvAuthor = new System.Windows.Forms.DataGridView();
            this.DgvAuthor1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Author";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(71, 284);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(71, 201);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(239, 27);
            this.TxtAuthor.TabIndex = 2;
            this.TxtAuthor.TextChanged += new System.EventHandler(this.TxtAuthor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DgvAuthor
            // 
            this.DgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthor.Location = new System.Drawing.Point(485, 323);
            this.DgvAuthor.Name = "DgvAuthor";
            this.DgvAuthor.RowHeadersWidth = 51;
            this.DgvAuthor.RowTemplate.Height = 29;
            this.DgvAuthor.Size = new System.Drawing.Size(349, 188);
            this.DgvAuthor.TabIndex = 4;
            // 
            // DgvAuthor1
            // 
            this.DgvAuthor1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAuthor1.ColumnHeadersHeight = 29;
            this.DgvAuthor1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvAuthor1.Location = new System.Drawing.Point(0, 418);
            this.DgvAuthor1.Name = "DgvAuthor1";
            this.DgvAuthor1.RowHeadersWidth = 51;
            this.DgvAuthor1.Size = new System.Drawing.Size(416, 188);
            this.DgvAuthor1.TabIndex = 0;
            this.DgvAuthor1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAuthor1_CellContentClick);
            // 
            // AuthorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 606);
            this.Controls.Add(this.DgvAuthor1);
            this.Controls.Add(this.DgvAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthorScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorScreen";
            this.Load += new System.EventHandler(this.AuthorScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnAdd;
        private TextBox TxtAuthor;
        private Label label2;
        private DataGridView DgvAuthor;
        private DataGridView DgvAuthor1;
    }
}