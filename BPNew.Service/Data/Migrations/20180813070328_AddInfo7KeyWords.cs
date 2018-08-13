using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class AddInfo7KeyWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info7",
                table: "Keywords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info7",
                table: "Keywords");
        }
    }
}
