using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeGarden.Core_Aplication.MyApplication;

namespace HomeGarden.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string fullName, string email, string password)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Email = email;
            Password = password;
        }
    }

}
