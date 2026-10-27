using pr7.CheckTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class RequestData
    {       
        public async Task<RegistrRequest> Reg(DickieYagodkiContext db)
        {
            var check = new CheckInfo();

            var name = CheckType.CheckString("Введите имя: ");

            var email = CheckEmail(check, db);

            var number = CheckNumber(check, db);

            var password = CheckPassword(check);

            //AllNuzhnosti allNuzhnosti = new AllNuzhnosti(name, login, email, number, password1, password2);
            //CheckInfo checkInfo = new CheckInfo(name, login, email, number, password1, password2);
            //checkInfo.MainCheck();
            //StorageInfo.Info = allNuzhnosti;

            return new RegistrRequest(name, email, number, password);
        }

        private static string CheckEmail(CheckInfo check, DickieYagodkiContext db)
        {

            while (true)
            {
                var email = CheckType.CheckString("Введите адрес электронной почты: ");

                if (InDatabase.Email(email, db))
                    if (check.CheckEmail(email))
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

        private static string CheckNumber(CheckInfo check, DickieYagodkiContext db)
        {

            while (true)
            {
                var name = CheckType.CheckString("Введите номер телефона: ");

                if (InDatabase.Phone(name, db))
                    if (check.CheckNumber(name))
                    {
                        return name;
                    }

                Console.WriteLine("Некорректный номер телефона");
            }
        }

        private static string CheckPassword(CheckInfo check)
        {

            while (true)
            {
                var password1 = CheckType.CheckString("Введите пароль: ");
                var password2 = CheckType.CheckString("Повторите пароль: ");

                if (check.CheckPassword(password1, password2))
                {
                    return password1;
                }

                Console.WriteLine("Пароли не совпадают");
            }
        }
    }
}
