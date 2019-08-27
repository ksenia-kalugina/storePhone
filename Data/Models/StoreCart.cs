using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorePhone.Data.Models
{
    public class StoreCart
    {
        private readonly AppDBContext appDBContext;
        public StoreCart(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public string StoreCartId { get; set; }
        public List<StoreCartItem> listStoreItems { get; set; }
        public static StoreCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContext>();
            string storeCartId = session.GetString("CartId")??Guid.NewGuid().ToString();
            session.SetString("CartId", storeCartId);
            return new StoreCart(context) { StoreCartId = storeCartId };
        }

        public void AddToCart(Phone phone, User user)
        {
            var list = getStoreItems();
            foreach(var el in list)
            {
                if(el.phone == phone && el.user==user)
                {
                    return;
                }
            }
            appDBContext.StoreCartItem.Add(new StoreCartItem
            {
                StoreCartId = StoreCartId,
                phone = phone,
                user = user
            }) ;
            appDBContext.SaveChanges();
        }


        public void RemoveToCart(Phone phone, User user)
        {
            var list = getStoreItems();
            foreach (var el in list)
            {
                if (el.phone == phone && el.user == user)
                {
                    appDBContext.StoreCartItem.Remove(el);
                    break;
                }
            }            
            appDBContext.SaveChanges();
        }

        public List<StoreCartItem> getStoreItems()
        {
            return appDBContext.StoreCartItem.Where(c => c.StoreCartId == StoreCartId).Include(s => s.phone).Include(s => s.user).ToList();
        }
    }
}