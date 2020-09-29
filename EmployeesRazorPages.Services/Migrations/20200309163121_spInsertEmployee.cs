﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRazorPages.Services.Migrations
{
    public partial class spInsertEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @" Create Procedure spInsertEmployee
                                  @Name nvarchar(100),
                                  @Email nvarchar(100),
                                  @PhotoPath nvarchar(100),
                                  @Dept int
                                  AS
                                  BEGIN
                                      INSERT INTO Employees
                                          (Name, Email, PhotoPath, Department)
                                      VALUES (@Name, @Email, @PhotoPath, @Dept)
                                  END ";

            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @" Drop Procedure spInsertEmployee";
            migrationBuilder.Sql(procedure);
        }
    }
}
