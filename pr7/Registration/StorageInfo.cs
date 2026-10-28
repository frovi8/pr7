using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
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

            var request = read.Reg(_db);

            Console.WriteLine("Вы зарегистрировались!!\n");

            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();

            await adddb.AddToDb(request);
        }
    }
}
