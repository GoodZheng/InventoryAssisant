using InventoryAssisant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssisant.DataBase
{
    public class AppDbContext:DbContext
    {

        /// <summary>
        /// A list of all the items in the database.
        /// </summary>
        public DbSet<Item> Items { get; set; }


        /// <summary>
        /// A list of all the categories in the database.
        /// </summary>
        public DbSet<ItemCategory> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var configuration = configBuilder.Build();
            var connStr = configuration["DbContext:MySQLConnectionString"];

            optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));

        }

        //加载当前程序集中所有的实现了IEntityTypeConfiguration的类 加载配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
