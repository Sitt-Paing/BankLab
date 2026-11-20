using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLab.Infrastructure.Migrations;

/// <inheritdoc />
public partial class _20261120081032_InitialDatabasecolUpdate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<string>(
            name: "Email",
            table: "Customers",
            type: "nvarchar(200)",
            maxLength: 200,
            nullable: false,
            defaultValue: "");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Email",
            table: "Customers");
    }
}
