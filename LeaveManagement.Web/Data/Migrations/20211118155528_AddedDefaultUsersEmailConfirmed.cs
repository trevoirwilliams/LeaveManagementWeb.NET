using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersEmailConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "550d6b8b-3320-44af-99d1-601fcd0abce2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "7995f36d-a1e5-4da3-8eeb-cb8789f3c684");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6ee258f4-52c6-4315-970c-dbd3072232bb", true, "AQAAAAEAACcQAAAAEGFyHgaLxjZeIjzWPqY04hRwb8DXsDp+hpSKUkSsfGzJBcbfIxYazLGoxCg8K0Xycg==", "0c284d65-5601-4213-80ea-63f402e4fe35", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aaf70aec-f5af-480a-a595-98a19516ad4a", true, "AQAAAAEAACcQAAAAEPrjEzZn7AM4NH7xayyXqd4aWwL9BDQfyAWeWaG128PbfKZi/HShxlEKYaRRwEUZBg==", "c38062db-1840-4aff-b228-da12f3385b4a", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "257091c3-2740-40a8-b347-459dd5bb0efc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "a537a1eb-d336-4867-bbef-9ccc512911fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c32b06e8-2942-4d88-ab75-9faf66ddf321", false, "AQAAAAEAACcQAAAAEP7f4c2aCvkaebXbvT482ZME5rxWb2vmaYF1SMZID2elMSqXrpFBYHcMRf+hEEkOqA==", "d6ae93a4-83c4-4560-825b-c3387571df9e", "USER@LOCALHOST.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc9e86ee-583e-4747-abf2-ee805051b2af", false, "AQAAAAEAACcQAAAAEJfbmjh4wIUi4SVY7miJK9Y8IcXCanbu5ODIgk+VKAh7UTlnAgWvlh8y7tI1DPE6VQ==", "82c4627e-8a22-4814-9873-ce4784542cd7", "ADMIN@LOCALHOST.COM" });
        }
    }
}
