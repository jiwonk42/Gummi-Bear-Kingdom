using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gummibearkingdom.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
