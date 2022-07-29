using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileUpload2.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Base64File",
                table: "UploadFileInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "UploadFileInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64File",
                table: "UploadFileInfos");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "UploadFileInfos");
        }
    }
}
