using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApplicationForm_W4.Data.Migrations
{
    public partial class raushan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeViewModel",
                columns: table => new
                {
                    emp = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Add = table.Column<int>(nullable: false),
                    AddLines = table.Column<int>(nullable: false),
                    Allowances = table.Column<int>(nullable: false),
                    CState = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 18, nullable: false),
                    Deductions = table.Column<int>(nullable: false),
                    Divide = table.Column<int>(nullable: false),
                    EState = table.Column<int>(nullable: false),
                    EZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    EmployerCity = table.Column<string>(maxLength: 18, nullable: false),
                    EmployerName = table.Column<string>(nullable: false),
                    EmployerStreetNumberAndName = table.Column<string>(maxLength: 34, nullable: false),
                    Enter = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    Estimate = table.Column<int>(nullable: false),
                    Exemption = table.Column<string>(nullable: true),
                    FEIN = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    IsDifferent = table.Column<bool>(nullable: false),
                    IsForYourself = table.Column<bool>(nullable: false),
                    IsHeadOfHousehold = table.Column<bool>(nullable: false),
                    IsJoint = table.Column<bool>(nullable: false),
                    IsMarried = table.Column<bool>(nullable: false),
                    IsSeparate = table.Column<bool>(nullable: false),
                    IsSingle = table.Column<bool>(nullable: false),
                    IsSingleJob = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 25, nullable: true),
                    Nowage = table.Column<int>(nullable: false),
                    OtherCredits = table.Column<int>(nullable: false),
                    OtherDependents = table.Column<int>(nullable: false),
                    Paycheck = table.Column<int>(nullable: false),
                    Personal = table.Column<int>(nullable: false),
                    Result = table.Column<int>(nullable: false),
                    SSN = table.Column<string>(nullable: true),
                    StreetNumberAndName = table.Column<string>(maxLength: 34, nullable: false),
                    Subtract = table.Column<int>(nullable: false),
                    Sum = table.Column<int>(nullable: false),
                    TotalIncome = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeViewModel", x => x.emp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeViewModel");
        }
    }
}
