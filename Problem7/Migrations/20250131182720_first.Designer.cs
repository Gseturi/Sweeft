﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SweeftEFCodefirst.Context;

#nullable disable

namespace SweeftEFCodefirst.Migrations
{
    [DbContext(typeof(SchoolDbcontext))]
    [Migration("20250131182720_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+Pupil", b =>
                {
                    b.Property<int>("PupilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PupilID"));

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PupilID");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+Teacher", b =>
                {
                    b.Property<string>("TeacherID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+TeacherPupil", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PupilId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "PupilId");

                    b.HasIndex("PupilId");

                    b.ToTable("TeacherPupils");
                });

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+TeacherPupil", b =>
                {
                    b.HasOne("SweeftEFCodefirst.Models.SchoolModels+Pupil", "Pupil")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SweeftEFCodefirst.Models.SchoolModels+Teacher", "Teacher")
                        .WithMany("TeacherPupils")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+Pupil", b =>
                {
                    b.Navigation("TeacherPupils");
                });

            modelBuilder.Entity("SweeftEFCodefirst.Models.SchoolModels+Teacher", b =>
                {
                    b.Navigation("TeacherPupils");
                });
#pragma warning restore 612, 618
        }
    }
}
