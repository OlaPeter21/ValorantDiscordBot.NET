﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscordBot.Migrations
{
    public partial class Addedguildconnectionsandguildconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "GuildConfigs",
                table => new
                {
                    Guild = table.Column<ulong>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UpdatesChannel = table.Column<ulong>("INTEGER", nullable: false),
                    EnableDebug = table.Column<bool>("INTEGER", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_GuildConfigs", x => x.Guild); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "GuildConfigs");
        }
    }
}