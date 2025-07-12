using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinicafisioapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressAndGenderConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Patients",
                newName: "Address_Street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Patients",
                newName: "Address_State");

            migrationBuilder.RenameColumn(
                name: "Complement",
                table: "Patients",
                newName: "Address_Complement");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Patients",
                newName: "Address_City");

            migrationBuilder.AddColumn<string>(
                name: "Address_ZipCode",
                table: "Patients",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_ZipCode",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "Address_Street",
                table: "Patients",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Address_State",
                table: "Patients",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "Address_Complement",
                table: "Patients",
                newName: "Complement");

            migrationBuilder.RenameColumn(
                name: "Address_City",
                table: "Patients",
                newName: "City");
        }
    }
}
