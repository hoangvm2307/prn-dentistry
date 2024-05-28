using prn_dentistry.API.DTOs.AppointmentDTO;

namespace prn_dentistry.API.Services
{
  public interface IAppointmentService
  {
    Task<IEnumerable<AppointmentDTO>> GetAllAppointmentsAsync();
    Task<AppointmentDTO> GetAppointmentByIdAsync(int id);
    Task<AppointmentDTO> CreateAppointmentAsync(AppointmentCreateDTO appointmentCreateDTO);
    Task<AppointmentDTO> UpdateAppointmentAsync(int id, AppointmentUpdateDTO appointmentUpdateDTO);
    Task<bool> DeleteAppointmentAsync(int id);
  }
}