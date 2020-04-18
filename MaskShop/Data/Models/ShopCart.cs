using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.Models
{
    /// <summary>
    /// Корзина покупок
    /// </summary>
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }


        /// <summary>
        /// Служит для того чтобы понять, есть ли уже сессия или же нет сессии и пользователь ничего не добавлял
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static ShopCart getCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Mask mask)
        {
            appDBContent.shopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                mask = mask,
                price = mask.price
            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.shopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.mask).ToList();
        }

        
    }
}
