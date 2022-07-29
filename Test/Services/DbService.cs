using System;
using System.Linq;
using Test.Data;
using Test.Models;

namespace Test.Services
{
    public class DbService
    {
        private readonly ApplicationDbContext _context;

        public DbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser GetApplicationUserById (int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id.ToString());
            return user;
        }
    }
}
