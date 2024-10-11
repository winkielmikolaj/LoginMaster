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
