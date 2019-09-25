using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRegistration.Data.Migrations
{
    public partial class Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentCellPhone",
                table: "Student",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StudentCellPhone",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
