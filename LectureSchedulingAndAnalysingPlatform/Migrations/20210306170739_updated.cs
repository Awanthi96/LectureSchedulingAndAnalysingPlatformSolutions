using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "11909249-8e58-4379-8a66-bd6261ef261c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "17b6d1a7-5b8e-4407-b30f-75529c3778e6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "356a571d-4ed2-4164-9960-7b6ba9d158c0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a7767895-2e2d-4eba-90e9-222a7702f546");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2b77959-877a-438a-bce8-8ee0c6b06ab3");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc6ec707-239e-4ec7-abe2-af85aeb6849e", "5fbc6bb8-9c46-4838-8ac0-8f59bcac3e60", "Teacher", "TEACHER" },
                    { "47d5ecc9-cfae-44d3-82a1-6d1c2a7bdee3", "040cdeb8-9d3d-49d1-9bcd-cfc26afc37d1", "Student", "STUDENT" },
                    { "7cd5c34b-802e-469c-b612-caf4ae9ec4c4", "cb7b2eb2-706f-4e6f-9c33-cdacb20b6028", "Admin", "ADMIN" },
                    { "b247c1a8-7551-4703-93ce-a24f98b7d5a6", "ae829113-e07c-44e9-a87d-3a58727125e2", "AR", "AR" },
                    { "5e66be1d-b047-47dd-8dc6-a770ef82b6ca", "75a160ff-239b-45e3-9798-aaff9a1d7c36", "HOD", "HOD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "47d5ecc9-cfae-44d3-82a1-6d1c2a7bdee3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5e66be1d-b047-47dd-8dc6-a770ef82b6ca");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7cd5c34b-802e-469c-b612-caf4ae9ec4c4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b247c1a8-7551-4703-93ce-a24f98b7d5a6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cc6ec707-239e-4ec7-abe2-af85aeb6849e");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17b6d1a7-5b8e-4407-b30f-75529c3778e6", "6b26d1c5-561c-4c24-874d-10e520a029f4", "Teacher", "TEACHER" },
                    { "a7767895-2e2d-4eba-90e9-222a7702f546", "8cb296a9-c824-43c0-9897-826c5a991b35", "Student", "STUDENT" },
                    { "356a571d-4ed2-4164-9960-7b6ba9d158c0", "2dc5f7f3-f485-4d0f-bff7-44e51c4feca6", "Admin", "ADMIN" },
                    { "11909249-8e58-4379-8a66-bd6261ef261c", "fb6ab1b8-effe-4e5e-8f5d-b99b2c41496f", "AR", "AR" },
                    { "c2b77959-877a-438a-bce8-8ee0c6b06ab3", "e4d00c04-30cd-4413-b8a4-f51874998b4c", "HOD", "HOD" }
                });
        }
    }
}
