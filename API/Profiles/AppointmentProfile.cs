
using AutoMapper;
using prn_dentistry.API.DTOs.AppointmentDto;
using prn_dentistry.API.Models;
namespace prn_dentistry.API.Profiles

{
  public class AppointmentProfile : Profile
  {
    public AppointmentProfile()
    {
      CreateMap<AppointmentDto, Appointment>().ReverseMap();
      CreateMap<AppointmentCreateDto, Appointment>().ReverseMap();
      CreateMap<AppointmentUpdateDto, Appointment>().ReverseMap();
    }
  }
}