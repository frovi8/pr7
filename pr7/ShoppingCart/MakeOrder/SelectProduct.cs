using pr7.CheckEntry;
using pr7.LogIn;
using pr7.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace pr7.ShoppingCart.MakeOrder
{
    internal class SelectProduct
    {
        private readonly DickieYagodkiContext _db;

        public SelectProduct(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void Select()
        {
            int input = CheckType.CheckInt("Введите ID товара, который хотите добавить в корзину: ");

            var c = _db.ProductInCarts.FirstOrDefault(u => u.ProductId == input);

            if (c != null)
            {
                Console.Clear();
                SelectPvz selectPvz = new (_db);
                var n = selectPvz.ChoosingPvz();
                Console.Clear();

                if (n != null)
                {
                    Order order = new()
                    {
                        UserId = CurrentUser.CurrUsr.UserId,
                        PvzId = n.PvzId,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Orders.Add(order);
                    _db.SaveChanges();

                    Console.WriteLine("Товар добавлен в корзину!");
                    Console.WriteLine();
                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }
    }
}
