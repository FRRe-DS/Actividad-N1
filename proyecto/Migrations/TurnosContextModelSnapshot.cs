﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto.Models;

namespace proyecto.Migrations
{
    [DbContext(typeof(TurnosContext))]
    partial class TurnosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("proyecto.Models.Medico", b =>
                {
                    b.Property<int>("medicoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("especialidad");

                    b.Property<string>("nombre");

                    b.HasKey("medicoId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("proyecto.Models.Paciente", b =>
                {
                    b.Property<int>("pacienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("apellido");

                    b.Property<int>("medicoId");

                    b.Property<string>("nombre");

                    b.HasKey("pacienteId");

                    b.HasIndex("medicoId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("proyecto.Models.Paciente", b =>
                {
                    b.HasOne("proyecto.Models.Medico", "medico")
                        .WithMany("Pacientes")
                        .HasForeignKey("medicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}