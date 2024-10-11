using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaster
{
    internal class User
    {
        public int Id { get; private set; }
        public string? Username {  get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public bool? IsAdmin { get; set; }

        public User() //default constructor
        {
            
        }

        public User(string username, string password, string email, bool isAdmin)
        {
            Username = username;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }
    }
}
