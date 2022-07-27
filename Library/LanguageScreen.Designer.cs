namespace Library
{
    partial class LanguageScreen
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
            this.DgvLanguage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLanguage = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLanguage
            // 
            this.DgvLanguage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLanguage.ColumnHeadersHeight = 29;
            this.DgvLanguage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvLanguage.Location = new System.Drawing.Point(0, 356);
            this.DgvLanguage.Name = "DgvLanguage";
            this.DgvLanguage.RowHeadersWidth = 51;
            this.DgvLanguage.Size = new System.Drawing.Size(361, 188);
            this.DgvLanguage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Language Name";
            // 
            // TxtLanguage
            // 
            this.TxtLanguage.Location = new System.Drawing.Point(71, 152);
            this.TxtLanguage.Name = "TxtLanguage";
            this.TxtLanguage.Size = new System.Drawing.Size(239, 27);
            this.TxtLanguage.TabIndex = 12;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(71, 235);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Language";
            // 
            // LanguageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 544);
            this.Controls.Add(this.DgvLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLanguage);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LanguageScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageScreen";
            this.Load += new System.EventHandler(this.LanguageScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvLanguage;
        private Label label2;
        private TextBox TxtLanguage;
        private Button BtnAdd;
        private Label label1;
    }
}