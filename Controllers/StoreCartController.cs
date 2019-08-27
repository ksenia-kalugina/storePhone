using Microsoft.AspNetCore.Mvc;
using StorePhone.Data.Interfaces;
using StorePhone.ViewModel;
using System;
using StorePhone.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using StorePhone.Data;

namespace StorePhone.Controllers
{
    namespace StorePhone.Controllers
    {
        [Authorize]
        [Route("api/storecart")]
        public class StoreCartController : Controller
        {
            private readonly IAllPhones _phoneRep;
            private readonly IAllUsers _userRep;
            private readonly StoreCart _storeCart;
            private AppDBContext db;
            public StoreCartController(IAllPhones phoneRepository, IAllUsers userRepository, StoreCart storeCart, AppDBContext context)
            {
                _phoneRep = phoneRepository;
                _storeCart = storeCart;
                _userRep = userRepository;
                db = context;
            }
            //public ViewResult Index()
            //{
            //    var items = _storeCart.getStoreItems();
            //    _storeCart.listStoreItems = items;

            //    var obj = new StoreCartViewModel
            //    {
            //        storeCart = _storeCart
            //    };

            //    return View(obj);
            //}

            //public RedirectToActionResult addToCart(int idPhone, string nameUser)
            //{
            //    var user = _userRep.Users.FirstOrDefault(с => с.Email == nameUser);
            //    var phone = _phoneRep.Phones.FirstOrDefault(i => i.id == idPhone);
            //    if (user != null && phone!=null)
            //    {
            //        _storeCart.AddToCart(phone, user);
            //    }
            //    return RedirectToAction("Index");
            //}

            //public RedirectToActionResult removeToCart(int idPhone, string nameUser)
            //{
            //    var user = _userRep.Users.FirstOrDefault(с => с.Email == nameUser);
            //    var phone = _phoneRep.Phones.FirstOrDefault(i => i.id == idPhone);
            //    if (user != null && phone != null)
            //    {
            //        _storeCart.RemoveToCart(phone, user);
            //    }
            //    return RedirectToAction("Index");
            //}

            [HttpGet("getStoreCartList")]
            public IEnumerable<StoreCartItem> GetCartItems()
            {
                var items = _storeCart.getStoreItems().Where(c => c.user.Email == this.User.Identity.Name).ToList();
                _storeCart.listStoreItems = items;

                var obj = new StoreCartViewModel
                {
                    storeCart = _storeCart
                };

                //db.StoreCartItem.ToList();

                return items;
            }

            [HttpPost("addItemInStoreCart")]
            public async Task<IActionResult> addToCart([FromBody]int idPhone)
            {
                string nameUser =  this.User.Identity.Name;
                var user = _userRep.Users.FirstOrDefault(с => с.Email == nameUser);
                var phone = _phoneRep.Phones.FirstOrDefault(i => i.id == idPhone);
                if (user != null && phone != null)
                {
                    _storeCart.AddToCart(phone, user);
                }
                return Ok();
            }
            [HttpPost("deleteItemInStoreCart")]
            public async Task<IActionResult> removeToCart([FromBody]int idPhone)
            {
                string nameUser = this.User.Identity.Name;
                var user = _userRep.Users.FirstOrDefault(с => с.Email == nameUser);
                var phone = _phoneRep.Phones.FirstOrDefault(i => i.id == idPhone);
                if (user != null && phone != null)
                {
                    _storeCart.RemoveToCart(phone, user);
                }
                return Ok();
            }
        }
    }
}
