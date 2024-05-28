using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace prn_dentistry.Migrations
{
    /// <inheritdoc />
    public partial class fixclinicandclinicowners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clinics_ClinicOwners_OwnerID",
                table: "Clinics");

            migrationBuilder.DropIndex(
                name: "IX_Clinics_OwnerID",
                table: "Clinics");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ec95f5-a134-44a3-89a3-fa125e1297f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ac4467-c60b-4d9a-9790-f0b7b953c28c");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Clinics");

            migrationBuilder.AddColumn<int>(
                name: "ClinicID",
                table: "ClinicOwners",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9875081-4227-4af3-b680-1505aa3f1996", null, "Customer", "CUSTOMER" },
                    { "ef2536b0-38e6-4af9-bb0c-ace26fa6291d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClinicOwners_ClinicID",
                table: "ClinicOwners",
                column: "ClinicID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicOwners_Clinics_ClinicID",
                table: "ClinicOwners",
                column: "ClinicID",
                principalTable: "Clinics",
                principalColumn: "ClinicID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClinicOwners_Clinics_ClinicID",
                table: "ClinicOwners");

            migrationBuilder.DropIndex(
                name: "IX_ClinicOwners_ClinicID",
                table: "ClinicOwners");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9875081-4227-4af3-b680-1505aa3f1996");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef2536b0-38e6-4af9-bb0c-ace26fa6291d");

            migrationBuilder.DropColumn(
                name: "ClinicID",
                table: "ClinicOwners");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Clinics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65ec95f5-a134-44a3-89a3-fa125e1297f1", null, "Admin", "ADMIN" },
                    { "88ac4467-c60b-4d9a-9790-f0b7b953c28c", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_OwnerID",
                table: "Clinics",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_ClinicOwners_OwnerID",
                table: "Clinics",
                column: "OwnerID",
                principalTable: "ClinicOwners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
