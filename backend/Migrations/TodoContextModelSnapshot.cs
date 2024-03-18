﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiJobSearch.Models;

#nullable disable

namespace WebApiJobSearch.Migrations
{
    [DbContext(typeof(TodoContext))]
    partial class TodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GetRiteExerciseGetRiteWorkout", b =>
                {
                    b.Property<int>("ExercisesId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutsId")
                        .HasColumnType("int");

                    b.HasKey("ExercisesId", "WorkoutsId");

                    b.HasIndex("WorkoutsId");

                    b.ToTable("GetRiteExerciseGetRiteWorkout");
                });

            modelBuilder.Entity("GetRiteOfficeGetRitePatient", b =>
                {
                    b.Property<int>("OfficesId")
                        .HasColumnType("int");

                    b.Property<int>("PatientsId")
                        .HasColumnType("int");

                    b.HasKey("OfficesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("GetRiteOfficeGetRitePatient");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.FluentGetRiteAppointmentGetRitePhysician", b =>
                {
                    b.Property<int?>("GetRitePhysicianId")
                        .HasColumnType("int");

                    b.Property<int?>("GetRiteAppointmentId")
                        .HasColumnType("int");

                    b.HasKey("GetRitePhysicianId", "GetRiteAppointmentId");

                    b.HasIndex("GetRiteAppointmentId");

                    b.ToTable("GetRiteAppointmentGetRitePhysicians", (string)null);
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GetRiteAddresses");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Injury")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PatientId");

                    b.ToTable("GetRiteAppointments");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointmentExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GetRiteAppointmentId")
                        .HasColumnType("int");

                    b.Property<int?>("GetRiteExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("Reps")
                        .HasColumnType("int");

                    b.Property<int?>("Sets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GetRiteAppointmentId");

                    b.HasIndex("GetRiteExerciseId");

                    b.ToTable("GetRiteAppointmentExercises");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointmentNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GetRiteAppointmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GetRiteAppointmentId");

                    b.ToTable("GetRiteAppointmentNotes");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BodyPart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDefault")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("GetRiteExercises");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("GetRiteLogin");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteOffice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("OfficeAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeAddressId")
                        .HasColumnType("int");

                    b.Property<string>("OfficeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeAddressId");

                    b.ToTable("GetRiteOffices");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Injury")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistoryNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("GetRitePatients");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePhysician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("GetRitePhysicians");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PhysicianId")
                        .HasColumnType("int");

                    b.Property<string>("TaskContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PhysicianId");

                    b.ToTable("GetRiteTasks");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GetRiteUser");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteWorkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BodyPart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<bool>("isDefault")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("GetRiteWorkouts");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("GetRiteExerciseGetRiteWorkout", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteExercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRiteWorkout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GetRiteOfficeGetRitePatient", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteOffice", null)
                        .WithMany()
                        .HasForeignKey("OfficesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRitePatient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiJobSearch.Models.FluentGetRiteAppointmentGetRitePhysician", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteAppointment", "GetRiteAppointment")
                        .WithMany()
                        .HasForeignKey("GetRiteAppointmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRitePhysician", "GetRitePhysician")
                        .WithMany()
                        .HasForeignKey("GetRitePhysicianId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("GetRiteAppointment");

                    b.Navigation("GetRitePhysician");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointment", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteOffice", "Office")
                        .WithMany("Appointments")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRitePatient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointmentExercise", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteAppointment", "GetRiteAppointment")
                        .WithMany("Exercises")
                        .HasForeignKey("GetRiteAppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRiteExercise", "GetRiteExercise")
                        .WithMany()
                        .HasForeignKey("GetRiteExerciseId");

                    b.Navigation("GetRiteAppointment");

                    b.Navigation("GetRiteExercise");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointmentNote", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteAppointment", "GetRiteAppointment")
                        .WithMany("Notes")
                        .HasForeignKey("GetRiteAppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GetRiteAppointment");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteExercise", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteOffice", "Office")
                        .WithMany("Exercises")
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteLogin", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteUser", "User")
                        .WithOne("GetRiteLogin")
                        .HasForeignKey("WebApiJobSearch.Models.GetRiteLogin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteOffice", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteAddress", "OfficeAddress")
                        .WithMany()
                        .HasForeignKey("OfficeAddressId");

                    b.Navigation("OfficeAddress");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePatient", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteAddress", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("WebApiJobSearch.Models.GetRiteUser", "User")
                        .WithOne("GetRitePatient")
                        .HasForeignKey("WebApiJobSearch.Models.GetRitePatient", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePhysician", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteOffice", "Office")
                        .WithMany("Physicians")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiJobSearch.Models.GetRiteUser", "User")
                        .WithOne("GetRitePhysician")
                        .HasForeignKey("WebApiJobSearch.Models.GetRitePhysician", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteTask", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRitePhysician", "Physician")
                        .WithMany("Tasks")
                        .HasForeignKey("PhysicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physician");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteWorkout", b =>
                {
                    b.HasOne("WebApiJobSearch.Models.GetRiteOffice", "Office")
                        .WithMany("Workout")
                        .HasForeignKey("OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteAppointment", b =>
                {
                    b.Navigation("Exercises");

                    b.Navigation("Notes");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteOffice", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Exercises");

                    b.Navigation("Physicians");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePatient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRitePhysician", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("WebApiJobSearch.Models.GetRiteUser", b =>
                {
                    b.Navigation("GetRiteLogin");

                    b.Navigation("GetRitePatient");

                    b.Navigation("GetRitePhysician");
                });
#pragma warning restore 612, 618
        }
    }
}
