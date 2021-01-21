﻿// <auto-generated />
using System;
using DiscordBot.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscordBot.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    [Migration("20210120194205_Added guild connections and guild config")]
    partial class Addedguildconnectionsandguildconfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DiscordBot.Models.Database.DiscordUser", b =>
                {
                    b.Property<ulong>("DiscordUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("DiscordUserId");

                    b.ToTable("DiscordUsers");
                });

            modelBuilder.Entity("DiscordBot.Models.Database.GuildConfig", b =>
                {
                    b.Property<ulong>("Guild")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableDebug")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UpdatesChannel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Guild");

                    b.ToTable("GuildConfigs");
                });

            modelBuilder.Entity("DiscordBot.Models.Database.ValorantAccount", b =>
                {
                    b.Property<int>("ValorantAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("DiscordUserId")
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

            modelBuilder.Entity("DiscordBot.Models.Database.ValorantAccount", b =>
                {
                    b.HasOne("DiscordBot.Models.Database.DiscordUser", "DiscordUser")
                        .WithMany("ValorantAccounts")
                        .HasForeignKey("DiscordUserId");

                    b.Navigation("DiscordUser");
                });

            modelBuilder.Entity("DiscordBot.Models.Database.DiscordUser", b =>
                {
                    b.Navigation("ValorantAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}