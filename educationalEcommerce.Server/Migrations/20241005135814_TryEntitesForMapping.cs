using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace educationalEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class TryEntitesForMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainMods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModAlts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainModId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModAlts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModAlts_MainMods_MainModId",
                        column: x => x.MainModId,
                        principalTable: "MainMods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModIncDecs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainModId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModIncDecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModIncDecs_MainMods_MainModId",
                        column: x => x.MainModId,
                        principalTable: "MainMods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModAltItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModAltId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModAltItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModAltItems_ModAlts_ModAltId",
                        column: x => x.ModAltId,
                        principalTable: "ModAlts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModIncDecItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModIncDecId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModIncDecItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModIncDecItems_ModIncDecs_ModIncDecId",
                        column: x => x.ModIncDecId,
                        principalTable: "ModIncDecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModAltItems_ModAltId",
                table: "ModAltItems",
                column: "ModAltId");

            migrationBuilder.CreateIndex(
                name: "IX_ModAlts_MainModId",
                table: "ModAlts",
                column: "MainModId");

            migrationBuilder.CreateIndex(
                name: "IX_ModIncDecItems_ModIncDecId",
                table: "ModIncDecItems",
                column: "ModIncDecId");

            migrationBuilder.CreateIndex(
                name: "IX_ModIncDecs_MainModId",
                table: "ModIncDecs",
                column: "MainModId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModAltItems");

            migrationBuilder.DropTable(
                name: "ModIncDecItems");

            migrationBuilder.DropTable(
                name: "ModAlts");

            migrationBuilder.DropTable(
                name: "ModIncDecs");

            migrationBuilder.DropTable(
                name: "MainMods");
        }
    }
}
