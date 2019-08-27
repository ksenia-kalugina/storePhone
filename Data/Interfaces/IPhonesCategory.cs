using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Interfaces
{
    public interface IPhonesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
