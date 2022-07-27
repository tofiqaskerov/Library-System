using Business;
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
    public partial class ReturnBookScreen : Form
    {
        BookManager _bookManager = new();
        public ReturnBookScreen()
        {
            InitializeComponent();
        }

        private void ReturnBookScreen_Load(object sender, EventArgs e)
        {
            LblUserId.Text = Form1.SendId;
            DGV();
        }

        public void DGV()
        {
            var userID = Convert.ToInt32(LblUserId.Text);
            var allBook = _bookManager.GetUserBook().Where(user => user.UserId == userID).Select(book => new
            {
                Id = book.Id,
                Name = book.Book.Name,
                Page = book.Book.Page,
                Price = book.Book.Price,
                Description = book.Book.Description,
                Rent = book.Book.Rent
            }).ToList();
            DgvRentBook.DataSource = allBook;
        }

        private void DgvRentBook_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bookId = (int)DgvRentBook.Rows[e.RowIndex].Cells[0].Value;
            LblClickId.Text = bookId.ToString();
            BtnConfirm.Visible = true;

        }
    }
}
