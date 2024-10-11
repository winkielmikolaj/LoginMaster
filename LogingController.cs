using LoginMaster.Migrations;
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
        public void LoggingOnTheStart()
        {
            using (var context = new MyDbContext())
            {
                Console.WriteLine("Podaj nazwę użytkownika:");
                string inputUsername = Console.ReadLine();

                Console.WriteLine("Podaj hasło:");
                string inputPassword = Console.ReadLine();

                // Sprawdzanie, czy użytkownik istnieje i czy dane logowania są poprawne
                var loggedInUser = context.Users.FirstOrDefault(u => u.Username == inputUsername && u.Password == inputPassword);

                if (loggedInUser != null)
                {
                    Console.WriteLine("Logowanie zakończone sukcesem!");

                    if ((bool)loggedInUser.IsAdmin)
                    {
                        Console.WriteLine("Witaj, Administratorze.");
                        // Kod dla administratora
                    }
                    else
                    {
                        Console.WriteLine("Witaj, Użytkowniku.");
                        // Kod dla zwykłego użytkownika
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa nazwa użytkownika lub hasło.");
                }
            }
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
