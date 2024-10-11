using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMaster
{
    internal class LogingController
    {
        public LogingController()
        {

        }

        public void AddingUsersByAdmin(string username, string password, string email, bool isAdmin)
        {
            var user = new User
            {
                Username = username,
                Password = password,
                Email = email,
                IsAdmin = isAdmin
            };

            using (var context = new MyDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }

        }

        public void DisplayingAllUsersByAdmin()
        {
            using (var context = new MyDbContext())
            {
                var users = context.Users.ToList();

                foreach (var user in users)
                {
                    Console.WriteLine($"Użytkownik o Id: {user.Id}, o nazwie {user.Username}, email {user.Email}");
                }
            }
        }


    }



}
