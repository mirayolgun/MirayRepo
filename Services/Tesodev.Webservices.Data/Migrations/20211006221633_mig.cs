using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tesodev.Webservices.Data.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    AddressLine = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CityCode = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addesses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addesses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9638), "mehmethatay@gmail.com", "Mehmet Hatay", null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(309), "doganbulut@gmail.com", "Doğan Bulut", null });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(337), "unastubbs@hotmail.com", "Una Stubbs", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price", "Quantity", "Status", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(1872), 1, 150, 4, "Teslim edildi", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price", "Quantity", "Status", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(1815), 2, 100, 1, "İptal edildi", null });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price", "Quantity", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2021, 10, 7, 1, 16, 32, 891, DateTimeKind.Local).AddTicks(780), 3, 80, 2, "kargoya verildi", null });

            migrationBuilder.InsertData(
                table: "Addesses",
                columns: new[] { "Id", "AddressLine", "City", "CityCode", "Country", "CreatedDate", "CustomerId", "OrderId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ayaş Ankara Yolu Blv. No:93, 06796 ", "Ankara", "312", "Türkiye", new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(7254), 1, 3, null },
                    { 2, "123 Main Street Room 22", "New York", "212", "ABD", new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9083), 2, 2, null },
                    { 3, "221B Baker Street", "Londra", "212", "İngiltere", new DateTime(2021, 10, 7, 1, 16, 32, 890, DateTimeKind.Local).AddTicks(9155), 3, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "Name", "OrderId", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 10, 7, 1, 16, 32, 889, DateTimeKind.Local).AddTicks(6783), "dogumgunucicekleri.jpg", "Mutluluk Kutusu", 3, null },
                    { 3, new DateTime(2021, 10, 7, 1, 16, 32, 889, DateTimeKind.Local).AddTicks(6830), "cicekbuketleri.jpg", "Pembe Papatyalı Çiçek Buketi", 2, null },
                    { 1, new DateTime(2021, 10, 7, 1, 16, 32, 888, DateTimeKind.Local).AddTicks(8165), "tasarimcicek.jpg", "Pembe incili Kutuda Renkli Lisyantus", 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addesses_CustomerId",
                table: "Addesses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Addesses_OrderId",
                table: "Addesses",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addesses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
