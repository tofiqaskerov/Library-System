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
    public partial class CategoryScreen : Form
    {
        CategoryManager _categoryManager = new();

        public CategoryScreen()
        {
            InitializeComponent();
        }

        private void CategoryScreen_Load(object sender, EventArgs e)
        {
            DGV();
        }
        public void DGV()
        {
            var allCategory = _categoryManager.GetAllCategorie().Select(category => new
            {
                Id = category.Id,
                Name = category.CategoryName,

            }).ToList();
            DgvCategory.DataSource = allCategory;

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var categoryName = TxtCategory.Text;
            var emptyCategoryName = string.IsNullOrEmpty(categoryName);
            if (emptyCategoryName)
            {
                MessageBox.Show("fill in the blanks");
            }
            else
            {
                try
                {

                    Category _category = new()
                    {
                        CategoryName = categoryName,
                    };
                    _categoryManager.AddCategory(_category);
                    DialogResult result = MessageBox.Show("Category is added", "Category", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        TxtCategory.Text = string.Empty;
                       
                    }
                    DGV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
