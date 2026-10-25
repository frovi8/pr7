using pr7.CheckTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class RequestData
    {       
        public RegistrRequest Reg()
        {
            var name = CheckType.CheckString("Введите имя: ");

            var email = CheckType.CheckString("Введите адрес электронной почты: ");

            var number = CheckType.CheckString("Введите номер телефона: ");

            var password1 = CheckType.CheckString("Введите пароль: ");

            var password2 = CheckType.CheckString("Повторите пароль: ");

            //AllNuzhnosti allNuzhnosti = new AllNuzhnosti(name, login, email, number, password1, password2);
            //CheckInfo checkInfo = new CheckInfo(name, login, email, number, password1, password2);
            //checkInfo.MainCheck();
            //StorageInfo.Info = allNuzhnosti;

            return new RegistrRequest(name, email, number, password1, password2);
        }
    }
}
