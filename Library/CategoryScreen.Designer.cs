namespace Library
{
    partial class CategoryScreen
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
            this.DgvCategory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategory
            // 
            this.DgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategory.ColumnHeadersHeight = 29;
            this.DgvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCategory.Location = new System.Drawing.Point(0, 361);
            this.DgvCategory.Name = "DgvCategory";
            this.DgvCategory.RowHeadersWidth = 51;
            this.DgvCategory.Size = new System.Drawing.Size(364, 188);
            this.DgvCategory.TabIndex = 4;
            this.DgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategory_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(71, 168);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(239, 27);
            this.TxtCategory.TabIndex = 7;
            this.TxtCategory.TextChanged += new System.EventHandler(this.TxtCategory_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(71, 251);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CategoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 549);
            this.Controls.Add(this.DgvCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCategory);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryScreen";
            this.Load += new System.EventHandler(this.CategoryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvCategory;
        private Label label2;
        private TextBox TxtCategory;
        private Button BtnAdd;
        private Label label1;
    }
}