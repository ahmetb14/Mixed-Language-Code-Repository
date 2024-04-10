using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("67684de1-ff33-4ecc-ba8b-49638eebc58f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f9ce55c9-8de2-4144-9599-10de72b6e9f6"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("af82bd92-5ddc-44fd-83f9-60b2bacfba29"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 77, 76, 206, 190, 158, 154, 237, 13, 249, 75, 145, 165, 253, 22, 95, 19, 187, 3, 161, 107, 187, 205, 201, 128, 73, 40, 219, 215, 45, 96, 14, 172, 166, 110, 229, 215, 161, 46, 66, 153, 177, 128, 19, 190, 227, 229, 3, 242, 159, 81, 96, 95, 211, 159, 126, 112, 85, 139, 14, 156, 98, 27, 192, 175 }, new byte[] { 6, 49, 15, 160, 12, 3, 211, 229, 200, 232, 72, 163, 3, 9, 59, 60, 44, 147, 28, 154, 7, 165, 129, 19, 190, 63, 121, 205, 130, 21, 94, 200, 119, 9, 253, 216, 62, 196, 135, 87, 216, 231, 125, 112, 240, 211, 169, 41, 77, 247, 114, 2, 137, 217, 140, 253, 254, 75, 192, 202, 142, 76, 199, 121, 176, 110, 151, 54, 51, 180, 33, 231, 62, 5, 201, 106, 132, 7, 62, 34, 245, 108, 64, 203, 202, 9, 6, 90, 44, 26, 181, 96, 48, 191, 4, 208, 162, 17, 179, 222, 59, 248, 83, 60, 233, 90, 168, 61, 11, 20, 15, 170, 16, 10, 58, 69, 201, 186, 38, 251, 155, 159, 108, 255, 23, 0, 168, 140 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("85b33b8e-3534-46dc-91e6-cbf52f08bbaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("af82bd92-5ddc-44fd-83f9-60b2bacfba29") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("85b33b8e-3534-46dc-91e6-cbf52f08bbaf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af82bd92-5ddc-44fd-83f9-60b2bacfba29"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f9ce55c9-8de2-4144-9599-10de72b6e9f6"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 0, 236, 131, 32, 93, 209, 77, 109, 126, 29, 235, 145, 58, 199, 94, 223, 101, 120, 230, 163, 97, 138, 12, 91, 187, 234, 89, 73, 153, 2, 86, 24, 100, 70, 151, 75, 178, 233, 185, 132, 121, 212, 147, 120, 102, 5, 249, 85, 5, 21, 158, 205, 39, 108, 247, 255, 247, 183, 60, 210, 205, 31, 145, 114 }, new byte[] { 50, 247, 116, 223, 210, 252, 134, 85, 46, 101, 13, 137, 22, 34, 239, 15, 94, 188, 96, 5, 23, 34, 146, 123, 58, 81, 61, 197, 160, 184, 156, 197, 189, 55, 33, 10, 206, 178, 168, 57, 158, 205, 91, 26, 79, 229, 115, 228, 101, 164, 129, 155, 235, 231, 217, 243, 62, 126, 192, 173, 67, 72, 29, 21, 231, 114, 184, 204, 207, 228, 112, 11, 103, 14, 19, 174, 100, 125, 17, 8, 169, 127, 138, 70, 226, 219, 143, 197, 169, 249, 203, 177, 238, 187, 104, 207, 161, 45, 53, 181, 237, 33, 181, 223, 7, 46, 121, 170, 137, 159, 219, 53, 87, 29, 232, 164, 209, 55, 56, 234, 199, 249, 87, 41, 69, 237, 134, 237 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("67684de1-ff33-4ecc-ba8b-49638eebc58f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f9ce55c9-8de2-4144-9599-10de72b6e9f6") });
        }
    }
}
