using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class StorageInfo
    {
        private DickieYagodkiContext _db;
        public StorageInfo(DickieYagodkiContext db)
        {
            _db = db;
        }
        public void StInfo()
        {
            var read =  new RequestData();
            var check = new CheckInfo();
            var adddb = new AddToDataBase(_db);

            var request = read.Reg();
            check.MainCheck(request);
            adddb.AddToDb(request);

            Console.WriteLine("Вы зарегистрировались!!");
        }
    }
}
