using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WUWA_CHARACTER_OOP.Models;
using WUWA_WINFORMS_POSTGRE.Models;

namespace WUWA_WINFORMS_POSTGRE
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
        public DbSet<Weapon> Weapon { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Rarity> Rarity { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
