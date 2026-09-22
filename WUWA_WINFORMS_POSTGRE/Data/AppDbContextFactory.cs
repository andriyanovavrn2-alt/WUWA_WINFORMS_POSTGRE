using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace WUWA_WINFORMS_POSTGRE
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private const string ConnectionString =
    @"Host=localhost;Port=5433;Username=postgres;Password=123;Database=Wuwa_db";
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Ваша строка подключения
            optionsBuilder.UseNpgsql(
                @"Host=localhost;Port=5433;Username=postgres;Password=123;Database=Wuwa_db");

            return new AppDbContext(optionsBuilder.Options);
        }
        public static AppDbContext Create()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(ConnectionString);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
