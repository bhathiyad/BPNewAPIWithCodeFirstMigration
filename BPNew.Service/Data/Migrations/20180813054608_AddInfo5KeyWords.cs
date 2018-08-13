using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class AddInfo5KeyWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info5",
                table: "Keywords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info5",
                table: "Keywords");
        }
    }
}
