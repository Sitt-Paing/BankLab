using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLab.Infrastructure.Migrations;

/// <inheritdoc />
public partial class _20261118100552_InitialDatabase : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Customers",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                PhoneNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                FatherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                Nrc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Customers", x => x.Id);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Customers");
    }
}
