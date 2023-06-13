using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeTask_15EF.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationMtM5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Product_ProductsId",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Store_StoresId",
                table: "ProductStore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStore",
                table: "ProductStore");

            migrationBuilder.RenameTable(
                name: "ProductStore",
                newName: "StoreProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStore_StoresId",
                table: "StoreProducts",
                newName: "IX_StoreProducts_StoresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreProducts",
                table: "StoreProducts",
                columns: new[] { "ProductsId", "StoresId" });

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_Product_ProductsId",
                table: "StoreProducts",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProducts_Store_StoresId",
                table: "StoreProducts",
                column: "StoresId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Product_ProductsId",
                table: "StoreProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProducts_Store_StoresId",
                table: "StoreProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreProducts",
                table: "StoreProducts");

            migrationBuilder.RenameTable(
                name: "StoreProducts",
                newName: "ProductStore");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProducts_StoresId",
                table: "ProductStore",
                newName: "IX_ProductStore_StoresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStore",
                table: "ProductStore",
                columns: new[] { "ProductsId", "StoresId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Product_ProductsId",
                table: "ProductStore",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Store_StoresId",
                table: "ProductStore",
                column: "StoresId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
