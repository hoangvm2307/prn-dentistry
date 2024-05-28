using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.ClinicScheduleDto;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Controllers
{
  public class ClinicScheduleController : BaseApiController
  {
    private readonly IClinicScheduleService _clinicScheduleService;

    public ClinicScheduleController(IClinicScheduleService clinicScheduleService)
    {
      _clinicScheduleService = clinicScheduleService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClinicScheduleDto>>> GetAllClinicSchedules()
    {
      var clinicSchedules = await _clinicScheduleService.GetAllClinicSchedulesAsync();
      return Ok(clinicSchedules);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ClinicScheduleDto>> GetClinicSchedule(int id)
    {
      var clinicSchedule = await _clinicScheduleService.GetClinicScheduleByIdAsync(id);
      if (clinicSchedule == null)
      {
        return NotFound();
      }

      return Ok(clinicSchedule);
    }

    [HttpPost]
    public async Task<ActionResult<ClinicScheduleDto>> CreateClinicSchedule(ClinicScheduleCreateDto clinicScheduleCreateDto)
    {
      var clinicSchedule = await _clinicScheduleService.CreateClinicScheduleAsync(clinicScheduleCreateDto);
      return CreatedAtAction(nameof(GetClinicSchedule), new { id = clinicSchedule.ScheduleID }, clinicSchedule);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClinicSchedule(int id, ClinicScheduleUpdateDto clinicScheduleUpdateDto)
    {
      var updatedClinicSchedule = await _clinicScheduleService.UpdateClinicScheduleAsync(id, clinicScheduleUpdateDto);
      if (updatedClinicSchedule == null)
      {
        return NotFound();
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClinicSchedule(int id)
    {
      var result = await _clinicScheduleService.DeleteClinicScheduleAsync(id);
      if (!result)
      {
        return NotFound();
      }

      return NoContent();
    }
  }
}