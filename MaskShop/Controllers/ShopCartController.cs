using MaskShop.Data.interfaces;
using MaskShop.Data.Models;

using MaskShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly IAllMasks _maskRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllMasks maskRep, ShopCart shopCart)
        {
            _maskRep = maskRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _maskRep.masks.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
