using StorePhone.Data.Interfaces;
using StorePhone.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Repository
{
    public class CategoryRepository : IPhonesCategory
    {
        private readonly AppDBContext appDBContent;
        public CategoryRepository(AppDBContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
