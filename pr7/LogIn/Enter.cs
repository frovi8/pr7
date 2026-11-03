using Microsoft.EntityFrameworkCore;
using pr7.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.LogIn
{
    internal class Enter
    {
        public async static Task SignIn(string login, string password, DickieYagodkiContext db)
        {

            var user = await db.Users.FirstOrDefaultAsync(u => (u.PhoneNumber == login || u.Email == login) && u.Password == password);

            if (user != null)
            {
                CurrentUser.CurrUsr = user;
                Console.WriteLine("Вы вошли в аккаунт!");
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль");
            }

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        
    }
}
