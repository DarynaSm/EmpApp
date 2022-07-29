using System;
using Test.Data;
using Test.Models;

namespace Test.Services
{
    public class ViewModelService
    {
        private readonly DbService _dbService;

        public ViewModelService(DbService dbService)
        {
            _dbService = dbService;
        }

        public ApplicationUserViewModel ApplicationUserToViewModel(int id)
        {
            var user = _dbService.GetApplicationUserById(id);
            var userViewModel = new ApplicationUserViewModel
            {
                UserName = user.UserName,
                Age = user.Age.ToString(),
                City = user.City,
                PhoneNumber = user.PhoneNumber,
            };

            foreach (var i in user.Resumes)
            {
                userViewModel.Resumes.Add(i);
            }
            return userViewModel;
        }

    }
}
