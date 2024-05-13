using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeGarden.Core_Aplication;

namespace HomeGarden.Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public Admin()
        {
            Id = Guid.NewGuid();
        }

        public Admin(string fullName, string email, string password)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Email = email;
            Password = password;
        }
    }
    public enum Role
    {
        Admin,
        SuperAdmin,
    }

}
