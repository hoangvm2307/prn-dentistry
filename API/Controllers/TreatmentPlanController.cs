using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.TreatmentPlanDto;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Controllers
{
  public class TreatmentPlanController : BaseApiController
  {
    private readonly ITreatmentPlanService _treatmentPlanService;

    public TreatmentPlanController(ITreatmentPlanService treatmentPlanService)
    {
      _treatmentPlanService = treatmentPlanService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TreatmentPlanDto>>> GetAllTreatmentPlans()
    {
      var treatmentPlans = await _treatmentPlanService.GetAllTreatmentPlansAsync();
      return Ok(treatmentPlans);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TreatmentPlanDto>> GetTreatmentPlan(int id)
    {
      var treatmentPlan = await _treatmentPlanService.GetTreatmentPlanByIdAsync(id);

      if (treatmentPlan == null)
        return NotFound();

      return Ok(treatmentPlan);
    }

    [HttpPost]
    public async Task<ActionResult<TreatmentPlanDto>> CreateTreatmentPlan(TreatmentPlanCreateDto treatmentPlanCreateDto)
    {
      var treatmentPlan = await _treatmentPlanService.CreateTreatmentPlanAsync(treatmentPlanCreateDto);
      return CreatedAtAction(nameof(GetTreatmentPlan), new { id = treatmentPlan.PlanID }, treatmentPlan);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTreatmentPlan(int id, TreatmentPlanUpdateDto treatmentPlanUpdateDto)
    {
      var updatedTreatmentPlan = await _treatmentPlanService.UpdateTreatmentAsync(id, treatmentPlanUpdateDto);
      if (updatedTreatmentPlan == null)
        return NotFound();

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTreatmentPlan(int id)
    {
      var success = await _treatmentPlanService.DeleteTreatmentPlanAsync(id);
      if (!success)
        return NotFound();

      return NoContent();
    }
  }
}