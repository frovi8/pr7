using pr7.CheckEntry;
using pr7.ShoppingCart.MakeOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.ShoppingCart
{
    internal class CartRouter
    {
        private readonly DickieYagodkiContext _db;

        public CartRouter(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void Rout()
        {
            Console.WriteLine("Выбрать товар для покупки - 1");
            Console.WriteLine("Выбрать все товары для покупки - 2");
            Console.WriteLine("Отчистить корзину - 3");
            Console.WriteLine("В главное меню - 0");
            var z = CheckType.CheckString("Ваш выбор: ");

            switch (z)
            {
                case "1":
                    SelectProduct selectProduct = new (_db);
                    selectProduct.Select();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Некорректное значение");
                    break;
            }
        }
    }
}
