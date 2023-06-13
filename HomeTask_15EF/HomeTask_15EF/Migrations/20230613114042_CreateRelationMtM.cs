using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTask_15EF.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationMtM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_StoreNetwork_NetworkId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_NetworkId",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "NetworkId",
                table: "Store",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StoreNetwork",
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
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_StoreNetwork_Id",
                table: "Store",
                column: "Id",
                principalTable: "StoreNetwork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_StoreNetwork_Id",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Store",
                newName: "NetworkId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StoreNetwork",
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
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Store_NetworkId",
                table: "Store",
                column: "NetworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_StoreNetwork_NetworkId",
                table: "Store",
                column: "NetworkId",
                principalTable: "StoreNetwork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
