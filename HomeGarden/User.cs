using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeGarden.MyApplication;

namespace HomeGarden
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string fullname, string email, string password)
        {
            FullName = fullname;
            Email = email;
            Password = password;
        }
    }

}
