using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class User : Base
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
        public Role Role  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string FinCode { get; set; }
        public bool IsDeleted { get; set; }
        public int Limit { get; set; }


    }
}
