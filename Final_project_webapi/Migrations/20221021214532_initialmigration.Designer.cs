﻿// <auto-generated />
using System;
using Final_project_webapi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_project_webapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221021214532_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Final_project_webapi.Models.Item", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Flavor")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("itemName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("itemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Final_project_webapi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .HasColumnType("TEXT");

                    b.Property<long>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserType")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}