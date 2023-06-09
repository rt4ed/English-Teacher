﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TeacherEnglish;

#nullable disable

namespace TeacherEnglish.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230416121126_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TeacherEnglish.Entities.IrregularVerb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PastParticiple")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PastSimple")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Test")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IrregularVerbs");
                });
#pragma warning restore 612, 618
        }
    }
}
