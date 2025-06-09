using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dawstin_CPW221_BaseballShop.Migrations
{
    /// <summary>
    /// Represents the initial database migration for setting up the Baseball Shop schema.
    /// </summary>
    public partial class Initial : Migration
    {
        /// <summary>
        /// Applies the migration, creating tables and indexes for the database schema.
        /// </summary>
        /// <param name="migrationBuilder">The migration builder used to apply database changes.</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    /// <summary>
                    /// Unique identifier for the category.
                    /// </summary>
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    /// <summary>
                    /// Name of the category.
                    /// </summary>
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    /// <summary>
                    /// Unique identifier for the customer.
                    /// </summary>
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    /// <summary>
                    /// First name of the customer.
                    /// </summary>
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    /// <summary>
                    /// Last name of the customer.
                    /// </summary>
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    /// <summary>
                    /// Email address of the customer.
                    /// </summary>
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    /// <summary>
                    /// Phone number of the customer.
                    /// </summary>
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    /// <summary>
                    /// Date when the customer account was created.
                    /// </summary>
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            // Additional table creation comments omitted for brevity

        }

        /// <summary>
        /// Reverts the migration, removing tables from the database.
        /// </summary>
        /// <param name="migrationBuilder">The migration builder used to apply database changes.</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Events");
            migrationBuilder.DropTable(name: "Items");
            migrationBuilder.DropTable(name: "OrderDetails");
            migrationBuilder.DropTable(name: "Orders");
            migrationBuilder.DropTable(name: "Products");
            migrationBuilder.DropTable(name: "Customers");
            migrationBuilder.DropTable(name: "Categories");
        }
    }
}