using StorePhone.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Repository
{
    public class UserRepository: IAllUsers
    {
        private readonly AppDBContext appDBContent;
        public UserRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<User> Users => appDBContent.Users;
    }
}
