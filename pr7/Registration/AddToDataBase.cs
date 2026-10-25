using Microsoft.EntityFrameworkCore.Query.Internal;
using pr7.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class AddToDataBase
    {
        private DickieYagodkiContext _db;

        public AddToDataBase(DickieYagodkiContext db)
        {
            _db = db;
        }

        public void AddToDb(RegistrRequest request)
        {
            var user = new User
            {
                Nickname = request.Name,
                PhoneNumber = request.Number,
                Email = request.Email,
                Password = request.Password1
            };
            _db.Users.Add(user);
            _db.SaveChanges();
        }
    }
}
