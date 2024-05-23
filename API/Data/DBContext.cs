using Microsoft.EntityFrameworkCore;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Data
{
  public class DBContext : DbContext
  {
    public DBContext(DbContextOptions<DBContext> options)
           : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Service>()
          .Property(s => s.Price)
          .HasColumnType("decimal(18,2)");
    }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<ClinicOwner> ClinicOwners { get; set; }
    public DbSet<ClinicSchedule> ClinicSchedules { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Dentist> Dentists { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<TreatmentPlan> TreatmentPlans { get; set; }

  }
}