using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserManager
    {
        AppDbContext _context = new();
        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x =>x.Email == email );
        }
        public User GetByFinCode(string finCode)
        {
            var finnCode = _context.Users.FirstOrDefault(x => x.FinCode == finCode);
            return finnCode;
        }

        public List<Role> GetAllRoles()
        {
            var role = _context.Roles.Where(x => x.Id >= 2).ToList();
            return role;
        }
        public Role GetRoleByName(string roleName)
        {
            var role = _context.Roles.FirstOrDefault(x => x.RoleName ==roleName);
            return role;
        }
        public User GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        public void UpdateUser( User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            user.IsDeleted = true;
            _context.Users.Update(user);
            _context.SaveChanges(); 
        }
        public IQueryable<User> GetAllUser()
        {
            
            return _context.Users;
        }
        
        public void Register(User user )
        {
          
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public string PasswordHash(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder returnPassword = new();
            for(int i=0; i<hash.Length; i++)
            {
                returnPassword.Append(hash[i].ToString("x2"));
            }
            return returnPassword.ToString();
        }
    }
}
