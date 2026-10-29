using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Login
{
    internal class Enter
    {
        public static string? auth = null;
        public async static Task SignIn(string login, string password, DickieYagodkiContext db)
        {
            if (await db.Users.AnyAsync(u => (u.PhoneNumber == login || u.Email == login) && u.Password == password))
            {
                auth = login;
                Console.WriteLine("Вы вошли в аккаунт!");
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль");
            }
            
        }

        
    }
}
