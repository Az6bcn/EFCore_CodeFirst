using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Migrations
{
    public partial class AddFkColumnInStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddresses_Students_StudentID",
                table: "StudentAddresses");

            migrationBuilder.DropIndex(
                name: "IX_StudentAddresses_StudentID",
                table: "StudentAddresses");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "StudentAddresses");

            migrationBuilder.AddColumn<int>(
                name: "StudentAddressID",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentAddressID",
                table: "Students",
                column: "StudentAddressID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentAddresses_StudentAddressID",
                table: "Students",
                column: "StudentAddressID",
                principalTable: "StudentAddresses",
                principalColumn: "StudentAddressID",
                onDelete: ReferentialAction.Cascade);
            // add data

            migrationBuilder.Sql("INSERT INTO StudentAddresses VALUES (1, GETDATE(), 'Azeez', 'Odumosu')");
            migrationBuilder.Sql("INSERT INTO StudentAddresses VALUES (2, GETDATE(), 'Olutobi', 'Odumosu')");
            migrationBuilder.Sql("INSERT INTO StudentAddresses VALUES (3, GETDATE(), 'MedyAzeez', 'UnasBeatz')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentAddresses_StudentAddressID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentAddressID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentAddressID",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "StudentAddresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddresses_StudentID",
                table: "StudentAddresses",
                column: "StudentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddresses_Students_StudentID",
                table: "StudentAddresses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "studentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
