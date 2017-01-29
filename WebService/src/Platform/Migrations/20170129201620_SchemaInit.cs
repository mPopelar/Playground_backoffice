using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Platform.Migrations
{
    public partial class SchemaInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Platform");

            migrationBuilder.RenameTable(
                name: "Clients",
                newSchema: "Platform");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Clients",
                schema: "Platform");
        }
    }
}
