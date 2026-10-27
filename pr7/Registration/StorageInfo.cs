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
        public async Task StInfo()
        {
            var read =  new RequestData();
            var adddb = new AddToDataBase(_db);

            var request = await read.Reg(_db);

            Console.WriteLine("Вы зарегистрировались!!");

            await adddb.AddToDb(request);
        }
    }
}
