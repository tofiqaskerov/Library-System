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
    public partial class BookScreen : Form
    {
        AuthorManager _authorManager = new();
        CategoryManager _categoryManager = new();
        LanguageManager _languageManager = new();
        BookManager _bookManager = new();
        public BookScreen()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorScreen _authorScreen = new();
            _authorScreen.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryScreen _categoryScreen = new();
            _categoryScreen.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LanguageScreen _languageScreen = new();
            _languageScreen.Show();
        }

        private void BookScreen_Load(object sender, EventArgs e)
        {
            var bookCount = _bookManager.BookCount();
            LblBookCount.Text = bookCount.ToString();

            var authors = _authorManager.GetAuthors();

            foreach (var author in authors)
            {
                CmbAuthor.Items.Add(author.Name);
            }

            var languages = _languageManager.GetLanguages();

            foreach (var langauge in languages)
            {
                CmbLanguage.Items.Add(langauge.LanguageName);
            }

            var categories = _categoryManager.GetCategories();

            foreach (var category in categories)
            {
                CmbCategory.Items.Add(category.CategoryName);
            }
            DGV();
        }
        public void DGV()
        {
            var allBook = _bookManager.GetAllBook().Select(book => new
            {
                Id = book.Id,
                Name = book.Name,
                Page = book.Page,
                Author = book.Author.Name,
                Language = book.Language.LanguageName,
                Price = book.Price,
                Description = book.Description,
                IsDeleted = book.IsDeleted
            }).ToList();
            DgvBook.DataSource = allBook;   
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var bookName = TxtBookName.Text;
            var selectedAuthor = CmbAuthor.Text;
            var selectedLanguage = CmbLanguage.Text;
            var selectedCategory = CmbCategory.Text;
            var page = Convert.ToInt32(NmrPage.Value);
            var price = Convert.ToInt32(NmrPrice.Value);
            var description = RchTxtDesc.Text;
            var author = _authorManager.GetAuthorByName(selectedAuthor);
            var language = _languageManager.GetLanguageByName(selectedLanguage);
            var category = _categoryManager.GetCategoryByName(selectedCategory);

            var emptyBookName = string.IsNullOrEmpty(bookName);
            var emptySelectedAuthor = string.IsNullOrEmpty(selectedAuthor);
            var emptySelectedLanguage = string.IsNullOrEmpty(selectedLanguage);
            var emptySelectedCategory = string.IsNullOrEmpty(selectedCategory);
            var emptyPage = 0;
            var emptyDescription = string.IsNullOrEmpty(description);


            if(emptyBookName || emptySelectedAuthor || emptySelectedCategory || emptySelectedLanguage  || emptyDescription)
            {
                MessageBox.Show("fill in the blanks");
            }
            else
            {
                Book _book = new()
                {
                    Name = bookName,
                    AuthorId = author.Id,
                    LanguageId = language.Id,
                    CategoryId = category.Id,
                    Page = page,
                    Price = price,
                    Description = description
                };
                _bookManager.AddBook(_book);
                DialogResult result = MessageBox.Show("Book is added", "Add", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    TxtBookName.Text = string.Empty;
                    CmbAuthor.Text = string.Empty; 
                    CmbCategory.Text = string.Empty;
                    CmbLanguage.Text = string.Empty;
                    NmrPage.Value = 0;
                    NmrPrice.Value = 0;
                    RchTxtDesc.Text = string.Empty; 
                    DGV();
                }
            }

            

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    var bookId = Convert.ToInt32(LblBookId.Text);
                    var book =  _bookManager.GetBookById(bookId);
                    var author = _authorManager.GetAuthorByName(CmbAuthor.Text);
                    var category = _categoryManager.GetCategoryByName(CmbCategory.Text);
                    var language = _languageManager.GetLanguageByName(CmbLanguage.Text);

                    book.Name = TxtBookName.Text;
                    book.AuthorId = author.Id;
                    book.CategoryId = category.Id; 
                    book.LanguageId = language.Id;
                    book.Page = Convert.ToInt32(NmrPage.Value);
                    book.Price = Convert.ToInt32(NmrPrice.Value);
                    _bookManager.Update(book);

                    TxtBookName.Text = string.Empty;
                    CmbAuthor.Text = string.Empty;
                    CmbCategory.Text = string.Empty;
                    CmbLanguage.Text = string.Empty;
                    RchTxtDesc.Text = string.Empty;
                    NmrPage.Value = 0;
                    NmrPrice.Value = 0;
                    MessageBox.Show("Book  is Updated", "Completed", MessageBoxButtons.OK);

                    DGV();

                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure?", "Delete teacher", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    var bookId = Convert.ToInt32(LblBookId.Text);
                    var book = _bookManager.GetBookById(bookId);
                    _bookManager.DeleteBook(book);
                    TxtBookName.Text = string.Empty;
                    CmbAuthor.Text = string.Empty;
                    CmbCategory.Text = string.Empty;
                    CmbLanguage.Text = string.Empty;
                    RchTxtDesc.Text = string.Empty;
                    NmrPage.Value = 0;
                    NmrPrice.Value = 0;
                    MessageBox.Show("Book  is Deleted", "Delete", MessageBoxButtons.OK);

                    DGV();

                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvBook_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bookId = (int)DgvBook.Rows[e.RowIndex].Cells[0].Value;
            LblBookId.Text = bookId.ToString();
            BtnUpdate.Visible = true;
            BtnDelete1.Visible = true;
            BtnAdd.Visible = false;
            try
            {
                var book = _bookManager.GetBookById(bookId);
                TxtBookName.Text = book.Name;
                CmbAuthor.Text = book.Author.Name;
                CmbCategory.Text = book.Category.CategoryName;
                CmbLanguage.Text = book.Language.LanguageName;
                NmrPage.Value = book.Page;
                NmrPrice.Value = book.Price;
                RchTxtDesc.Text = book.Description;
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Something is wrong \n Error:" + error.Message, "Error message", MessageBoxButtons.OK);
            }
        }
    }
}
