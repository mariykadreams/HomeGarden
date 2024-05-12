using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeGarden.MyApplication;

namespace HomeGarden
{
    public class User(string fullname, string email, string password)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FullName { get; set; } = fullname;
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;
    }
}
