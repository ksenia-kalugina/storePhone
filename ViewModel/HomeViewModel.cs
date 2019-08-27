using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Phone> favPhones { get; set; }
    }
}
