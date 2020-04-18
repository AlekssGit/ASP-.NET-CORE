using MaskShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.ViewModels
{
    public class MasksListViewModel
    {
        public IEnumerable<Mask> getAllMasks { get; set; }

        public string currCategory { get; set; }
    }
}
