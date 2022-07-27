using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Book : Base
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool Rent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateTime { get; set; }  
    }
}
