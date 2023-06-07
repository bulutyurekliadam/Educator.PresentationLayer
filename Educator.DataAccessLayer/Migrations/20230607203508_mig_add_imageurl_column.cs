using Microsoft.EntityFrameworkCore.Migrations;

namespace Educator.DataAccessLayer.Migrations
{
    public partial class mig_add_imageurl_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "imageUrl",
                table: "AspNetUsers",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "AspNetUsers");
        }
    }
}
