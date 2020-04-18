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
    public class MasksController: Controller
    {
        private readonly IAllMasks _allMasks;
        private readonly IMasksCategory _allCategories;

        public MasksController (IAllMasks iAllMasks, IMasksCategory iMasksCategory)
        {
            _allMasks = iAllMasks;
            _allCategories = iMasksCategory;
        }

        [Route("Masks/List")]
        [Route("Masks/List/{category}")]
        public ViewResult list(string category)
        {
            string _category = category;
            IEnumerable<Mask> masks=null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                masks = _allMasks.masks.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("monotone",category, StringComparison.OrdinalIgnoreCase))
                {
                    masks = _allMasks.masks.Where(i => i.Category.categoryName.Equals("Однотонные")).OrderBy(i => i.id);
                    currCategory = "Однотонные";
                }
                
                else if (string.Equals("printed", category, StringComparison.OrdinalIgnoreCase))
                {
                    masks = _allMasks.masks.Where(i => i.Category.categoryName.Equals("Принтованные")).OrderBy(i => i.id);
                    currCategory = "Принтованные";
                }

                               
            }

            var maskObj = new MasksListViewModel
            {
                getAllMasks = masks,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с масками";
            return View(maskObj);
        }
    }
}
