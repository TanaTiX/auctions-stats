using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionsStats.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COINS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NAME = table.Column<string>(type: "text", nullable: false),
                    ISSUEYEAR = table.Column<int>(name: "ISSUE_YEAR", type: "integer", nullable: true),
                    NOMINAL = table.Column<string>(type: "text", nullable: false),
                    CURRENCY = table.Column<string>(type: "text", nullable: false),
                    REFERENCENO = table.Column<string>(name: "REFERENCE_NO", type: "text", nullable: false),
                    LASTMODIFIED = table.Column<DateTime>(name: "LAST_MODIFIED", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COINS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COINS");
        }
    }
}
