using Business;
using Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AuthorScreen : Form
    {
        AuthorManager _authorManager = new();
        public AuthorScreen()
        {
            InitializeComponent();
        }

        private void AuthorScreen_Load(object sender, EventArgs e)
        {
            DGV();
        }

        public void DGV()
        {
            var allAuthor = _authorManager.GetAllAuthor().Select(author => new
            {
                Id = author.Id,
                Name = author.Name,
               
            }).ToList();
            DgvAuthor1.DataSource = allAuthor;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            var authorName = TxtAuthor.Text;
            var emptyAuthorName = string.IsNullOrEmpty(authorName);
            if (emptyAuthorName)
            {
                MessageBox.Show("fill in the blanks");
            }
            else
            {
                try
                {

                    Author _author = new()
                    {
                        Name = authorName,
                    };
                    _authorManager.AddAuthor(_author);
                    DialogResult result = MessageBox.Show("Author is added", "Add", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        TxtAuthor.Text = string.Empty;
                        DGV();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DgvAuthor1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
