using pr7.CheckEntry;
using pr7.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.ShoppingCart.MakeOrder
{
    internal class SelectPvz
    {
        private readonly DickieYagodkiContext _db;

        public SelectPvz(DickieYagodkiContext db)
        {
            _db = db;
        }

        public void PrintPvz()
        {
            foreach (var pvz in _db.Pvzs)
            {
                Console.WriteLine($"Адрес: {pvz.Adress}, занято: {pvz.WorkLoad}/{pvz.Capacity} (ID: {pvz.PvzId})");
            }
            Console.WriteLine();
        }
        public Pvz ChoosingPvz()
        {
            PrintPvz();

            int input = CheckType.CheckInt("Введите ID ПВЗ, куда хотите заказать товар: ");

            var c = _db.Pvzs.FirstOrDefault(u => u.PvzId == input);

            if (c != null)
            {
                return c;

            }
            else
            {
                return null!;
            }

        }
    }
}
