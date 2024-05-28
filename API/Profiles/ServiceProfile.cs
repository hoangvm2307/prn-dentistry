using AutoMapper;
using prn_dentistry.API.DTOs.ServiceDto;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Profiles
{
  public class ServiceProfile : Profile
  {
    public ServiceProfile()
    {
      CreateMap<Service, ServiceDto>();
      CreateMap<ServiceCreateDto, Service>();
      CreateMap<ServiceUpdateDto, Service>();
    }
  }
}