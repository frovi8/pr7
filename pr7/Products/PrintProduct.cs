using pr7.CheckTypes;
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
                Console.WriteLine($"{i.Name} - {i.Price} руб");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
