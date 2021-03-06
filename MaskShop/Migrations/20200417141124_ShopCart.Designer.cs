﻿// <auto-generated />
using System;
using MaskShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaskShop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20200417141124_ShopCart")]
    partial class ShopCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaskShop.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("description");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MaskShop.Data.Models.Mask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryId");

                    b.Property<string>("image");

                    b.Property<bool>("isFavorite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Mask");
                });

            modelBuilder.Entity("MaskShop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int?>("maskid");

                    b.Property<int>("price");

                    b.HasKey("id");

                    b.HasIndex("maskid");

                    b.ToTable("shopCartItem");
                });

            modelBuilder.Entity("MaskShop.Data.Models.Mask", b =>
                {
                    b.HasOne("MaskShop.Data.Models.Category", "Category")
                        .WithMany("masks")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MaskShop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("MaskShop.Data.Models.Mask", "mask")
                        .WithMany()
                        .HasForeignKey("maskid");
                });
#pragma warning restore 612, 618
        }
    }
}
