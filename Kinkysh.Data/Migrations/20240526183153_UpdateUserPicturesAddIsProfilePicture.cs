using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kinkysh.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserPicturesAddIsProfilePicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProfilePicture",
                table: "UserPictures",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProfilePicture",
                table: "UserPictures");
        }
    }
}
