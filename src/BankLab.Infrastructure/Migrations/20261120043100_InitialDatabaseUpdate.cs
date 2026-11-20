using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLab.Infrastructure.Migrations;

/// <inheritdoc />
public partial class _20261120043100_InitialDatabaseUpdate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsActive",
            table: "Customers",
            type: "bit",
            nullable: false,
            defaultValue: false);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "IsActive",
            table: "Customers");
    }
}
