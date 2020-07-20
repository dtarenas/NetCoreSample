using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreSample.Web.MVC.Migrations
{
    public partial class FixCourseRelationWithRemarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Courses_FkCoursesCourseId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_FkCoursesCourseId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "FkCourseId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "FkCoursesCourseId",
                table: "Remarks");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Remarks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CourseId",
                table: "Remarks",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Courses_CourseId",
                table: "Remarks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Courses_CourseId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_CourseId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Remarks");

            migrationBuilder.AddColumn<int>(
                name: "FkCourseId",
                table: "Remarks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FkCoursesCourseId",
                table: "Remarks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_FkCoursesCourseId",
                table: "Remarks",
                column: "FkCoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Courses_FkCoursesCourseId",
                table: "Remarks",
                column: "FkCoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
