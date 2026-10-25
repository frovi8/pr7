using pr7.CheckTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class CheckInfo()
    {
        public void MainCheck(RegistrRequest request)
        {
            while (true)
            {
                if (!CheckEmail(request))
                {
                    request = request with {Email = CheckType.CheckString("Введите корректный адрес электронной почты: ")};
                    CheckEmail(request);
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                if (!CheckPassword(request))
                {
                    Console.WriteLine("Пароли не совпадают. Попробуйте снова.");
                    request = request with {Password1 = CheckType.CheckString("Введите пароль: ")};
                    request = request with {Password2 = CheckType.CheckString("Повторите пароль: ")};
                    CheckPassword(request);
                }
                else
                {
                    break;
                }
            }
        }
       
        private bool CheckEmail(RegistrRequest request)
        {
            if (request.Email.Contains('@') && request.Email.Contains('.'))
            {
                return true;
            }
            return false;
        }

        private bool CheckPassword(RegistrRequest request)
        {
            if (request.Password1 == request.Password2)
            {
                return true;
            }
            return false;
        }
    }
}
