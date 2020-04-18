using MaskShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Mask> favMasks { get; set; }
    }
}
