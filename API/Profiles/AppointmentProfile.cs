
using AutoMapper;
using prn_dentistry.API.DTOs.AppointmentDTO;
using prn_dentistry.API.Models;
namespace prn_dentistry.API.Profiles

{
  public class AppointmentProfile : Profile
  {
    public AppointmentProfile()
    {
      CreateMap<AppointmentDTO, Appointment>().ReverseMap();
      CreateMap<AppointmentCreateDTO, Appointment>().ReverseMap();
      CreateMap<AppointmentUpdateDTO, Appointment>().ReverseMap();
    }
  }
}