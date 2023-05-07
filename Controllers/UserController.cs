using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Repository;
using BulkyBooksmvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksmvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginViewModel loginUser)
        {
            return RedirectToAction();
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }
    }
}