using System;
using System.Collections.Generic;
using System.Text;

namespace pr7
{
    internal class CheckConnection
    {
        private DickieYagodkiContext _db;

        public CheckConnection(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void CheckConn()
        {
            
            if (!_db.Database.CanConnect())
            {
                Console.WriteLine("Ошибка: не удалось подключиться к базе данных DickieYagodki!");
                return;
            }
            Console.WriteLine("Успешное подключение к базе данных!\n");
        }
    }
}
