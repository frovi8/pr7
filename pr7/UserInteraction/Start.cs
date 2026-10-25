using pr7.CheckTypes;
using pr7.Registration;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.UserInteraction
{
    internal class Start
    {
        private readonly DickieYagodkiContext _db;

        public Start(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void StartMenu()
        {
            Console.WriteLine("Добро пожаловать в DickieYagodki!");
            Console.WriteLine("1. Зарегистрироваться");
            Console.WriteLine("2. Войти");
            Console.WriteLine("3. Просмотр товаров");
            Console.WriteLine("4. Выход");
            var input = CheckType.CheckString("Выберите действие: ");
            switch (input)
            {
                case "1":
                    var storageInfo = new StorageInfo(_db);
                    storageInfo.StInfo();
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    StartMenu();
                    break;
            }
        }

        
    }
}
