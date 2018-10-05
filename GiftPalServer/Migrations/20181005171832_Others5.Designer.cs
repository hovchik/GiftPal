﻿// <auto-generated />
using System;
using GiftPalServer.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftPalServer.Migrations
{
    [DbContext(typeof(GiftPalDbContext))]
    [Migration("20181005171832_Others5")]
    partial class Others5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Feedbacks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Feedback")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Models.Gifts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GiftName");

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Gifts");
                });

            modelBuilder.Entity("Models.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReceivedGoodsId");

                    b.Property<int>("SentGoodsId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ReceivedGoodsId");

                    b.HasIndex("SentGoodsId");

                    b.HasIndex("UserId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Models.ReceivedGoods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<int>("GiftId");

                    b.Property<int?>("GiftsId");

                    b.Property<bool>("IsReceived");

                    b.Property<bool>("OnTheWay");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("GiftsId");

                    b.ToTable("ReceivedGoods");
                });

            modelBuilder.Entity("Models.SentGoods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<int>("GiftId");

                    b.Property<bool>("IsSent");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.ToTable("SentGoods");
                });

            modelBuilder.Entity("Models.ShippingAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired();

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.Property<int>("UserId");

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShippingAddresses");
                });

            modelBuilder.Entity("Models.UserRelations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<int>("DestinationId");

                    b.Property<int>("GoodId");

                    b.Property<bool>("IsSent");

                    b.Property<int>("Rating");

                    b.Property<int>("SourceId");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("GoodId");

                    b.HasIndex("SourceId");

                    b.ToTable("UserRelations");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Feedbacks", b =>
                {
                    b.HasOne("Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.Goods", b =>
                {
                    b.HasOne("Models.ReceivedGoods", "ReceivedGoods")
                        .WithMany()
                        .HasForeignKey("ReceivedGoodsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.SentGoods", "SentGoods")
                        .WithMany()
                        .HasForeignKey("SentGoodsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.ReceivedGoods", b =>
                {
                    b.HasOne("Models.Gifts", "Gifts")
                        .WithMany("ReceivedGoods")
                        .HasForeignKey("GiftsId");
                });

            modelBuilder.Entity("Models.SentGoods", b =>
                {
                    b.HasOne("Models.Gifts", "Gift")
                        .WithMany("SentGoods")
                        .HasForeignKey("GiftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.ShippingAddress", b =>
                {
                    b.HasOne("Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.UserRelations", b =>
                {
                    b.HasOne("Models.Users", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.Goods", "Good")
                        .WithMany("UserRelationses")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.Users", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
