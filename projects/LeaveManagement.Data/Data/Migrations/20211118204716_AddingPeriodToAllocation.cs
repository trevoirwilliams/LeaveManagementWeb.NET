using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "472890e8-1ca8-4b2f-8767-27c4d549dedc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c7f3f756-cb8f-472c-b837-a7589d1a565f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ef2e6b4-90ef-4bf3-bdb9-490c3e913ba1", "AQAAAAEAACcQAAAAEFnwnIbQzpRMNzp3Z570GQOoeoSdD48lkYxQHsPoFpOmjZ8mO4sCQUFcQEXI8vOCFw==", "33412247-cd3a-41e4-8783-f86f32de65cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91c18ca6-9af0-48e0-9b8d-e188fd4320f3", "AQAAAAEAACcQAAAAEFWVo81Ny4UfxDrL9I8Rgp1zYJbHVqQpkr9f7xUIZvkl7Lss9zn3Aa/KEI4rP9GEEQ==", "e08a1a86-6848-4364-b2a6-1c43fd8586ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ee258f4-52c6-4315-970c-dbd3072232bb", "AQAAAAEAACcQAAAAEGFyHgaLxjZeIjzWPqY04hRwb8DXsDp+hpSKUkSsfGzJBcbfIxYazLGoxCg8K0Xycg==", "0c284d65-5601-4213-80ea-63f402e4fe35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaf70aec-f5af-480a-a595-98a19516ad4a", "AQAAAAEAACcQAAAAEPrjEzZn7AM4NH7xayyXqd4aWwL9BDQfyAWeWaG128PbfKZi/HShxlEKYaRRwEUZBg==", "c38062db-1840-4aff-b228-da12f3385b4a" });
        }
    }
}
