using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTask_15EF.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationMtM6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "StoreNetwork");

            migrationBuilder.AddColumn<int>(
                name: "NetworkStoreId",
                table: "Store",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetworkStoreId",
                table: "Store");

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "StoreNetwork",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
