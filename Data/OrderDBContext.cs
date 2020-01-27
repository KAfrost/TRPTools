using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRPTools.Models;

namespace TRPTools.Data
{
    public class OrderDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Glitter> Glitters { get; set; }
        public DbSet<CupType> CupTypes { get; set; }
        public object Menus { get; internal set; }
        public object CheeseMenus { get; internal set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        { }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheeseMenu>().HasKey(c => new { c.CheeseID, c.MenuID });
        }*/

    }
}
