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
                throw new Exception("Не удалось подключиться к базе данных. Проверьте настройки подключения.");
            }
        }
    }
}
