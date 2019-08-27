using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Models
{
    public class Phone
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFovorite { get; set; } //
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
