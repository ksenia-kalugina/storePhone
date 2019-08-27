using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorePhone.Data.Interfaces;
using StorePhone.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace StorePhone.Controllers
{
    
    public class HomeController : Controller
    {
        private IAllPhones _phoneRep;

        public HomeController(IAllPhones phoneRep)
        {
            _phoneRep = phoneRep;
        }
        [Authorize]
        public IActionResult Index()
        {

            //return Content(User.Identity.Name);
            var homePhones = new HomeViewModel
            {
                favPhones = _phoneRep.getFavPhones

            };
            return View(homePhones);
        }
    }
}