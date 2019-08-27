using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Interfaces
{
    public interface IAllPhones
    {
        IEnumerable<Phone> Phones { get; }
        IEnumerable<Phone> getFavPhones { get; }
        Phone getObjectPhone(int phoneId);
    }
}
