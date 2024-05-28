using prn_dentistry.API.Models;

namespace prn_dentistry.API.Repositories
{
  public interface ITreatmentPlanRepository
  {
    Task<IEnumerable<TreatmentPlan>> GetAllTreatmentPlansAsync();
    Task<TreatmentPlan> GetTreatmentPlanByIdAsync(int id);
    Task AddTreatmentPlanAsync(TreatmentPlan appointment);
    Task UpdateTreatmentPlanAsync(TreatmentPlan appointment);
    Task DeleteTreatmentPlanAsync(int id);
  }
}