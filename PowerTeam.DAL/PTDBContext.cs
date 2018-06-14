using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PowerTeam.Model;

namespace PowerTeam.DAL
{
    public class PTDBContext: DbContext
    {
        //public PTDBContext(DbContextOptions<PTDBContext> options)
        //: base(options)
        //{ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:testproviderserver.database.windows.net,1433;Initial Catalog=providertest;Persist Security Info=False;User ID=asplab;Password=Windows10!dfu;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<SharedItem> SharedItems { get; set; }
        public DbSet<DeliveryShareditem> DeliveryShareditems { get; set; }
        public DbSet<DeliveryTag> DeliveryTags { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WorkHour> WorkHours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DeliveryShareditem>().HasKey(sc => new { sc.DeliveryId, sc.SharedItemId });
            modelBuilder.Entity<DeliveryTag>().HasKey(dt => new { dt.DeliveryId, dt.TagId });
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.RoleId, ur.UserId });


        }
    }
}
