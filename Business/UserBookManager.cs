using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   
    public class UserBookManager
    {
        AppDbContext _context = new();
        public IQueryable<UserBook> GetAllUserBook()
        {
            return _context.UserBooks;
        }
        public IQueryable<UserBook> GetAllUserBookSearch(string name)
        {
            return _context.UserBooks.Where(x =>x.Book.Name == name || x.User.Name == name);
        }

    }
}
