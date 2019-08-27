using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Models
{
    public class StoreCartItem
    {
        public int id { get; set; }
        public Phone phone { get; set; }
        public string StoreCartId { get; set; }
        public User user { get; set; }
    }
}
