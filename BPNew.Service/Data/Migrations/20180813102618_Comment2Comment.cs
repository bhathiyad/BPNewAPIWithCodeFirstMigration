using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class Comment2Comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment2",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment2",
                table: "Comments");
        }
    }
}
