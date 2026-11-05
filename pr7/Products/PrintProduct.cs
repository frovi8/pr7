using pr7.CheckEntry;
using pr7.LogIn;
using pr7.Registration;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Products
{
    internal class PrintProduct
    {
        private readonly DickieYagodkiContext _db;

        public PrintProduct(DickieYagodkiContext db)
        {
            _db = db;
        }

        public async Task Print()
        {
            await foreach (var i in _db.Products)
            {
                Console.WriteLine($"{i.Name} - {i.Price} руб (id: {i.ProductId})"); 
            }

            if (CurrentUser.CurrUsr == null)
            {
                Console.WriteLine();
                Console.WriteLine("Чтобы добавить товар в корзину, необходимо войти в систему.");
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            
            ProductRouter askUser = new(_db);
            await askUser.Rout();
        }
    }
}
