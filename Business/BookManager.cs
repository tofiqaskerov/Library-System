using DataAccess;
using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookManager
    {
        AppDbContext _context = new();
        public void AddBook( Book book )
        {
            _context.Books.Add( book ); 
            _context.SaveChanges();
        }
        public void RentBook(UserBook userBook)
        {
            
            _context.UserBooks.Add( userBook );
            _context.SaveChanges();
        }
        public  IQueryable<Book> GetAllBook()
        {
            return _context.Books.Where(x =>x.Rent == false);
        }
        public IQueryable<UserBook> GetUserBook()
        {
            return _context.UserBooks;
        }
        public Book GetBook(string bookName)
        {
            return _context.Books.FirstOrDefault(x =>x.Name == bookName) ;
        }
        public Book GetBookById( int Id )
        {
            var book = _context.Books.Include(x =>x.Author).Include(x => x.Category).Include(x => x.Language).FirstOrDefault(x => x.Id == Id);
            return book;
        }

        public List<Book> GetBookByName(string bookName)
        {
            var book = _context.Books.Where(x => x.Name.Contains(bookName)).ToList();
            return book;
        }
        
        public int BookCount()
        {

            return _context.Books.Count();

        }
        public void Update( Book book )
        {
            _context.Books.Update(book);
            _context.SaveChanges(); 
        }
        public void DeleteBook( Book book)
        {
            book.IsDeleted = true;
            _context.Books.Update( book );
            _context.SaveChanges();
        }
        public void BookRestore()
        {

        }
    }
}
