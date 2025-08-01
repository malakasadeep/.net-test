using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Department", "Email", "FullName", "HireDate", "Phone", "Position", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Human Resources", "john.doe@company.com", "John wick", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890", "HR Manager", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, "Finance", "jane.smith@company.com", "Jane Smith", new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "987-654-3210", "Senior Accountant", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 3, "Information Technology", "michael.johnson@company.com", "Michael Johnson", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-123-1234", "Software Developer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 4, "Marketing", "emily.davis@company.com", "Emily Davis", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "987-987-9876", "Marketing Executive", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 5, "Sales", "william.brown@company.com", "William Brown", new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "456-456-4567", "Sales Manager", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });
        }
    }
}
