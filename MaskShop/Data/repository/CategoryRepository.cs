using MaskShop.Data.interfaces;
using MaskShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.repository
{
    public class CategoryRepository : IMasksCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> allCategories => appDBContent.Category;
    }
}
