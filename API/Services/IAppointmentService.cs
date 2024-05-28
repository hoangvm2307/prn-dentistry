using prn_dentistry.API.DTOs.AppointmentDto;

namespace prn_dentistry.API.Services
{
  public interface IAppointmentService
  {
    Task<IEnumerable<AppointmentDto>> GetAllAppointmentsAsync();
    Task<AppointmentDto> GetAppointmentByIdAsync(int id);
    Task<AppointmentDto> CreateAppointmentAsync(AppointmentCreateDto appointmentCreateDto);
    Task<AppointmentDto> UpdateAppointmentAsync(int id, AppointmentUpdateDto appointmentUpdateDto);
    Task<bool> DeleteAppointmentAsync(int id);
  }
}