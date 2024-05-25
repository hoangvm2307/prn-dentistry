﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using prn_dentistry.API.Data;

#nullable disable

namespace prn_dentistry.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("prn_dentistry.API.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AppointmentID"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<int>("DentistID")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceID")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AppointmentID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DentistID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ChatMessage", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageID"));

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("integer");

                    b.Property<int>("SenderID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MessageID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("ChatMessage");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Clinic", b =>
                {
                    b.Property<int>("ClinicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClinicID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ClosingHours")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OpeningHours")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("OwnerID")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ClinicID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ClinicOwner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OwnerID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OwnerID");

                    b.ToTable("ClinicOwners");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ClinicSchedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScheduleID"));

                    b.Property<int>("ClinicID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ClosingTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxPatientsPerSlot")
                        .HasColumnType("integer");

                    b.Property<DateTime>("OpeningTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SlotDuration")
                        .HasColumnType("integer");

                    b.HasKey("ScheduleID");

                    b.HasIndex("ClinicID");

                    b.ToTable("ClinicSchedules");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Dentist", b =>
                {
                    b.Property<int>("DentistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DentistID"));

                    b.Property<int>("ClinicID")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DentistID");

                    b.HasIndex("ClinicID");

                    b.ToTable("Dentists");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.TreatmentPlan", b =>
                {
                    b.Property<int>("PlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlanID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer");

                    b.Property<int>("DentistID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("NextAppointmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("PlanID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("DentistID");

                    b.ToTable("TreatmentPlans");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Appointment", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prn_dentistry.API.Models.Dentist", "Dentist")
                        .WithMany("Appointments")
                        .HasForeignKey("DentistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prn_dentistry.API.Models.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Dentist");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ChatMessage", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.Dentist", "Receiver")
                        .WithMany("ChatMessages")
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prn_dentistry.API.Models.Customer", "Sender")
                        .WithMany("ChatMessages")
                        .HasForeignKey("SenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Clinic", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.ClinicOwner", "ClinicOwner")
                        .WithMany("Clinics")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClinicOwner");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ClinicSchedule", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.Clinic", "Clinic")
                        .WithMany("ClinicSchedules")
                        .HasForeignKey("ClinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Dentist", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.Clinic", "Clinic")
                        .WithMany("Dentists")
                        .HasForeignKey("ClinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.TreatmentPlan", b =>
                {
                    b.HasOne("prn_dentistry.API.Models.Customer", "Customer")
                        .WithMany("TreatmentPlans")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("prn_dentistry.API.Models.Dentist", "Dentist")
                        .WithMany("TreatmentPlans")
                        .HasForeignKey("DentistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Dentist");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Clinic", b =>
                {
                    b.Navigation("ClinicSchedules");

                    b.Navigation("Dentists");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.ClinicOwner", b =>
                {
                    b.Navigation("Clinics");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Customer", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ChatMessages");

                    b.Navigation("TreatmentPlans");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Dentist", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("ChatMessages");

                    b.Navigation("TreatmentPlans");
                });

            modelBuilder.Entity("prn_dentistry.API.Models.Service", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
