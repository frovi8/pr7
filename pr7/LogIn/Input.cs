using pr7.CheckEntry;
using pr7.Login;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.LogIn
{
    internal class Input
    {
        private DickieYagodkiContext _db;
        public Input(DickieYagodkiContext db)
        {
            _db = db;
        }
        public async Task UserInput()
        {
            string login;
            string password;

            while (true)
            {    
                var input = CheckType.CheckString("Введите почту или номер телефона: ");

                if (CheckInfo.CheckEmail(input))
                {
                    login = input;
                    break;
                }
                else if (CheckInfo.CheckNumber(input))
                {
                    login = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод логина");
                }

            }

            password = CheckType.CheckString("Введите пароль: ");

            await Enter.SignIn(login, password, _db);

        }
    }
}
