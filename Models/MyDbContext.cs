using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Project.Models;

namespace Project.Models
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            string strConnectString = configuration.GetConnectionString("DBConnectString").ToString();
            optionsBuilder.UseSqlServer(strConnectString);
        }
        public DbSet<RecordUsers> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrdersDetail> OrdersDetails { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<ProductsTags> ProductsTags { get; set; }
    }
}
