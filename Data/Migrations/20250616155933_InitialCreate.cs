using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinicafisioapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPF = table.Column<string>(type: "TEXT", maxLength: 14, nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DDD = table.Column<int>(type: "INTEGER", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Complement = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedialAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedialAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedialAppointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PatientId",
                table: "AspNetUsers",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedialAppointments_PatientId",
                table: "MedialAppointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Patients_PatientId",
                table: "AspNetUsers",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Patients_PatientId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MedialAppointments");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PatientId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "AspNetUsers");
        }
    }
}
