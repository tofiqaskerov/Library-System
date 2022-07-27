using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryManager
    {
        AppDbContext _context = new();

        public IQueryable<Category> GetAllCategorie()
        {
            return _context.Categories;
        }
        public List<Category> GetCategories()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }
        public Category GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryName == name);
            return category;
        }
        public void AddCategory( Category category)
        {
            _context.Categories.Add(category); 
            _context.SaveChanges();
        }
    }
}
