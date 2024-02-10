using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class _3_updateMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "student_address_id_fk",
                table: "StudentAddresses");

            migrationBuilder.DropIndex(
                name: "IX_StudentAddresses_StudentId",
                table: "StudentAddresses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentAddresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_AddressId",
                table: "Students",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentAddresses_AddressId",
                table: "Students",
                column: "AddressId",
                principalTable: "StudentAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentAddresses_AddressId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AddressId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddresses_StudentId",
                table: "StudentAddresses",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "student_address_id_fk",
                table: "StudentAddresses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
