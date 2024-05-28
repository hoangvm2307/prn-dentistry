using prn_dentistry.API.DTOs.TreatmentPlanDto;

namespace prn_dentistry.API.Services
{
  public interface ITreatmentPlanService
  {
    Task<IEnumerable<TreatmentPlanDto>> GetAllTreatmentPlansAsync();
    Task<TreatmentPlanDto> GetTreatmentPlanByIdAsync(int id);
    Task<TreatmentPlanDto> CreateTreatmentPlanAsync(TreatmentPlanCreateDto appointmentCreateDto);
    Task<TreatmentPlanDto> UpdateTreatmentAsync(int id, TreatmentPlanUpdateDto appointmentUpdateDto);
    Task<bool> DeleteTreatmentPlanAsync(int id);
  }
}