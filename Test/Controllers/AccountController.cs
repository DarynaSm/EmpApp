using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Models;
using Test.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
            
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = _accountService.CreateUser(model);
                _accountService.AddNewUserToDb(newUser);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
