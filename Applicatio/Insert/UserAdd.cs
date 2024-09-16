using Domain.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Insert
{
    public class UserAdd
    {
        private readonly AcademiaContext _context;

        public UserAdd(AcademiaContext context)
        {
            _context = context;
        }

        public void AddUser(UsersProfiles usersProfiles)
        {
            _context.UsersProfiles.Add(usersProfiles);
            _context.SaveChanges();
        }


    }
}
