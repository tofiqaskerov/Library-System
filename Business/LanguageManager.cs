using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LanguageManager
    {
        AppDbContext _context = new();

        public IQueryable<Language> GetAllLanguages()
        {
            return _context.Languages;
        }
        public List<Language> GetLanguages()
        {
            var languages = _context.Languages.ToList();
            return languages;   
        }
        public Language GetLanguageByName(string name)
        {
            var language = _context.Languages.FirstOrDefault(x => x.LanguageName == name);
            return language;
        }
        public void AddLanguage( Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
        }
    }
}
