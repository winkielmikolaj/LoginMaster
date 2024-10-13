using LoginMaster.Migrations;
using Npgsql.Internal;
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
            var program = new Program();

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
                    Console.Clear();

                    string welcomeMessage = $"Witaj {loggedInUser.Username}! Co chcesz dzisiaj zrobić?";
                    int centerX = (Console.WindowWidth - welcomeMessage.Length) / 2; // Pozycjonowanie
                    Console.SetCursorPosition(centerX, Console.CursorTop);
                    Console.WriteLine(welcomeMessage); // Wyświetlenie powitania


                    Console.WriteLine("Logowanie zakończone sukcesem!");

                    if ((bool)loggedInUser.IsAdmin)
                    {
                        Program.WholeAdminMenuOperation();
                        // Kod dla administratora
                    }
                    else
                    {
                        Program.WholeUserOpeation();
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
