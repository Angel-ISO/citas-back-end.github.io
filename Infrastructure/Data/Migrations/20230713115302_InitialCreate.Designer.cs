﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(CitasContext))]
    [Migration("20230713115302_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entitities.Acudiente", b =>
                {
                    b.Property<int>("Attendant_cod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Attendant_address")
                        .HasColumnType("longtext");

                    b.Property<string>("Attendant_fullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Attendant_telephone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Attendant_cod");

                    b.ToTable("acudiente", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Cita", b =>
                {
                    b.Property<int>("Appointment_cod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Appointment_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Appointment_Medic")
                        .HasColumnType("int");

                    b.Property<int>("Appointment_Userdata")
                        .HasColumnType("int");

                    b.Property<int>("Appointment_state")
                        .HasColumnType("int");

                    b.HasKey("Appointment_cod");

                    b.HasIndex("Appointment_Medic");

                    b.HasIndex("Appointment_state");

                    b.ToTable("cita", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Consultorio", b =>
                {
                    b.Property<int>("Constroom_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Constroom_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Constroom_code");

                    b.ToTable("consultorio", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Especialidad", b =>
                {
                    b.Property<int>("Speciality_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Speciality_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Speciality_id");

                    b.ToTable("especialidad", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Estado_cita", b =>
                {
                    b.Property<int>("Appointmenstate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Appointmenstate_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Appointmenstate_id");

                    b.ToTable("estado_cita", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Genero", b =>
                {
                    b.Property<int>("Gen_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Gen_Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Gen_abbreviation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Gen_Id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Medico", b =>
                {
                    b.Property<int>("Doctor_tuition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Doctor_consroom")
                        .HasColumnType("int");

                    b.Property<string>("Doctor_fullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Doctor_speciality")
                        .HasColumnType("int");

                    b.HasKey("Doctor_tuition");

                    b.HasIndex("Doctor_consroom");

                    b.HasIndex("Doctor_speciality");

                    b.ToTable("medico", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Tipo_documento", b =>
                {
                    b.Property<int>("Typedoc_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Typedoc_abbreviation")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Typedoc_nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Typedoc_id");

                    b.ToTable("tipo_documento", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Usuario", b =>
                {
                    b.Property<int>("Usu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CitaAppointment_cod")
                        .HasColumnType("int");

                    b.Property<string>("Usu_address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Usu_attendant")
                        .HasColumnType("int");

                    b.Property<string>("Usu_email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_first_last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Usu_gender")
                        .HasColumnType("int");

                    b.Property<string>("Usu_history")
                        .HasColumnType("longtext");

                    b.Property<string>("Usu_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_second_last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_second_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Usu_telephone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Usu_type_document")
                        .HasColumnType("int");

                    b.HasKey("Usu_id");

                    b.HasIndex("CitaAppointment_cod");

                    b.HasIndex("Usu_attendant");

                    b.HasIndex("Usu_gender");

                    b.HasIndex("Usu_type_document");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Core.Entitities.Cita", b =>
                {
                    b.HasOne("Core.Entitities.Medico", "Medico")
                        .WithMany("Citas")
                        .HasForeignKey("Appointment_Medic")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entitities.Estado_cita", "Estado_Cita")
                        .WithMany("Citas")
                        .HasForeignKey("Appointment_state")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado_Cita");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Core.Entitities.Medico", b =>
                {
                    b.HasOne("Core.Entitities.Consultorio", "Consultorio")
                        .WithMany("Medicos")
                        .HasForeignKey("Doctor_consroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entitities.Especialidad", "Especialidad")
                        .WithMany("Medicos")
                        .HasForeignKey("Doctor_speciality")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultorio");

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Core.Entitities.Usuario", b =>
                {
                    b.HasOne("Core.Entitities.Cita", "Cita")
                        .WithMany("Usuarios")
                        .HasForeignKey("CitaAppointment_cod");

                    b.HasOne("Core.Entitities.Acudiente", "Acudiente")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_attendant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entitities.Genero", "Genero")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_gender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entitities.Tipo_documento", "Tipo_Documento")
                        .WithMany("Usuarios")
                        .HasForeignKey("Usu_type_document")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acudiente");

                    b.Navigation("Cita");

                    b.Navigation("Genero");

                    b.Navigation("Tipo_Documento");
                });

            modelBuilder.Entity("Core.Entitities.Acudiente", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entitities.Cita", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entitities.Consultorio", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entitities.Especialidad", b =>
                {
                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("Core.Entitities.Estado_cita", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entitities.Genero", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entitities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entitities.Tipo_documento", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}