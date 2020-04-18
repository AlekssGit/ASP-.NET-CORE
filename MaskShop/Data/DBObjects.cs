using MaskShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Mask.Any())
            {
                content.AddRange(
                    new Mask
                    {
                        name = "RedStripe",
                        shortDesc = "Маска с полосками",
                        longDesc = "Красная маска с красно-темными полосаи",
                        image = "/img/redstripes.jfif",
                        price = 290,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Однотонные"]
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
                         Category = Categories["Однотонные"]
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
                          Category = Categories["Принтованные"]
                      }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Однотонные", description = "Дешёвые, простые и цветные"},
                        new Category {categoryName = "Принтованные", description = "С принтами, подороже, жизнерадостные"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }

        }
    }
}
