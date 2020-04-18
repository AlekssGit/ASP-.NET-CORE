using MaskShop.Data.interfaces;
using MaskShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Controllers
{
    public class HomeController: Controller
    {
        private readonly IAllMasks _maskRep;

        public HomeController(IAllMasks maskRep)
        {
            _maskRep = maskRep;
        }

        public  ViewResult Index()
        {
            var homeMasks = new HomeViewModel
            {
                favMasks=_maskRep.getFavMasks
            };
            return View(homeMasks);
        }
    }
}
