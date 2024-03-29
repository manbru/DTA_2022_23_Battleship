﻿// <auto-generated />
using DTA_2022_23_Battleship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTA_2022_23_Battleship.Migrations
{
    [DbContext(typeof(BattleshipContext))]
    [Migration("20230418201149_UserUpdate")]
    partial class UserUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("DTA_2022_23_Battleship.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EndTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoserUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Turns")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WinnerUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId");

                    b.HasIndex("LoserUserId");

                    b.HasIndex("WinnerUserId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("DTA_2022_23_Battleship.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Deactivated")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DTA_2022_23_Battleship.Match", b =>
                {
                    b.HasOne("DTA_2022_23_Battleship.User", "Loser")
                        .WithMany()
                        .HasForeignKey("LoserUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTA_2022_23_Battleship.User", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loser");

                    b.Navigation("Winner");
                });
#pragma warning restore 612, 618
        }
    }
}
