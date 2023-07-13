using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "acudiente",
                columns: table => new
                {
                    Attendant_cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Attendant_telephone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Attendant_address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Attendant_fullname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acudiente", x => x.Attendant_cod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "consultorio",
                columns: table => new
                {
                    Constroom_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Constroom_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultorio", x => x.Constroom_code);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "especialidad",
                columns: table => new
                {
                    Speciality_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Speciality_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidad", x => x.Speciality_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado_cita",
                columns: table => new
                {
                    Appointmenstate_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Appointmenstate_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_cita", x => x.Appointmenstate_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Gen_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Gen_Name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gen_abbreviation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.Gen_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_documento",
                columns: table => new
                {
                    Typedoc_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Typedoc_nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Typedoc_abbreviation = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_documento", x => x.Typedoc_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medico",
                columns: table => new
                {
                    Doctor_tuition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Doctor_fullName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Doctor_consroom = table.Column<int>(type: "int", nullable: false),
                    Doctor_speciality = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico", x => x.Doctor_tuition);
                    table.ForeignKey(
                        name: "FK_medico_consultorio_Doctor_consroom",
                        column: x => x.Doctor_consroom,
                        principalTable: "consultorio",
                        principalColumn: "Constroom_code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medico_especialidad_Doctor_speciality",
                        column: x => x.Doctor_speciality,
                        principalTable: "especialidad",
                        principalColumn: "Speciality_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cita",
                columns: table => new
                {
                    Appointment_cod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Appointment_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Appointment_state = table.Column<int>(type: "int", nullable: false),
                    Appointment_Medic = table.Column<int>(type: "int", nullable: false),
                    Appointment_Userdata = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cita", x => x.Appointment_cod);
                    table.ForeignKey(
                        name: "FK_cita_estado_cita_Appointment_state",
                        column: x => x.Appointment_state,
                        principalTable: "estado_cita",
                        principalColumn: "Appointmenstate_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cita_medico_Appointment_Medic",
                        column: x => x.Appointment_Medic,
                        principalTable: "medico",
                        principalColumn: "Doctor_tuition",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Usu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Usu_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_second_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_first_last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_second_last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_telephone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_history = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CitaAppointment_cod = table.Column<int>(type: "int", nullable: true),
                    Usu_address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usu_type_document = table.Column<int>(type: "int", nullable: false),
                    Usu_gender = table.Column<int>(type: "int", nullable: false),
                    Usu_attendant = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Usu_id);
                    table.ForeignKey(
                        name: "FK_usuario_acudiente_Usu_attendant",
                        column: x => x.Usu_attendant,
                        principalTable: "acudiente",
                        principalColumn: "Attendant_cod",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_cita_CitaAppointment_cod",
                        column: x => x.CitaAppointment_cod,
                        principalTable: "cita",
                        principalColumn: "Appointment_cod");
                    table.ForeignKey(
                        name: "FK_usuario_genero_Usu_gender",
                        column: x => x.Usu_gender,
                        principalTable: "genero",
                        principalColumn: "Gen_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuario_tipo_documento_Usu_type_document",
                        column: x => x.Usu_type_document,
                        principalTable: "tipo_documento",
                        principalColumn: "Typedoc_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cita_Appointment_Medic",
                table: "cita",
                column: "Appointment_Medic");

            migrationBuilder.CreateIndex(
                name: "IX_cita_Appointment_state",
                table: "cita",
                column: "Appointment_state");

            migrationBuilder.CreateIndex(
                name: "IX_medico_Doctor_consroom",
                table: "medico",
                column: "Doctor_consroom");

            migrationBuilder.CreateIndex(
                name: "IX_medico_Doctor_speciality",
                table: "medico",
                column: "Doctor_speciality");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_CitaAppointment_cod",
                table: "usuario",
                column: "CitaAppointment_cod");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Usu_attendant",
                table: "usuario",
                column: "Usu_attendant");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Usu_gender",
                table: "usuario",
                column: "Usu_gender");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_Usu_type_document",
                table: "usuario",
                column: "Usu_type_document");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "acudiente");

            migrationBuilder.DropTable(
                name: "cita");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipo_documento");

            migrationBuilder.DropTable(
                name: "estado_cita");

            migrationBuilder.DropTable(
                name: "medico");

            migrationBuilder.DropTable(
                name: "consultorio");

            migrationBuilder.DropTable(
                name: "especialidad");
        }
    }
}
