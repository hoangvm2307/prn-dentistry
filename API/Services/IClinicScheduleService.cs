using prn_dentistry.API.DTOs.ClinicScheduleDto;

namespace prn_dentistry.API.Services
{
  public interface IClinicScheduleService
  {
    Task<IEnumerable<ClinicScheduleDto>> GetAllClinicSchedulesAsync();
    Task<ClinicScheduleDto> GetClinicScheduleByIdAsync(int id);
    Task<ClinicScheduleDto> CreateClinicScheduleAsync(ClinicScheduleCreateDto clinicScheduleCreateDto);
    Task<ClinicScheduleDto> UpdateClinicScheduleAsync(int id, ClinicScheduleUpdateDto clinicScheduleUpdateDto);
    Task<bool> DeleteClinicScheduleAsync(int id);
  }
}