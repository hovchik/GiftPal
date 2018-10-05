using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

namespace GiftPalServer.DbContext
{
    public class GiftPalDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public GiftPalDbContext()
        {
        }

        public GiftPalDbContext(DbContextOptions<GiftPalDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connection = @"Server=tcp:giftpal.database.windows.net,1433;Initial Catalog=GiftPal;Persist Security Info=False;User ID=giftpaladmin;Password=!QAZ2wsx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email ).IsRequired();
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.BirthDay).IsRequired();
                entity.HasKey(e => e.ID);
            });

            //modelBuilder.Entity<Post>(entity =>
            //{
            //    entity.HasOne(d => d.Blog)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.BlogId);
            //});
        }

        public virtual DbSet<Gifts> Gifts { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<Goods> Goods{ get; set; }
        public virtual DbSet<ReceivedGoods> ReceivedGoods { get; set; }
        public virtual DbSet<SentGoods> SentGoods { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRelations> UserRelations { get; set; }
        public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; }

    }
}
