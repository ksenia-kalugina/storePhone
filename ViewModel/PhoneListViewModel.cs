using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.ViewModel
{
    public class PhoneListViewModel
    {
        public IEnumerable<Phone> allPhones { get; set; }
        public string currCategory { get; set; }
    }
}
