using Microsoft.EntityFrameworkCore;
using prn_dentistry.API.Data;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Repositories
{
  public class ClinicScheduleRepository : IClinicScheduleRepository
  {
    private readonly DBContext _context;

    public ClinicScheduleRepository(DBContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<ClinicSchedule>> GetAllClinicSchedulesAsync()
    {
      return await _context.ClinicSchedules.ToListAsync();
    }

    public async Task<ClinicSchedule> GetClinicScheduleByIdAsync(int id)
    {
      return await _context.ClinicSchedules.FindAsync(id);
    }

    public async Task AddClinicScheduleAsync(ClinicSchedule clinicSchedule)
    {
      await _context.ClinicSchedules.AddAsync(clinicSchedule);
      await _context.SaveChangesAsync();
    }

    public async Task UpdateClinicScheduleAsync(ClinicSchedule clinicSchedule)
    {
      _context.Entry(clinicSchedule).State = EntityState.Modified;
      await _context.SaveChangesAsync();
    }

    public async Task DeleteClinicScheduleAsync(int id)
    {
      var clinicSchedule = await _context.ClinicSchedules.FindAsync(id);
      if (clinicSchedule != null)
      {
        _context.ClinicSchedules.Remove(clinicSchedule);
        await _context.SaveChangesAsync();
      }
    }
  }
}