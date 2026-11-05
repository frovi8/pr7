using pr7.CheckEntry;
using pr7.LogIn;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace pr7.Products
{
    internal class ProductRouter
    {
        private readonly DickieYagodkiContext _db;

        public ProductRouter(DickieYagodkiContext db)
        {
            _db = db;
        }

        public async Task Rout()
        {
            Console.WriteLine("Добавить один товар в корзину - 1");
            Console.WriteLine("Вернуться в главное меню - 2");
            string input = CheckType.CheckString("Выберите действие: ");

            switch (input)
            {
                case "1":
                    AddProductToCart addProductToCart = new(_db);
                    await addProductToCart.AddProduct();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите 1 или 2.");
                    break;
            
            }
        }
    }
}
