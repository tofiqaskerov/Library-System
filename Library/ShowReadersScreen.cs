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
    public partial class ShowReadersScreen : Form
    {
        UserBookManager _userBookManager = new();
        
        public ShowReadersScreen()
        {
            InitializeComponent();
        }

        private void ShowReadersScreen_Load(object sender, EventArgs e)
        {
            DGV();
        }
        public void DGV()
        {
            var userBook = _userBookManager.GetAllUserBook().Select(userbook => new
            {
                Id = userbook.Id,
                UserName = userbook.User.Name,
                Name = userbook.Book.Name,
                Price = userbook.Book.Price,

            }).ToList();
            DgvUserBook.DataSource = userBook;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var txtSearch = TxtSearch.Text;
            var searchBook = _userBookManager.GetAllUserBookSearch(txtSearch).Select(userbook => new
            {
                Name = userbook.User.Name,
                BookName = userbook.Book.Name,


            }).ToList();
            DgvUserBook.DataSource = searchBook;
        }
    }
}
