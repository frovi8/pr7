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

        public async Task AddToDb(RegistrRequest request)
        {
            var user = new User
            {
                Nickname = request.Name,
                PhoneNumber = request.Number,
                Email = request.Email,
                Password = request.Password
            };
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
        }
    }
}
