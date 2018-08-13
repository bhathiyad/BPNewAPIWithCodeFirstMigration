using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace BPNew.Service.Data.Migrations
{
    public partial class CreateSPTEstSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var pathToData = Path.GetFullPath(Path.Combine("Scripts", "CreateSPTest.sql"));
            string sp = File.ReadAllText(pathToData);
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
