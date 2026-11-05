using Microsoft.EntityFrameworkCore;
using pr7.LogIn;
using pr7.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace pr7.ShoppingCart
{
    internal class PrintCart
    {
        private readonly DickieYagodkiContext _db;

        public PrintCart(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void Print()
        {
            var c = _db.Carts.FirstOrDefault(u => u.UserId == CurrentUser.CurrUsr!.UserId);

            if (c == null)
            {
                Console.WriteLine("Корзина пуста или не найдена.");
                return;
            }

            var items = _db.ProductInCarts.Include(u => u.Product).Where(u => u.CartId == c.CartId).ToList();

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Product.Name} - Количество {item.Quantity}");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();  
        }
    }
}
