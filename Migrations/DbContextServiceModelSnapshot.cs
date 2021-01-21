﻿// <auto-generated />
using System;
using DiscordBot.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscordBot.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    partial class DbContextServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DiscordBot.Models.Database.CustomHeader", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("CustomHeaders");
                });

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

                    b.Property<ulong?>("UpdatesChannel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Guild");

                    b.ToTable("GuildConfigs");
                });

            modelBuilder.Entity("DiscordBot.Models.Database.RegisteredGuild", b =>
                {
                    b.Property<int>("RegisteredGuildID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("GuildID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ValorantAccountId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RegisteredGuildID");

                    b.HasIndex("ValorantAccountId");

                    b.ToTable("RegisteredGuild");
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

            modelBuilder.Entity("DiscordBot.Models.Database.RegisteredGuild", b =>
                {
                    b.HasOne("DiscordBot.Models.Database.ValorantAccount", "ValorantAccount")
                        .WithMany("RegisteredGuilds")
                        .HasForeignKey("ValorantAccountId");

                    b.Navigation("ValorantAccount");
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

            modelBuilder.Entity("DiscordBot.Models.Database.ValorantAccount", b =>
                {
                    b.Navigation("RegisteredGuilds");
                });
#pragma warning restore 612, 618
        }
    }
}
