using pr7.CheckTypes;
using pr7.Products;
using pr7.Registration;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.UserInteraction
{
    internal class StartAfterReg
    {
        private readonly DickieYagodkiContext _db;

        public StartAfterReg(DickieYagodkiContext db)
        {
            _db = db;
        }
        public async Task StartMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Просмотр товаров");
                Console.WriteLine("2. Корзина");
                Console.WriteLine("3. Предыдущие заказы");
                Console.WriteLine("0. Выход");
                var input = CheckType.CheckString("Выберите действие: ");
                Console.Clear(); 
                switch (input)
                {
                    case "1":
                        PrintProduct pp = new (_db);
                        await pp.Print();
                        break;
                    case "2":

                        break;
                    case "3":

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
