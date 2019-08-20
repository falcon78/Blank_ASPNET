using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using bProject_ASPNET.Models;
using bProject_ASPNET.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Http;

namespace bProject_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDatabase _userDatabase;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IUserDatabase userDatabase, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            _userDatabase = userDatabase;
        }

        public ViewResult Index()
        {
            //    User result = _userDatabase.GetUser(1);
            //    return new ObjectResult(result);
            IEnumerable<User> allUsers = _userDatabase.GetAllUsers();
            return View("ViewAllUsers", allUsers);
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
        public IActionResult Create(CreateViewModel user)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (user.Photos != null && user.Photos.Count > 0)
                {
                    foreach (IFormFile photo in user.Photos)
                    {
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }

                User newUser = new User
                {
                    Name = user.Name,
                    Email = user.Email,
                    UserHobby = user.UserHobby,
                    PhotoPath = uniqueFileName
                };

                _userDatabase.Add(newUser);

                return RedirectToAction("UserDetails", new { id = newUser.ID });
            }

            return View();
        }

        [HttpGet]
        public ViewResult Edit (int id)
        {
            User user = _userDatabase.GetUser(id);
            UserEditViewModel userEdit = new UserEditViewModel
            {
                ID = user.ID,
                Name = user.Name,
                Email = user.Name,
                UserHobby = user.UserHobby,
                ExistingPhotoPath = user.PhotoPath
            };
            return View(userEdit);
        }

        
    }
}
