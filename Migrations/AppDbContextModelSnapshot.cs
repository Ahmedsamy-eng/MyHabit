﻿// <auto-generated />
using System;
using Habit_Tracker.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Habit_Tracker.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Habit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Category_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("habits");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Habit_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Reward", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("rewards");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.User_Reward", b =>
                {
                    b.Property<int>("u_id")
                        .HasColumnType("int");

                    b.Property<int>("r_id")
                        .HasColumnType("int");

                    b.HasKey("u_id", "r_id");

                    b.HasIndex("r_id");

                    b.ToTable("user_rewards");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Habit", b =>
                {
                    b.HasOne("Habit_Tracker.Models.Entities.Habit_Category", "Category")
                        .WithMany("habits")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Habit_Tracker.Models.Entities.User", "User")
                        .WithMany("habits")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.User_Reward", b =>
                {
                    b.HasOne("Habit_Tracker.Models.Entities.Reward", "reward")
                        .WithMany("rewards")
                        .HasForeignKey("r_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Habit_Tracker.Models.Entities.User", "user")
                        .WithMany("rewards")
                        .HasForeignKey("u_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("reward");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Habit_Category", b =>
                {
                    b.Navigation("habits");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.Reward", b =>
                {
                    b.Navigation("rewards");
                });

            modelBuilder.Entity("Habit_Tracker.Models.Entities.User", b =>
                {
                    b.Navigation("habits");

                    b.Navigation("rewards");
                });
#pragma warning restore 612, 618
        }
    }
}
