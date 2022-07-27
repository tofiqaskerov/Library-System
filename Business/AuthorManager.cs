using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    

    public class AuthorManager 
    {
        AppDbContext _context = new();


        public IQueryable<Author> GetAllAuthor()
        {
            return _context.Authors;
        }
        public List<Author> GetAuthors()
        {
            var authors = _context.Authors.ToList();
            return authors;
        }
        public Author GetAuthorByName(string name)
        {
            var author = _context.Authors.FirstOrDefault(x => x.Name == name);
            return author;
        }
        public void AddAuthor( Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}
