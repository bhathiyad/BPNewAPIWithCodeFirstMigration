using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace BPNew.Service.Data.Migrations
{
    public partial class AlterSPGetAccessibleMeetingsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var pathToData = Path.GetFullPath(Path.Combine("Scripts", "AlterSPGetAccessibleMeetings.sql"));
            string sp = File.ReadAllText(pathToData);
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
