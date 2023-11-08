using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesslayer.Migrations
{
    public partial class mig_new_guide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Destinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Destinations",
                type: "int",
                nullable: true);
        }
    }
}
