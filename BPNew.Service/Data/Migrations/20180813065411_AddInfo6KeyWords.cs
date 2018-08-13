using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class AddInfo6KeyWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info6",
                table: "Keywords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info6",
                table: "Keywords");
        }
    }
}
