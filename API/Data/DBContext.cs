using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Data
{
  public class DBContext : IdentityDbContext<IdentityUser>
  {
    public DBContext(DbContextOptions<DBContext> options)
           : base(options)
    {
    }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<ClinicOwner> ClinicOwners { get; set; }
    public DbSet<ClinicSchedule> ClinicSchedules { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Dentist> Dentists { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<IdentityRole>()
          .HasData(
              new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" },
              new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" }
          );
      builder.Entity<Service>()
                 .Property(s => s.Price)
                 .HasColumnType("decimal(18,2)");

      // Configure identity columns
      builder.Entity<Appointment>()
          .Property(a => a.AppointmentID)
          .ValueGeneratedOnAdd();

      builder.Entity<Clinic>()
          .Property(c => c.ClinicID)
          .ValueGeneratedOnAdd();

      builder.Entity<ClinicOwner>()
          .Property(co => co.OwnerID)
          .ValueGeneratedOnAdd();

      builder.Entity<ClinicSchedule>()
          .Property(cs => cs.ScheduleID)
          .ValueGeneratedOnAdd();

      builder.Entity<Customer>()
          .Property(cu => cu.CustomerID)
          .ValueGeneratedOnAdd();

      builder.Entity<Dentist>()
          .Property(d => d.DentistID)
          .ValueGeneratedOnAdd();

      builder.Entity<Service>()
          .Property(s => s.ServiceID)
          .ValueGeneratedOnAdd();

      builder.Entity<TreatmentPlan>()
          .Property(tp => tp.PlanID)
          .ValueGeneratedOnAdd();

      builder.Entity<ClinicOwner>()
            .HasMany(c => c.Clinics)
            .WithOne(c => c.ClinicOwner)
            .HasForeignKey(c => c.OwnerID);

      // Clinic -> Dentists (One to Many)
      builder.Entity<Clinic>()
          .HasMany(c => c.Dentists)
          .WithOne(d => d.Clinic)
          .HasForeignKey(d => d.ClinicID);

      // Clinic -> ClinicSchedules (One to Many)
      builder.Entity<Clinic>()
          .HasMany(c => c.ClinicSchedules)
          .WithOne(cs => cs.Clinic)
          .HasForeignKey(cs => cs.ClinicID);

      // Customer -> Appointments (One to Many)
      builder.Entity<Customer>()
          .HasMany(c => c.Appointments)
          .WithOne(a => a.Customer)
          .HasForeignKey(a => a.CustomerID);

      // Dentist -> Appointments (One to Many)
      builder.Entity<Dentist>()
          .HasMany(d => d.Appointments)
          .WithOne(a => a.Dentist)
          .HasForeignKey(a => a.DentistID);

      // Service -> Appointments (One to Many)
      builder.Entity<Service>()
          .HasMany(s => s.Appointments)
          .WithOne(a => a.Service)
          .HasForeignKey(a => a.ServiceID);

      // Customer -> TreatmentPlans (One to Many)
      builder.Entity<Customer>()
          .HasMany(c => c.TreatmentPlans)
          .WithOne(tp => tp.Customer)
          .HasForeignKey(tp => tp.CustomerID);

      // Dentist -> TreatmentPlans (One to Many)
      builder.Entity<Dentist>()
          .HasMany(d => d.TreatmentPlans)
          .WithOne(tp => tp.Dentist)
          .HasForeignKey(tp => tp.DentistID);

      // Customer -> ChatMessages (One to Many)
      builder.Entity<Customer>()
          .HasMany(c => c.ChatMessages)
          .WithOne(cm => cm.Sender)
          .HasForeignKey(cm => cm.SenderID);

      // Dentist -> ChatMessages (One to Many)
      builder.Entity<Dentist>()
          .HasMany(d => d.ChatMessages)
          .WithOne(cm => cm.Receiver)
          .HasForeignKey(cm => cm.ReceiverID);
    }


  }
}