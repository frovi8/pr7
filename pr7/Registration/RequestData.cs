using pr7.CheckEntry;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class RequestData
    {       
        public RegistrRequest Reg(DickieYagodkiContext db)
        {
            var name = CheckType.CheckString("Введите имя: ");

            var email = CheckEmail(db);

            var number = CheckNumber(db);

            var password = CheckPassword();

            //AllNuzhnosti allNuzhnosti = new AllNuzhnosti(name, login, email, number, password1, password2);
            //CheckInfo checkInfo = new CheckInfo(name, login, email, number, password1, password2);
            //checkInfo.MainCheck();
            //StorageInfo.Info = allNuzhnosti;

            return new RegistrRequest(name, email, number, password);
        }

        private static string CheckEmail(DickieYagodkiContext db)
        {

            while (true)
            {
                var email = CheckType.CheckString("Введите адрес электронной почты: ");

                if (InDatabase.Email(email, db))
                    if (CheckInfo.CheckEmail(email))
                    {
                        return email;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный адрес электронной почты");
                    }
                else
                {
                    Console.WriteLine("Email уже зарегистрирован!");
                }

            }
        }

        private static string CheckNumber(DickieYagodkiContext db)
        {

            while (true)
            {
                var name = CheckType.CheckString("Введите номер телефона: ");

                if (InDatabase.Phone(name, db))
                    if (CheckInfo.CheckNumber(name))
                    {
                        return name;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер телефона");
                    }
                else
                {
                    Console.WriteLine("Номер телефона уже зарегистрирован!");
                }
            }
        }

        private static string CheckPassword()
        {
            while (true)
            {
                var password1 = CheckType.CheckString("Введите пароль: ");
                var password2 = CheckType.CheckString("Повторите пароль: ");

                if (CheckInfo.CheckPassword(password1, password2))
                {
                    return password1;
                }

                Console.WriteLine("Пароли не совпадают");
            }
        }
    }
}
