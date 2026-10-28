using pr7.CheckTypes;
using pr7.Products;
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
        public async Task StartMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в DickieYagodki!");
                Console.WriteLine("1. Зарегистрироваться");
                Console.WriteLine("2. Войти");
                Console.WriteLine("3. Просмотр товаров");
                Console.WriteLine("0. Выход");
                var input = CheckType.CheckString("Выберите действие: ");
                Console.Clear();
                switch (input)
                {
                    case "1":
                        var storageInfo = new StorageInfo(_db);
                        await storageInfo.StInfo();
                        break;
                    case "2":

                        break;
                    case "3":
                        PrintProduct pp = new (_db);
                        await pp.Print();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                        break;
                }
            }
        }

        
    }
}
