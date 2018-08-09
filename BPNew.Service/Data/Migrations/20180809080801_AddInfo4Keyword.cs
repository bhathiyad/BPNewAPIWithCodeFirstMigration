using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class AddInfo4Keyword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info4",
                table: "Keywords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info4",
                table: "Keywords");
        }
    }
}
