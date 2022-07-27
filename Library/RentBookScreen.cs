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
    public partial class RentBookScreen : Form
    {

        BookManager _bookManager = new();
        UserManager _userManager = new();
        public RentBookScreen()
        {
            InitializeComponent();
        }

      

        private void RentBookScreen_Load(object sender, EventArgs e)
        {
            LblUserId.Text = Form1.SendId;
            //var userID = Convert.ToInt32(LblUserId.Text);
            var books = _bookManager.GetAllBook();
            foreach (var book in books)
            {
                CmbBooks.Items.Add(book.Name);
            }


            //var dbCount = _bookManager.BookCount();
            //LblDbCount.Text = dbCount.ToString();
            DGV();
        }
        public void DGV()
        {
            var userID = Convert.ToInt32(LblUserId.Text);
            var allBook = _bookManager.GetUserBook().Where(user =>user.UserId == userID ).Select(book => new
            {
                Id = book.Id,
                Name = book.Book.Name,
                Page = book.Book.Page,
                Price = book.Book.Price,
                Description = book.Book.Description,
                Rent  = book.Book.Rent
            }).ToList();
            DgvBook.DataSource = allBook;
        }

        int limit = 1;
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            
            var bookName = CmbBooks.Text;
            var checkBook = _bookManager.GetBook(bookName) ;
            
            if(checkBook.IsDeleted == true)
            {
                MessageBox.Show("Bu Kitab Bazada yoxdur", "Error" );
            }
            else
            {
                if(checkBook.Rent == true)
                {
                    MessageBox.Show("Bu Kitab kiraye goturulub", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        
                        var userId = Convert.ToInt32(LblUserId.Text);
                        var user = _userManager.GetUserById(userId);

                       
                        user.Limit += limit;
                        _userManager.UpdateUser(user);
                        if(user.Limit > 3)
                        {
                            MessageBox.Show("Limit dolub", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //var books = _bookManager.GetAllBook();
                            //foreach (var book in books)
                            //{
                            //    CmbBooks.Items.Add(book.Name);
                            //}

                            var bookId = checkBook.Id;
                            UserBook _userBook = new()
                            {
                                UserId = userId,
                                BookId = bookId,

                            };
                            checkBook.Rent = true;
                            checkBook.DateTime = DateTime.Now;

                            _bookManager.Update(checkBook);
                            _bookManager.RentBook(_userBook);
                            MessageBox.Show("The book was ordered", "Completed", MessageBoxButtons.OK);
                            DGV();
                            
                        }
                        

                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Something is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
        }
    }
}
