using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.Models
{
    /// <summary>
    /// id - identificator of product
    /// name - name of product
    /// shortDesc - short description
    /// longDesc - long desription
    /// image - URL of image
    /// price
    /// isFavorite - if true, then it will show on main page
    /// available - available products
    /// categoryId
    /// Category - object of Category
    /// </summary>
    public class Mask
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string image { set; get; }
        public ushort price { set; get; }
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
