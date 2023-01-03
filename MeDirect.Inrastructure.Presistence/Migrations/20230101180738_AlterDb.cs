using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeDirect.Inrastructure.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_RatedById",
                table: "CurrencyRates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyRateTranscations",
                table: "CurrencyRateTranscations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "CrrencyId",
                table: "CurrencyRateTranscations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Currencies");

            migrationBuilder.AddColumn<string>(
                name: "CrrencyCode",
                table: "CurrencyRateTranscations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "RatedById",
                table: "CurrencyRates",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Currencies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyRateTranscations",
                table: "CurrencyRateTranscations",
                columns: new[] { "RateId", "CrrencyCode" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_RatedById",
                table: "CurrencyRates",
                column: "RatedById",
                principalTable: "Currencies",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrencyRates_Currencies_RatedById",
                table: "CurrencyRates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyRateTranscations",
                table: "CurrencyRateTranscations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "CrrencyCode",
                table: "CurrencyRateTranscations");

            migrationBuilder.AddColumn<Guid>(
                name: "CrrencyId",
                table: "CurrencyRateTranscations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "RatedById",
                table: "CurrencyRates",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Currencies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyRateTranscations",
                table: "CurrencyRateTranscations",
                columns: new[] { "RateId", "CrrencyId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrencyRates_Currencies_RatedById",
                table: "CurrencyRates",
                column: "RatedById",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
