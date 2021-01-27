using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public static class Authenticator
    {
        public static User currentUser
        {
            get;
            private set;
        }

        public static int login(string login, string haslo)
        {
            try
            {
                currentUser = DbAdapter.getUser(login, haslo);

                Console.WriteLine(currentUser.name);
                if (currentUser == null)
                { 
                    // Nie znaleziono u¿ytkownika 
                    return 0;
                  
                }
                Navigator.navigateRoot();
                return 1;
            

            }
            catch (Exception)
            {
                return -1;
            }



            
        }
        public static void logout()
        {
            currentUser = null;
        }
    }
}
