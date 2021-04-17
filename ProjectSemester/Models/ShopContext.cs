using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSemester.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<WeaponModel> Weapons { get; set; }
        public DbSet<AmmoModel> Ammo { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base (options)
        {
            Database.EnsureCreated(); 
        }
    }
}
