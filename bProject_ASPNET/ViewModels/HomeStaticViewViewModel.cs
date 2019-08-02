using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bProject_ASPNET.Models;

namespace bProject_ASPNET.ViewModels
{
    public class HomeStaticViewViewModel
    {
        public User user { get; set; } 
        public string PageTitle { get; set; }
    }
}
