﻿// <auto-generated />
using System;
using DiscordBot.Models.Database;
using DiscordBot.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscordBot.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    [Migration("20210119065940_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DiscordBot.Services.DiscordUser", b =>
                {
                    b.Property<int>("DiscordUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("DiscordUserId");

                    b.ToTable("DiscordUsers");
                });

            modelBuilder.Entity("DiscordBot.Services.ValorantAccount", b =>
                {
                    b.Property<int>("ValorantAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DiscordUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RankName")
                        .HasColumnType("TEXT");

                    b.Property<int>("RankProgress")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("ValorantAccountId");

                    b.HasIndex("DiscordUserId");

                    b.ToTable("ValorantAccount");
                });

            modelBuilder.Entity("DiscordBot.Services.ValorantAccount", b =>
                {
                    b.HasOne("DiscordBot.Services.DiscordUser", null)
                        .WithMany("ValorantAccounts")
                        .HasForeignKey("DiscordUserId");
                });

            modelBuilder.Entity("DiscordBot.Services.DiscordUser", b =>
                {
                    b.Navigation("ValorantAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
