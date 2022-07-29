using System;
using System.Collections.Generic;
using Test.Data;
using Test.Models;

namespace Test.Services
{
    public class AccountService
    {
        private List<ApplicationUser> UsersList = new List<ApplicationUser>();
        private readonly ApplicationDbContext _context;
        public AccountService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser CreateUser(RegisterViewModel model)
        {
            var newUser = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Name,
                City = model.City,
                Age = model.Age,
                PhoneNumber = model.PhoneNumber,
                Resumes = null,
            };
            return newUser;
        }

        public void AddNewUserToDb(ApplicationUser newUser)
        {
            //_context.Users.Add(newUser);
            //_context.SaveChanges();
            UsersList.Add(newUser);
        }
    }
}
