using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce_MVC.Data.Migrations
{
    public partial class CurrDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_SellerProducts_SellerProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_SellerProducts_SellerProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Reviews_ReviewId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Sellers_SellerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerProducts_Products_Productid",
                table: "SellerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerProducts_Sellers_Sellerid",
                table: "SellerProducts");

            migrationBuilder.DropTable(
                name: "CustomerOrderItemVM");

            migrationBuilder.DropIndex(
                name: "IX_SellerProducts_Sellerid",
                table: "SellerProducts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SellerProducts");

            migrationBuilder.RenameColumn(
                name: "Sellerid",
                table: "SellerProducts",
                newName: "SellerId");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "SellerProducts",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SellerProducts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_SellerProducts_Productid",
                table: "SellerProducts",
                newName: "IX_SellerProducts_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "SellerProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDatet",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_SellerProducts_SellerId_ProductId",
                table: "SellerProducts",
                columns: new[] { "SellerId", "ProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Serialnum",
                table: "Products",
                column: "Serialnum",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_SellerProducts_SellerProductId",
                table: "CartItems",
                column: "SellerProductId",
                principalTable: "SellerProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_SellerProducts_SellerProductId",
                table: "OrderItems",
                column: "SellerProductId",
                principalTable: "SellerProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Reviews_ReviewId",
                table: "Reports",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Sellers_SellerId",
                table: "Reviews",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Sellerid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerProducts_Products_ProductId",
                table: "SellerProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerProducts_Sellers_SellerId",
                table: "SellerProducts",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Sellerid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_SellerProducts_SellerProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_SellerProducts_SellerProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Reviews_ReviewId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Sellers_SellerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerProducts_Products_ProductId",
                table: "SellerProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SellerProducts_Sellers_SellerId",
                table: "SellerProducts");

            migrationBuilder.DropIndex(
                name: "IX_SellerProducts_SellerId_ProductId",
                table: "SellerProducts");

            migrationBuilder.DropIndex(
                name: "IX_Products_Serialnum",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "SellerProducts");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SellerProducts",
                newName: "Sellerid");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "SellerProducts",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SellerProducts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_SellerProducts_ProductId",
                table: "SellerProducts",
                newName: "IX_SellerProducts_Productid");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SellerProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDatet",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.CreateTable(
                name: "CustomerOrderItemVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Productid = table.Column<int>(type: "int", nullable: false),
                    Sellerid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellerProductId = table.Column<int>(type: "int", nullable: false),
                    SellerProductesid = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrderItemVM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOrderItemVM_Products_Productid",
                        column: x => x.Productid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomerOrderItemVM_SellerProducts_SellerProductesid",
                        column: x => x.SellerProductesid,
                        principalTable: "SellerProducts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CustomerOrderItemVM_Sellers_Sellerid",
                        column: x => x.Sellerid,
                        principalTable: "Sellers",
                        principalColumn: "Sellerid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SellerProducts_Sellerid",
                table: "SellerProducts",
                column: "Sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrderItemVM_Productid",
                table: "CustomerOrderItemVM",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrderItemVM_Sellerid",
                table: "CustomerOrderItemVM",
                column: "Sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrderItemVM_SellerProductesid",
                table: "CustomerOrderItemVM",
                column: "SellerProductesid");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_SellerProducts_SellerProductId",
                table: "CartItems",
                column: "SellerProductId",
                principalTable: "SellerProducts",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_SellerProducts_SellerProductId",
                table: "OrderItems",
                column: "SellerProductId",
                principalTable: "SellerProducts",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Reviews_ReviewId",
                table: "Reports",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Sellers_SellerId",
                table: "Reviews",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Sellerid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerProducts_Products_Productid",
                table: "SellerProducts",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SellerProducts_Sellers_Sellerid",
                table: "SellerProducts",
                column: "Sellerid",
                principalTable: "Sellers",
                principalColumn: "Sellerid",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
