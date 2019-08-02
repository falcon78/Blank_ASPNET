using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bProject_ASPNET.Models;

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
        public ViewResult SampleView()
        {
            return View();
        }

    }
}
