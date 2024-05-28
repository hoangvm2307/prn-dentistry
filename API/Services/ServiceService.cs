using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using prn_dentistry.API.DTOs.ServiceDto;
using prn_dentistry.API.Models;
using prn_dentistry.API.Repositories;

namespace prn_dentistry.API.Services
{
  public class ServiceService : IServiceService
  {
    private readonly IServiceRepository _serviceRepository;
    private readonly IMapper _mapper;

    public ServiceService(IServiceRepository serviceRepository, IMapper mapper)
    {
      _serviceRepository = serviceRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<ServiceDto>> GetAllServicesAsync()
    {
      var services = await _serviceRepository.GetAllServicesAsync();
      return _mapper.Map<IEnumerable<ServiceDto>>(services);
    }

    public async Task<ServiceDto> GetServiceByIdAsync(int id)
    {
      var service = await _serviceRepository.GetServiceByIdAsync(id);
      return _mapper.Map<ServiceDto>(service);
    }

    public async Task<ServiceDto> CreateServiceAsync(ServiceCreateDto serviceCreateDto)
    {
      var service = _mapper.Map<Service>(serviceCreateDto);
      await _serviceRepository.AddServiceAsync(service);
      return _mapper.Map<ServiceDto>(service);
    }

    public async Task<ServiceDto> UpdateServiceAsync(int id, ServiceUpdateDto serviceUpdateDto)
    {
      var service = await _serviceRepository.GetServiceByIdAsync(id);
      if (service == null)
      {
        return null;
      }

      _mapper.Map(serviceUpdateDto, service);
      await _serviceRepository.UpdateServiceAsync(service);

      return _mapper.Map<ServiceDto>(service);
    }

    public async Task<bool> DeleteServiceAsync(int id)
    {
      var service = await _serviceRepository.GetServiceByIdAsync(id);
      if (service == null)
      {
        return false;
      }

      await _serviceRepository.DeleteServiceAsync(id);
      return true;
    }
  }
}