using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSemester.Models; 

namespace ProjectSemester.Models
{
    public class DbInitialize
    {
        public static void Initialize (ShopContext context)
        {
            if(!context.Weapons.Any())
            {
                context.Weapons.AddRange(
                    new WeaponModel
                    {
                        name = "AK-12",
                        calibr = "5.45x39",
                        description = "AK-12 для граждансокого рынка",
                        price = 200000,
                        categoryId = 1,
                        rifle = true
                    });
                context.SaveChanges(); 
            }
        }
    }
}
