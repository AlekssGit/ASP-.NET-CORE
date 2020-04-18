using MaskShop.Data.interfaces;
using MaskShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.repository
{
    public class MaskRepository : IAllMasks
    {
        private readonly AppDBContent appDBContent;

        public MaskRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Mask> masks => appDBContent.Mask.Include(c => c.Category);

        public IEnumerable<Mask> getFavMasks => appDBContent.Mask.Where(p => p.isFavorite).Include(c => c.Category);

        public Mask getObjectMask(int maskId) => appDBContent.Mask.FirstOrDefault(p => p.id == maskId);
    }
}
