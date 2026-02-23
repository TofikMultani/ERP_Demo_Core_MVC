using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Demo_Core_MVC.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_Roll = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Student_Age = table.Column<int>(type: "int", nullable: false),
                    Student_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_Roll);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Teacher_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacher_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacher_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacher_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacher_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacher_Jion_Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Teacher_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
