using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9db56f17-c41d-460b-a1b7-b24b23e685d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f54cc069-e05e-47b9-86d5-a95e93e5ffec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c66d4f-d016-4f94-b7d1-ae0cb0f7e17a", "AQAAAAEAACcQAAAAEAxiMBUxX8NlGeBwxfiIkjU2uPel8cR0Dn0lUtyxQ3qBWqanZPDjyOu9pFmk3kzpTw==", "a7a16fa2-f44a-444d-9197-ab05c6a723bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021d143f-9dbb-4eae-8a34-1df0acf2d075", "AQAAAAEAACcQAAAAEGi/UGWTa7kABqkQ9MyF0CCDCWXr59030bcynLIn6OiJf98m8thsNhJ2sa5+BN3htQ==", "4b8217ca-02b1-429d-b327-ca12358cddd6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3a754513-0201-413f-8536-ba185a4febfe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "91668961-050b-4a7b-814c-d806024a99a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552c30ea-fb13-4b9f-83b5-f873efdd5ad6", "AQAAAAEAACcQAAAAECkB2locfGG5dXsR38I8zZ9IK/99nFdrpQaOhQz/CXP40FBPfAEQlXKRkOmX5B2Qcg==", "b3ea8dd9-e3e5-4f85-8699-4426433703b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c052a81-6540-415c-a5eb-0bd926b625b6", "AQAAAAEAACcQAAAAEJ4EVHeOSZRKqYJFc12r8Bq1PDz9zZMr16zcEFnGgrs7ws7iF9Lmg+PTbLiRv0pJ8g==", "764c9ca6-6401-41eb-95aa-a8349b9d4e4d" });
        }
    }
}
