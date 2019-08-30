using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StorePhone.Data.Interfaces;
using StorePhone.Data.Models;
using StorePhone.ViewModel;

namespace StorePhone.Controllers
{
    [Authorize]
    [Route("api/phones")]
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _phoneCategory;

        public PhoneController(IAllPhones _allPhones, IPhonesCategory _phoneCategory)
        {
            this._allPhones = _allPhones;
            this._phoneCategory = _phoneCategory;

        }
        //[Authorize]
        //[Route("Phone/List")]
        //[Route("Phone/List/{category}")]
        //public ViewResult List(string category)
        //{

        //    string _category = category;
        //    IEnumerable<Phone> phones = null;
        //    string currCategory = "";
        //    if (string.IsNullOrEmpty(category))
        //    {
        //        phones = _allPhones.Phones.OrderBy(i => i.id);
        //    }
        //    else
        //    {
        //        if (string.Equals("smartphone", category, StringComparison.OrdinalIgnoreCase))
        //        {
        //            phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("Смартфон"));
        //            currCategory = "Смартфоны";
        //        }
        //        else if (string.Equals("usualphone", category, StringComparison.OrdinalIgnoreCase))
        //        {
        //            phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("Не смартфон"));
        //            currCategory = "Обычные телефоны";
        //        }

        //    }
        //    var phoneObj = new PhoneListViewModel
        //    {
        //        allPhones = phones,
        //        currCategory = currCategory
        //    };

        //    ViewBag.Title = "Интернет магазин";


        //    return View(phoneObj);
        //}


        //[Authorize]
        //[Route("Phone/Detail/{phoneID}")]
        //public IActionResult Detail(int phoneID)
        //{
        //    Phone item = _allPhones.getObjectPhone(phoneID);

        //    return View(item);

        //}

        [HttpGet("allphones")]
        public IEnumerable<Phone> Get()
        {

            return _allPhones.Phones.OrderBy(i => i.id);
        }

        [HttpGet("{id}")]
        public Phone Get(int id)
        {
            Phone phone = _allPhones.Phones.FirstOrDefault(x => x.id == id);
            return phone;
        }

        [HttpGet("favorite")]

        public IEnumerable<Phone> GetFavorites()
        {
            return _allPhones.getFavPhones.ToList();
        }
        [HttpGet("smartphone")]
        public IEnumerable<Phone> GetSmartphoneList()
        {

            return _allPhones.Phones.Where(i => i.Category.categoryName.Equals("Смартфон")).OrderBy(i => i.id);
        }

        [HttpGet("usualphone")]
        public IEnumerable<Phone> GetUsualphoneList()
        {

            return _allPhones.Phones.Where(i => i.Category.categoryName.Equals("Не смартфон")).OrderBy(i => i.id);
        }

        
    }
}