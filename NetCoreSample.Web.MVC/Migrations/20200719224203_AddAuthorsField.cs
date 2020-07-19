using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreSample.Web.MVC.Migrations
{
    public partial class AddAuthorsField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Remarks",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Remarks");
        }
    }
}
