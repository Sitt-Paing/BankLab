using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLab.Infrastructure.Migrations;

/// <inheritdoc />
public partial class _20261125050107_UseGuidCustomerId : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Keep the old identity values so rollback restores the original customer keys.
        migrationBuilder.DropPrimaryKey("PK_Customers", "Customers");
        migrationBuilder.RenameColumn("Id", "Customers", "LegacyId");
        migrationBuilder.AddColumn<Guid>(
            name: "Id",
            table: "Customers",
            type: "uniqueidentifier",
            nullable: true);

        migrationBuilder.Sql("EXEC(N'UPDATE [Customers] SET [Id] = NEWID() WHERE [Id] IS NULL;');");
        migrationBuilder.AlterColumn<Guid>(
            name: "Id",
            table: "Customers",
            type: "uniqueidentifier",
            nullable: false,
            oldClrType: typeof(Guid),
            oldType: "uniqueidentifier",
            oldNullable: true);

        migrationBuilder.AddPrimaryKey("PK_Customers", "Customers", "Id");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropPrimaryKey("PK_Customers", "Customers");
        migrationBuilder.DropColumn("Id", "Customers");
        migrationBuilder.RenameColumn("LegacyId", "Customers", "Id");
        migrationBuilder.AddPrimaryKey("PK_Customers", "Customers", "Id");
    }
}
