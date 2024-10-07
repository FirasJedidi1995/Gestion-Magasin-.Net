using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magasin.Migrations
{
    /// <inheritdoc />
    public partial class usersales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_salesLeads",
                table: "salesLeads");

            migrationBuilder.RenameTable(
                name: "salesLeads",
                newName: "SalesLeads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesLeads",
                table: "SalesLeads",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesLeads",
                table: "SalesLeads");

            migrationBuilder.RenameTable(
                name: "SalesLeads",
                newName: "salesLeads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_salesLeads",
                table: "salesLeads",
                column: "Id");
        }
    }
}
