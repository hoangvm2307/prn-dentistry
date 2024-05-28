using AutoMapper;
using prn_dentistry.API.DTOs.TreatmentPlanDto;
using prn_dentistry.API.Models;

namespace prn_dentistry.API.Profiles
{
  public class TreatmenPlanProfile : Profile
  {
    public TreatmenPlanProfile()
    {
      CreateMap<TreatmentPlan, TreatmentPlanDto>();
      CreateMap<TreatmentPlanCreateDto, TreatmentPlan>();
      CreateMap<TreatmentPlanUpdateDto, TreatmentPlan>();
    }
  }
}