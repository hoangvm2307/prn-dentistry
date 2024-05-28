using prn_dentistry.API.Models;

namespace prn_dentistry.API.Repositories
{
  public interface IServiceRepository
  {
    Task<IEnumerable<Service>> GetAllServicesAsync();
    Task<Service> GetServiceByIdAsync(int id);
    Task AddServiceAsync(Service service);
    Task UpdateServiceAsync(Service service);
    Task DeleteServiceAsync(int id);
  }
}