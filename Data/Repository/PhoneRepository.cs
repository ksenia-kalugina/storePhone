using StorePhone.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Repository
{
    public class PhoneRepository : IAllPhones
    {
        private readonly AppDBContext appDBContent;
        public PhoneRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Phone> Phones => appDBContent.Phone.Include(c => c.Category);

        public IEnumerable<Phone> getFavPhones => appDBContent.Phone.Where(p => p.isFovorite).Include(c => c.Category);

        public Phone getObjectPhone(int phoneId) => appDBContent.Phone.FirstOrDefault(p => p.id == phoneId);

    }
}
