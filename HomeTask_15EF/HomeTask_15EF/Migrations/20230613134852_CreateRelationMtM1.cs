using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTask_15EF.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationMtM1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_StoreNetwork_Id",
                table: "Store");

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "StoreNetwork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Store",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Store",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StoreNetworkId",
                table: "Store",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_StoreNetworkId",
                table: "Store",
                column: "StoreNetworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_StoreNetwork_StoreNetworkId",
                table: "Store",
                column: "StoreNetworkId",
                principalTable: "StoreNetwork",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_StoreNetwork_StoreNetworkId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_StoreNetworkId",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "StoreNetwork");

            migrationBuilder.DropColumn(
                name: "StoreNetworkId",
                table: "Store");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Store",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Store",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_StoreNetwork_Id",
                table: "Store",
                column: "Id",
                principalTable: "StoreNetwork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
