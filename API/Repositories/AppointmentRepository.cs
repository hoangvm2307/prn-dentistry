using Microsoft.EntityFrameworkCore;
using prn_dentistry.API.Data;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Repositories
{
  public class AppointmentRepository : IAppointmentRepository
  {
    private readonly DBContext _context;
    public AppointmentRepository(DBContext context)
    {
      _context = context;
    }
    public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
    {
      return await _context.Appointments
      .Include(a => a.Customer)
      .Include(a => a.Dentist)
      .Include(a => a.Service)
      .ToListAsync();
    }
    public async Task<Appointment> GetAppointmentByIdAsync(int id)
    {
      var appointment = await _context.Appointments
          .Include(a => a.Customer)
          .Include(a => a.Dentist)
          .Include(a => a.Service)
          .FirstOrDefaultAsync(a => a.AppointmentID == id);
      return appointment;
    }
    public async Task AddAppointmentAsync(Appointment appointment)
    {
      await _context.Appointments.AddAsync(appointment);
      await _context.SaveChangesAsync();
    }

    public async Task DeleteAppointmentAsync(int id)
    {
      var appointment = await _context.Appointments.FindAsync(id);
      if (appointment != null)
      {
        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();
      }
    }

    public async Task UpdateAppointmentAsync(Appointment appointment)
    {
      _context.Appointments.Update(appointment);
      await _context.SaveChangesAsync();
    }
  }
}