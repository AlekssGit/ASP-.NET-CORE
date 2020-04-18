using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.Models
{
    /// <summary>
    /// Категория товаров
    /// </summary>
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }

        public List<Mask> masks { set; get; }

    }
}
