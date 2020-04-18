using MaskShop.Data.interfaces;
using MaskShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.mocks
{
    public class MockCategory : IMasksCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Однотонные", description = "Дешёвые, простые и цветные"},
                    new Category {categoryName = "Принтованные", description = "С принтами, подороже, жизнерадостные"}
                };
            }
        }
    }
}
