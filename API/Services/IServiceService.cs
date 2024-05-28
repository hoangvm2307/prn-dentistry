using prn_dentistry.API.DTOs.ServiceDto;

namespace prn_dentistry.API.Services
{
  public interface IServiceService
  {
    Task<IEnumerable<ServiceDto>> GetAllServicesAsync();
    Task<ServiceDto> GetServiceByIdAsync(int id);
    Task<ServiceDto> CreateServiceAsync(ServiceCreateDto serviceCreateDto);
    Task<ServiceDto> UpdateServiceAsync(int id, ServiceUpdateDto serviceUpdateDto);
    Task<bool> DeleteServiceAsync(int id);
  }
}