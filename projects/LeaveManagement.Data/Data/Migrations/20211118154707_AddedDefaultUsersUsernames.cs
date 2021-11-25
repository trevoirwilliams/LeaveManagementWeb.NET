using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c32b06e8-2942-4d88-ab75-9faf66ddf321", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEP7f4c2aCvkaebXbvT482ZME5rxWb2vmaYF1SMZID2elMSqXrpFBYHcMRf+hEEkOqA==", "d6ae93a4-83c4-4560-825b-c3387571df9e", "USER@LOCALHOST.COM" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc9e86ee-583e-4747-abf2-ee805051b2af", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJfbmjh4wIUi4SVY7miJK9Y8IcXCanbu5ODIgk+VKAh7UTlnAgWvlh8y7tI1DPE6VQ==", "82c4627e-8a22-4814-9873-ce4784542cd7", "ADMIN@LOCALHOST.COM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "11a66db1-d97a-4525-b3f3-637bf71f1e76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "841e61e5-acde-46f2-a3c9-51bdd26b8e1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "95df8cff-abed-4d79-a38c-6268800c98f0", null, "AQAAAAEAACcQAAAAEJ/TTuc11hQXgNsTDTwmWQQ80bcCXqbLkE1qTNcbvt1YZuNjrkmSldZdA8W35Vi3Ow==", "addda381-19d3-4713-9705-fe98322f7b10", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "56ae7c6f-a682-4b45-be88-ea00d75f307b", null, "AQAAAAEAACcQAAAAEPXbFMzbwvAtIyyXkjGrcEIbGniwvFu5uRgjxWwoL2N1+XlBz/kvzIdS6cH0cZV/zQ==", "05586524-a058-478b-9662-f058062df4cf", null });
        }
    }
}
