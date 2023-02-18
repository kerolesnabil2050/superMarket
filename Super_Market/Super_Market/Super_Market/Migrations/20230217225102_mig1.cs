using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Market.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Pos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorys_Stors_StorId",
                        column: x => x.StorId,
                        principalTable: "Stors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recipts",
                columns: table => new
                {
                    bon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuppliersId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipts", x => x.bon);
                    table.ForeignKey(
                        name: "FK_recipts_suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sellinvoces",
                columns: table => new
                {
                    BonNumberr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    casherUserNameUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    PaidMoney = table.Column<double>(type: "float", nullable: false),
                    RemainingMoney = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellinvoces", x => x.BonNumberr);
                    table.ForeignKey(
                        name: "FK_sellinvoces_users_casherUserNameUserName",
                        column: x => x.casherUserNameUserName,
                        principalTable: "users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proudcts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    PurchasingPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategorysId = table.Column<int>(type: "int", nullable: false),
                    Suppliersid = table.Column<int>(type: "int", nullable: false),
                    Sellinvoceid = table.Column<int>(type: "int", nullable: true),
                    ReciptId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proudcts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proudcts_Categorys_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proudcts_recipts_ReciptId",
                        column: x => x.ReciptId,
                        principalTable: "recipts",
                        principalColumn: "bon");
                    table.ForeignKey(
                        name: "FK_proudcts_sellinvoces_Sellinvoceid",
                        column: x => x.Sellinvoceid,
                        principalTable: "sellinvoces",
                        principalColumn: "BonNumberr");
                    table.ForeignKey(
                        name: "FK_proudcts_suppliers_Suppliersid",
                        column: x => x.Suppliersid,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stors",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Assiut", "Store1" },
                    { 2, "Alex", "Store2" },
                    { 3, "Cairo", "Store3" }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "Id", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Manar", "01028574231" },
                    { 2, "Alaa", "01055688224" },
                    { 3, "Selevia", "0104567432" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserName", "Password", "Pos", "Salary" },
                values: new object[,]
                {
                    { "Ahmed", 12345, 0, 2000f },
                    { "Mahmoud", 2555, 0, 1000f },
                    { "Nada", 54321, 1, 3000f }
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name", "StorId" },
                values: new object[,]
                {
                    { 1, "Dairy", 1 },
                    { 2, "Beverages", 1 },
                    { 3, "Vegetables", 2 },
                    { 4, "Personal Care", 2 },
                    { 5, "Meat", 2 },
                    { 6, "Pasta/Rice", 3 },
                    { 7, "Fruits", 3 }
                });

            migrationBuilder.InsertData(
                table: "proudcts",
                columns: new[] { "Id", "CategorysId", "ExpirationDate", "Name", "ProductionDate", "PurchasingPrice", "Quantity", "ReciptId", "SellingPrice", "Sellinvoceid", "Suppliersid" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk", new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.0, 20, null, 15.0, null, 1 },
                    { 2, 1, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheese", new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.0, 17, null, 30.0, null, 1 },
                    { 3, 1, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egg", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, 200, null, 5.0, null, 1 },
                    { 4, 2, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water", new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.0, 25, null, 6.0, null, 2 },
                    { 5, 2, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, 48, null, 10.0, null, 2 },
                    { 6, 2, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juice", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 36, null, 16.0, null, 2 },
                    { 7, 3, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomato", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0, 70, null, 6.0, null, 3 },
                    { 8, 3, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potato", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 36, null, 14.0, null, 3 },
                    { 9, 3, new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "cucumber", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 25, null, 17.0, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_StorId",
                table: "Categorys",
                column: "StorId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_CategorysId",
                table: "proudcts",
                column: "CategorysId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_ReciptId",
                table: "proudcts",
                column: "ReciptId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_Sellinvoceid",
                table: "proudcts",
                column: "Sellinvoceid");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_Suppliersid",
                table: "proudcts",
                column: "Suppliersid");

            migrationBuilder.CreateIndex(
                name: "IX_recipts_SuppliersId",
                table: "recipts",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_sellinvoces_casherUserNameUserName",
                table: "sellinvoces",
                column: "casherUserNameUserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proudcts");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "recipts");

            migrationBuilder.DropTable(
                name: "sellinvoces");

            migrationBuilder.DropTable(
                name: "Stors");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
