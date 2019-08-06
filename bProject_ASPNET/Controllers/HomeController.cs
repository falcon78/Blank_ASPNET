using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bProject_ASPNET.Models;
using bProject_ASPNET.ViewModels;

namespace bProject_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDatabase _userDatabase; 
        public HomeController(IUserDatabase userDatabase)
        {
            _userDatabase = userDatabase;
        }
        public ViewResult Index() 
        {
        //    User result = _userDatabase.GetUser(1);
        //    return new ObjectResult(result);
            IEnumerable<User> allUsers = _userDatabase.GetAllUsers();
            return View("ViewAllUsers",allUsers);

       }
        public ViewResult Details()
        {
            User model = _userDatabase.GetUser(1);
            // ViewData["PageTitle"] = "ユーザー情報";
            // ViewData["User"] = 
            ViewBag.PageTitle = "ユーザー情報";
            ViewBag.User = model;

            return View();
        }

        public ViewResult ViewAllUsers()
        {
            IEnumerable<User> allUsers = _userDatabase.GetAllUsers();
            return View(allUsers);
        }
        public ViewResult UserDetails(int id = 1)
        {
            HomeStaticViewViewModel homeStaticViewViewModel = new HomeStaticViewViewModel()
            {
                user = _userDatabase.GetUser(id),
                PageTitle = "page title"
            };

            return View(homeStaticViewViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Create (User user)
        {
            if (ModelState.IsValid)
            {
                User newUser = _userDatabase.Add(user);
                return RedirectToAction("UserDetails", new { id = newUser.ID });
            }
            return View();
        }

    }
}
