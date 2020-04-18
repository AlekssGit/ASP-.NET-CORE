using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int maskId { get; set; }

        public uint price { get; set; }

        public virtual Mask mask { get; set; }

        public virtual Order order { get; set; }

    }
}
