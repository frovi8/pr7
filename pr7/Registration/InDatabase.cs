using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    internal class InDatabase
    {
        public static bool Email(string email, DickieYagodkiContext db)
        {
            if (db.Users.Any(u => u.Email == email))
            {
                return false;
            }
            return true;
        }
        public static bool Phone(string phone, DickieYagodkiContext db)
        {
            if (db.Users.Any(u => u.PhoneNumber == phone))
            {
                return false;
            }
            return true;
        }
    }
}
