using MaskShop.Data.interfaces;
using MaskShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data.mocks
{
    public class MockMasks : IAllMasks
    {
        private readonly IMasksCategory _categoryMasks = new MockCategory();
        public IEnumerable<Mask> masks
        {
            get
            {
                return new List<Mask>
                {
                    new Mask
                    {
                        name = "RedStripe",
                        shortDesc = "Маска с полосками",
                        longDesc = "Красная маска с красно-темными полосаи",
                        image = "/img/redstripes.jfif",
                        price = 290,
                        isFavorite = true,
                        available = true,
                        Category = _categoryMasks.allCategories.First()
                    },

                     new Mask
                    {
                        name = "BlueSky",
                        shortDesc = "Темно-синяя маска",
                        longDesc = "Классическая маска темно-синего цвета",
                        image = "/img/blue.jfif",
                        price = 290,
                        isFavorite = false,
                        available = true,
                        Category = _categoryMasks.allCategories.First()
                    },

                      new Mask
                    {
                        name = "Waves",
                        shortDesc = "Маска с принтом",
                        longDesc = "Маска с принтом в виде волн, стильно модно молодёжно",
                        image = "/img/bluewaves.jfif",
                        price = 450,
                        isFavorite = true,
                        available = false,
                        Category = _categoryMasks.allCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Mask> getFavMasks { get; set; }

        public Mask getObjectMask(int maskId)
        {
            throw new NotImplementedException();
        }
    }
}
