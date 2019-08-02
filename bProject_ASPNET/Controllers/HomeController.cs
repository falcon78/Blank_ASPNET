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
        private IUserDatabase _userDatabase; 
        public HomeController(IUserDatabase userDatabase)
        {
            _userDatabase = userDatabase;
        }
        public ObjectResult Index()
        {
            User result = _userDatabase.GetUser(1);
            return new ObjectResult(result);
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
        public ViewResult StaticView()
        {
            HomeStaticViewViewModel homeStaticViewViewModel = new HomeStaticViewViewModel()
            {
                user = _userDatabase.GetUser(1),
                PageTitle = "page title"
            };

            return View(homeStaticViewViewModel);
        }

    }
}
