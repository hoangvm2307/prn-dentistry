using AutoMapper;
using prn_dentistry.API.DTOs.ClinicScheduleDto;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Profiles
{
  public class ClinicScheduleProfile : Profile
  {
    public ClinicScheduleProfile()
    {
      CreateMap<ClinicSchedule, ClinicScheduleDto>();
      CreateMap<ClinicScheduleCreateDto, ClinicSchedule>();
      CreateMap<ClinicScheduleUpdateDto, ClinicSchedule>();
    }
  }
}